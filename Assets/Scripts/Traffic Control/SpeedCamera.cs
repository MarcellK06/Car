using UnityEngine

public class SpeedCamera : MonoBehaviour { 

    public Transform cameraModule;
    public float allowedSpeed;
    void FixedUpdate {
        RaycastHit hit;
        if (Physics.Raycast(cameraModule.position, cameraModule.forward, out hit, 30f)) {
            var car = hit.transform.gameObject.getComponent<SCC_Drivetrain>();
            if (car.speed <= allowedSpeed || !car)
                return;
            var player = hit.transform.gameObject.GetComponent<PlayerData>().economy;
            player.addMoney((car.speed - allowedSpeed) * 10);
        }
    }

}