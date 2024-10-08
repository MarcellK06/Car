using System.Collections;
using UnityEngine;

public class SpeedCamera : MonoBehaviour { 

    public Transform cameraModule;
    public float allowedSpeed;
    RaycastHit hit;
    public bool active = true;
    public float cooldown;
    void Update() {
        if (Physics.Raycast(cameraModule.position, cameraModule.forward, out hit, 30f)) {

            var car = hit.transform.GetComponent<SCC_Drivetrain>();
            Debug.Log($"{car} {hit.transform}");
            if (car.speed <= allowedSpeed || !car || !active)
                return;
            var player = hit.transform.GetComponent<PlayerData>().economy;
            player.addbank(Mathf.Round((car.speed - allowedSpeed) * 8));
            Debug.Log(player.bank);
            StartCoroutine(setActive());
        }
    }

    public IEnumerator setActive() {
        active = false;
        yield return new WaitForSeconds(cooldown);
        active = true;
    }
}