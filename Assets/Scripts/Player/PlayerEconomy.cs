using UnityEngine;

public class PlayerEconomy : MonoBehaviour {

    public int wallet = 0;
    public int bank = 0;
    public void addwallet(amount) {
        bank += amount;
    }
    public void transaction(amount, type) {
        if (amount > type == -1 ? bank : wallet)
            return;
        bank += amount * type;
        wallet += amount * type * -1;
    }

}