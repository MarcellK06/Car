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
        foreach(var light in streetLights) {
            light.enabled = false;
        }
        foreach(var light in headLights_) {
            light.enabled = false;
        }
        foreach(var light in highBeams) {
            light.enabled = false;
        }
        foreach(var eyes in angelEyes) {
            eyes.SetActive(false);
        }

            StartCoroutine(lightAnimation());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (turnOnLights) {
        foreach(var light in highBeams)
            light.enabled = false;
        foreach(var light in streetLights)
            light.enabled = true;
        foreach(var light in headLights_)
            light.enabled = true;
        foreach(var eye in angelEyes)
            if(eye.GetComponent<Light>())
                eye.GetComponent<Light>().enabled = false;
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
        foreach(var light in highBeams)
            light.enabled = true;
        yield return new WaitForSeconds(0.1f);
        foreach(var light in highBeams)
            light.enabled = false;
            }
            yield return new WaitForSeconds(0.5f);
        turnOnLights = true;
        yield return new WaitForSeconds(5f);
        easteregg.Play();
    }
}
