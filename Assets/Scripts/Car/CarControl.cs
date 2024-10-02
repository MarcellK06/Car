using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
  public Light[] AngelEyes;
  public Light[] headLights;
  public Light[] brakeLights;
  public Light[] highBeams;
  public Transform[] windows;
  public SCC_Drivetrain car;

  public Vector3 windowUp;
  public Vector3 windowDown;
  

  public void Start() {
    for(var k = 0; k < AngelEyes.length; k++)
      AngelEyes[k].enabled = false;
    for(var k = 0; k < headLights.length; k++)
      headLights[k].enabled = false;
    for(var k = 0; k < highBeams.length; k++)
      highBeams[k].enabled = false;
  }

  public void Update() {
    if (Input.GetKeyDown("DRL"))
      for(var k = 0; k < AngelEyes.length; k++)
        AngelEyes[k].enabled = !AngelEyes[k].enabled;

    if (Input.GetKeyDown("HL"))
      for(var k = 0; k < headLights.length; k++)
        headLights[k].enabled = !headLights[k].enabled;

    if (Input.GetKeyDown("WD"))
      for(var k = 0; k < windows.length; k++)
        windows[k].position = Vector3.Lerp(windows[k].position, windowDown, Time.deltaTime/2.5f);
        
    if (Input.GetKeyDown("WU"))
      for(var k = 0; k < windows.length; k++)
        windows[k].position = Vector3.Lerp(windows[k].position, windowUp, Time.deltaTime/2.5f);

    if (Input.GetKey("HB"))
      Flash();

    if (Input.GetAxis("Vertical") < 0)
      for(var k = 0; k < brakeLights.length; k++)
        brakeLights[k].enabled = !brakeLights[k].enabled;

  }

  IEnumerator Flash() {
      for(var k = 0; k < highBeams.length; k++)
        highBeams[k].enabled = !highBeams[k].enabled;
      yield return new WaitForSeconds(0.05f);
  }
}
