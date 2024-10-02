//----------------------------------------------
//            Simple Car Controller
//
// Copyright © 2014 - 2023 BoneCracker Games
// http://www.bonecrackergames.com
//
//----------------------------------------------

using UnityEngine;
using System.Collections;

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

    //  Audioclips.
    public Dictionary<string, AudioClip> audios = new Dictionary<string, AudioClip>();

    //  Audiosources.
    private AudioSource engineSource;

    //  Volume values for min and max volume.
    public float minimumVolume = .1f;
    public float maximumVolume = 1f;

    //  Pitch values for min and max pitch.
    public float minimumPitch = .75f;
    public float maximumPitch = 1.25f;

    private void Start() {

        GameObject engineSource = new GameObject("Engine AudioSource");
        engine.transform.SetParent(transform, false);
        engineSource = engineSource.AddComponent<AudioSource>();
        engineSource.clip = audios["engineOn"];
        engineSource.loop = true;
        engineSource.spatialBlend = 1f;
        engineSource.Play();
    }

    private void Update() {

        //  If there is no drivetrain attached to the vehicle or input processor, return and disable this component.
        if (!Drivetrain || !InputProcessor) {

            enabled = false;
            return;

        }

        //  Calculating the target volume depends on the throttle / brake.
        float volume = Drivetrain.direction == 1 ? InputProcessor.inputs.throttleInput : InputProcessor.inputs.brakeInput;

        //  Setting volumes.
        engineSource.volume = Mathf.Lerp(minimumVolume, maximumVolume, volume);

        //  Setting pitches.
        engineSource.pitch = Mathf.Lerp(minimumPitch, maximumPitch, Drivetrain.currentEngineRPM / Drivetrain.maximumEngineRPM);

    }

}
