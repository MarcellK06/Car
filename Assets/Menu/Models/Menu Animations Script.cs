using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimationsScript : MonoBehaviour
{
    public Light[] streetLights;
    public GameObject[] angelEyes;
    public Light[] headLights_;
    public Light[] highBeams;
    public AudioSource easteregg;
    bool turnOnLights = false;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var light in streetLights)
            light.intensity = 0;
        foreach(var light in headLights_)
            light.intensity = 0;
        foreach(var light in highBeams)
            light.intensity = 0;
        foreach(var eyes in angelEyes)
            eyes.SetActive(false);

            StartCoroutine(lightAnimation());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (turnOnLights) {
        foreach(var light in streetLights)
            light.intensity = Mathf.Lerp(light.intensity, 1, Time.deltaTime);
        foreach(var light in headLights_)
            light.intensity = Mathf.Lerp(light.intensity, 2, Time.deltaTime);
        }
    }

    IEnumerator lightAnimation() {
        yield return new WaitForSeconds(1f);
        foreach(var eyes in angelEyes)
            eyes.SetActive(true);
            for(var k = 0; k < 3; k++) {
        yield return new WaitForSeconds(0.1f);
        foreach(var eyes in angelEyes)
            eyes.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        foreach(var eyes in angelEyes)
            eyes.SetActive(true);
            }
        yield return new WaitForSeconds(1.5f);
            for(var k = 0; k < 2; k++) {
        yield return new WaitForSeconds(0.1f);
        foreach(var lights in highBeams)
            lights.intensity = 3;
        yield return new WaitForSeconds(0.1f);
        foreach(var lights in highBeams)
            lights.intensity =  0;
            }
        turnOnLights = true;
        yield return new WaitForSeconds(5f);
        easteregg.Play();
    }
}
