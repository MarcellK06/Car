using UnityEngine;
using UnityEngine.UI;

public class Tune : MonoBehaviour {

    private Dictionary<int, float> boosts = new Dictionary<int, float> {
        {0, 1}, {1, 1.1}, {2, 1.5}, {3, 1.75}
    };

    [SerializeField]
    private Canvas workshopUI;
    [SerializeField]
    private int selectedEngine, selectedTurbo, selectedBrakes, selectedTint, selectedDrivetrain;
    private SCC_Drivetrain comp;

    void OnTriggerEnter(Collider obj) {
        var v_obj = obj.gameObject;
        var component = v_obj.getComponent<SCC_Drivetrain>();
        if (component == null)
            return;
        comp = component;
        enterWorkshop(v_obj);
    }

    void enterWorkshop() {
        workshopUI.enabled = true;
    }

    void makeChanges() {
        comp.engineTorque = comp.baseEngineTorque * boosts[selectedEngine];
        comp.brakeTorque = comp.baseBrakeTorque * boosts[selectedBrakes];
        comp.turboExtra = comp.baseTurboExtra * boosts[selectedTurbo];
        switch(selectedDrivetrain) {
            case 0: //FWD
            comp.wheels[0].isTraction = true;
            comp.wheels[1].isTraction = true;
            comp.wheels[2].isTraction = false;
            comp.wheels[3].isTraction = false;
            break;
            case 1: //RWD
            comp.wheels[0].isTraction = false;
            comp.wheels[1].isTraction = false;
            comp.wheels[2].isTraction = true;
            comp.wheels[3].isTraction = true;
            break;
            case 2: //AWD
            comp.wheels[0].isTraction = true;
            comp.wheels[1].isTraction = true;
            comp.wheels[2].isTraction = true;
            comp.wheels[3].isTraction = true;
            break;
        }
        
    }

    void leaveWorkshop() {
        makeChanges();
        workshopUI.enabled = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.F) && comp.engineTorque != 0)
            leaveWorkshop();
    }

}