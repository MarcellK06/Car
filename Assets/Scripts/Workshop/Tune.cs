using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Tune : MonoBehaviour {
    private Dictionary<int, float> boosts = new Dictionary<int, float> {
        {0, 1f}, {1, 1.1f}, {2, 1.5f}, {3, 1.75f}
    };
    private Dictionary<int, int> prices = new Dictionary<int, int> {
        {0, 0}, {1, 2500}, {2, 3500}
    };
    [SerializeField]
    private GameObject workshopUI, SCCanvas;
    [SerializeField]
    private Slider engineSlider, turboSlider, brakeSlider, drivetrainSlider;
    [SerializeField]
    private TMP_Text costText;
    [SerializeField]
    private GameObject enterButton, leaveButton;
    [SerializeField]
    private Button applyButton;
    [SerializeField]
    private int selectedEngine, selectedTurbo, selectedBrakes, selectedTint, selectedDrivetrain;
    private SCC_Drivetrain comp;
    private PlayerData data;
    private bool inZone = false;

    void OnTriggerEnter(Collider obj) {
        var v_obj = obj.gameObject;
        var component = v_obj.GetComponent<SCC_Drivetrain>();
        var component2 = v_obj.GetComponent<PlayerData>();
        if (component == null)
            return;
        comp = component;
        data = component2;
        enterButton.SetActive(true);
        inZone = true;
    }
    void OnTriggerExit(Collider obj) {
        enterButton.SetActive(false);
        inZone = false;
    }

    void enterWorkshop() {
        workshopUI.SetActive(true);
        leaveButton.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        SCCanvas.SetActive(false);
    }

    void makeChanges() {
        var n = int.Parse(costText.text.Replace("$", ""));
        if (!(data.economy.bank >= n))
            return;
        data.economy.bank -= n;
        comp.engineTorque = comp.baseEngineTorque * boosts[selectedEngine];
        comp.brakeTorque = comp.baseBrakeTorque * boosts[selectedBrakes];
        comp.turboExtra = comp.baseTurboExtra * boosts[selectedTurbo];
        comp.engineTune = selectedEngine;
        comp.brakeTune = selectedBrakes;
        comp.turboTune = selectedTurbo;
        comp.drivetrain = selectedDrivetrain;
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
        workshopUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        SCCanvas.SetActive(true);
    }

    void Update() {
        if (!comp)
        return;
        if (Input.GetKeyDown(KeyCode.T) && comp.engineTorque != 0 && !workshopUI.active && inZone) {
            enterWorkshop();
            return;
        }
        selectedEngine = (int)engineSlider.value-1;
        selectedBrakes = (int)brakeSlider.value-1;
        selectedTurbo = (int)turboSlider.value-1;
        selectedDrivetrain = (int)drivetrainSlider.value-1;
        costText.text = $"{prices[selectedEngine] + prices[selectedBrakes] + prices[selectedTurbo] + prices[selectedDrivetrain]}$";
        if (Input.GetKeyDown(KeyCode.T) && comp.engineTorque != 0 && workshopUI.active)
            leaveWorkshop();
    }
    void Start() {
        workshopUI.SetActive(false);
        enterButton.SetActive(false);
        leaveButton.SetActive(false);
        applyButton.onClick.AddListener(makeChanges);
    }

}