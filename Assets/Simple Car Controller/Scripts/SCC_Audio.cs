//----------------------------------------------
//            Simple Car Controller
//
// Copyright © 2014 - 2023 BoneCracker Games
// http://www.bonecrackergames.com
//
//----------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Handles engine audio based on vehicle engine rpm and speed.
/// </summary>
[AddComponentMenu("BoneCracker Games/Simple Car Controller/SCC Audio")]
public class SCC_Audio : MonoBehaviour {

    //  Drivetrain.
    private SCC_Drivetrain drivetrain;
    public SCC_Drivetrain Drivetrain {

        get {

            if (drivetrain == null)
                drivetrain = GetComponent<SCC_Drivetrain>();

            return drivetrain;

        }

    }

    //  Input processor.
    private SCC_InputProcessor inputProcessor;
    public SCC_InputProcessor InputProcessor {

        get {

            if (inputProcessor == null)
                inputProcessor = GetComponent<SCC_InputProcessor>();

            return inputProcessor;

        }

    }

    //  Audiosources.
    public AudioSource engineStart;
    public AudioSource engineIdle;
    public AudioSource engineRunning;
    public AudioSource engineLimiter;
    public AudioSource engineOff;

    //  Volume values for min and max volume.
    public float minimumVolume = .1f;
    public float maximumVolume = 1f;

    //  Pitch values for min and max pitch.
    public float minimumPitch = .75f * 3.5f;
    public float maximumPitch = 1.25f * 3.5f;

    private void Start() {
        engineIdle.volume = 0;
        engineRunning.volume = 0;
    }

    private void Update() {

        if (!Drivetrain || !InputProcessor) {

            enabled = false;
            return;

        }
        if (drivetrain.speed == 0)
        engineIdle.volume = Mathf.Lerp(0.1f, 1f, drivetrain.speed);
        if(drivetrain.speed > 0) {
            engineIdle.volume = Mathf.Lerp(1f, 0f, drivetrain.speed);
            engineRunning.volume = Mathf.Lerp(0.2f, 1f, drivetrain.speed);
            engineRunning.pitch = Mathf.Lerp(engineRunning.pitch, 2f * drivetrain.currentEngineRPM/drivetrain.maximumEngineRPM, Time.deltaTime);
        }

    }

}
