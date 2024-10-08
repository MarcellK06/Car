using TMPro;
using UnityEngine;

public class PlayerEconomy : MonoBehaviour {

    public float bank = 0;
    public TMP_Text bankText;
    public void addbank(float amount) {
        bank += amount;
        bankText.text = $"{bank}$";
    }
    public void transaction(int amount, int type) {
        int wallet = 0;
        if (amount > (type == -1 ? bank : wallet))
            return;
        bank += amount * type;
        wallet += amount * type * -1;
    }

}