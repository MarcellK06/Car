using System.Collections;
using UnityEngine;

public class RedLight : MonoBehaviour {

    public bool red, active;
    public float cooldown;

    private void OnTriggerEnter(Collider obj) {
        var caughtObj = obj.gameObject;
        var car = caughtObj.GetComponent<SCC_Drivetrain>();
        
        if (!red || !car || !active)
            return;

        
        var player = caughtObj.GetComponent<PlayerData>().economy;
        player.addbank(25f);
        Debug.Log(player.bank);
    }
    public IEnumerator setActive() {
        active = false;
        yield return new WaitForSeconds(cooldown);
        active = true;
    }
}