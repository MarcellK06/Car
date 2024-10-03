using UnityEngine;

public class RedLight : MonoBehaviour {

    public bool red;

    private void OnTriggerEnter(Collider obj) {
        var caughtObj = obj.gameObject;
        var car = caughtObj.GetComponent<SCC_Drivetrain>();
        
        if (!red || !car)
            return;

        
        var player = caughtObj.GetComponent<PlayerData>().economy;
        player.addbank(25f);
    }
}