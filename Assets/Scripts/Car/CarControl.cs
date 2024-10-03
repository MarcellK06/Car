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
  
  // TO ADD: https://www.cgtrader.com/free-3d-models/car/car/audi-a7-4288445a-9612-42f7-8ab2-ba4c8a87b0e2

  public void Start() {
    for(var k = 0; k < AngelEyes.Length; k++)
      AngelEyes[k].enabled = false;
    for(var k = 0; k < headLights.Length; k++)
      headLights[k].enabled = false;
    for(var k = 0; k < highBeams.Length; k++)
      highBeams[k].enabled = false;
  }



  public void Update() {
    if (Input.GetButtonDown("DRL"))
      for(var k = 0; k < AngelEyes.Length; k++)
        AngelEyes[k].enabled = !AngelEyes[k].enabled;

    if (Input.GetButtonDown("HL"))
      for(var k = 0; k < headLights.Length; k++)
        headLights[k].enabled = !headLights[k].enabled;

    if (Input.GetButtonDown("WD"))
      for(var k = 0; k < windows.Length; k++)
        windows[k].position = Vector3.Lerp(windows[k].position, windowDown, Time.deltaTime/2.5f);
        
    if (Input.GetButtonDown("WU"))
      for(var k = 0; k < windows.Length; k++)
        windows[k].position = Vector3.Lerp(windows[k].position, windowUp, Time.deltaTime/2.5f);

    if (Input.GetButton("HB"))
      Flash();

    if (Input.GetAxis("Vertical") < 0)
      for(var k = 0; k < brakeLights.Length; k++)
        brakeLights[k].enabled = !brakeLights[k].enabled;

  }


  IEnumerator Flash() {
      for(var k = 0; k < highBeams.Length; k++)
        highBeams[k].enabled = !highBeams[k].enabled;
      yield return new WaitForSeconds(0.05f);
  }
}
