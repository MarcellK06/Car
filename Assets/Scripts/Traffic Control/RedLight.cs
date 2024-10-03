using UnityEngine;

public class RedLight : MonoBehaviour {

    public bool red;

    private void OnTriggerEnter(Collider obj) {
        var caughtObj = obj.gameObject
        var car = caughtObj.getComponent<SCC_Drivetrain>();
        
        if (!red || !car)
            return;

        
        var player = caughtObj.GetComponent<PlayerData>().economy;
        player.addMoney(25f);
    }
}