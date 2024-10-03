using UnityEngine;

public class SpeedCamera : MonoBehaviour { 

    public Transform cameraModule;
    public float allowedSpeed;
    RaycastHit hit;
    RaycastHit lasthit = new RaycastHit();
    void Update() {
        if (Physics.Raycast(cameraModule.position, cameraModule.forward, out hit, 30f)) {

            var car = hit.transform.GetComponent<SCC_Drivetrain>();
            if (car.speed <= allowedSpeed || !car || hit.transform == lasthit.transform)
                return;
            var player = hit.transform.GetComponent<PlayerData>().economy;
            player.addbank((car.speed - allowedSpeed) * 10);
            lasthit = hit;
        } else
            lasthit = new RaycastHit();
    }
}