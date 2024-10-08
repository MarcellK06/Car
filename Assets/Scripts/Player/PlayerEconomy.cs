using UnityEngine;

public class PlayerEconomy : MonoBehaviour {

    public float wallet = 0;
    public float bank = 0;
    public void addbank(float amount) {
        bank += amount;
    }
    public void transaction(int amount, int type) {
        if (amount > (type == -1 ? bank : wallet))
            return;
        bank += amount * type;
        wallet += amount * type * -1;
    }

}