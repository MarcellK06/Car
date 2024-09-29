using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public MonoBehaviour CarController;
    public Transform Car;
    public Transform Player;

    [Header("Cameras")]
    public GameObject PlayerCam;
    public GameObject CarCam;

    public GameObject DriveUI;

    bool CanDrive;
    bool driving;

    // Start is called before the first frame update
    void Start()
    {
        CarController.enabled=false;
        DriveUI.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.F) && CanDrive && !driving)
        {
            
            CarController.enabled=true;
            DriveUI.gameObject.SetActive(false);
            driving=true;
            Player.transform.SetParent(Car);
            Player.gameObject.SetActive(false);
            //Kamera
            PlayerCam.gameObject.SetActive(false);
            CarCam.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F) && driving && !CanDrive)
        {
            driving=false;
            CarController.enabled=false;
            Player.transform.SetParent(null);
            Player.gameObject.SetActive(true);

            //Kamera
            PlayerCam.gameObject.SetActive(true);
            CarCam.gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {

            DriveUI.gameObject.SetActive(true);
            CanDrive=true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
            DriveUI.gameObject.SetActive(false);
            CanDrive=false;
        }
    }
}
