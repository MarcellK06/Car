﻿//----------------------------------------------
//            Simple Car Controller
//
// Copyright © 2014 - 2023 BoneCracker Games
// http://www.bonecrackergames.com
//
//----------------------------------------------

using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

/// <summary>
/// Handling drivetrain, which is most important part of the car controller. 
/// </summary>
[AddComponentMenu("BoneCracker Games/Simple Car Controller/SCC Drivetrain")]
[RequireComponent(typeof(Rigidbody))]
public class SCC_Drivetrain : MonoBehaviour {

    //  Rigidbody.
    private Rigidbody rigid;
    private Rigidbody Rigid {

        get {

            if (rigid == null)
                rigid = GetComponent<Rigidbody>();

            return rigid;

        }

    }

    //  All wheels.
    public SCC_Wheels[] wheels;

    [System.Serializable]
    public class SCC_Wheels {

        public Transform wheelTransform;
        public SCC_Wheel wheelCollider;

        public bool isSteering = false;
        [Range(-45f, 45f)] public float steeringAngle = 25f;
        public bool isTraction = false;
        public bool isBrake = false;
        public bool isHandbrake = false;

    }

    //  Input processor.
    private SCC_InputProcessor inputProcessor;
    private SCC_InputProcessor InputProcessor {

        get {

            if (inputProcessor == null)
                inputProcessor = GetComponent<SCC_InputProcessor>();

            return inputProcessor;

        }

    }

    public Transform COM;       //  Center of mass.
    public float speed = 0f;        //  Current speed.

    public float currentEngineRPM = 0f;     //  Current engine rpm.
    public float minimumEngineRPM = 650f;       //  Minimum engine rpm.
    public float maximumEngineRPM = 7000f;      //  Maximum engine rpm.

    public float engineTorque = 1000f;      //  Maximum engine torque.
    public float baseEngineTorque;
    public float brakeTorque = 1000f;       //  Maximum brake torque.
    public float baseBrakeTorque;
    public float maximumSpeed = 100f;       //  Maximum speed.
    
    public float turboExtra = 0f;
    public float baseTurboExtra;
    public float turboState = 0f;

    public float[] gearRatios;
    public int currentGear = 0;
    public float[] maximumSpeedPerGear;
    public int engineTune, brakeTune, turboTune, drivetrain;

    public int direction = 1;       //  Direction. 1 = forward -1 = reverse.

    public float highSpeedSteerAngle = 100f;        //  Vehicle will apply minimal steer angle at this speed.

    private float timerForReverse = 0f;     //  Detecting reverse gear.
    public bool appliedBrake = false;
        public bool on = false;

    private void Update() {
        if (Input.GetButtonDown("EO"))
            on = !on;
        if (on) {
        Engine();
        ApplySteering();
        ApplyTraction();
        ApplyBrake();
        ApplyHandBrake();
        ChangeGear();
        Others();
        }
    }
    private void Start() {
        baseEngineTorque = engineTorque;
        baseBrakeTorque = brakeTorque;
        baseTurboExtra = turboExtra;
    }

    /// <summary>
    /// Engine.
    /// </summary>
    private void Engine() {

        maximumSpeed = maximumSpeedPerGear[currentGear];

        turboState = currentEngineRPM > 3000 ? currentEngineRPM / maximumEngineRPM * turboExtra : 0;
        //  Getting average rpm of the traction wheels for calculating the engine rpm.
        float averageTractionRPM = 0f;
        int totalTractionWheels = 0;

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isTraction) {
                averageTractionRPM += Mathf.Abs(wheels[i].wheelCollider.wheelRPMToSpeed);

            totalTractionWheels++;
            }

        }

        //  Engine rpm is related to rpms of the traction wheels. Setting current engine rpm to this value smoothly.
        currentEngineRPM = Mathf.Lerp(minimumEngineRPM, maximumEngineRPM, averageTractionRPM / totalTractionWheels / maximumSpeed);

    }

    public void ChangeGear() {
        if (Input.GetButtonDown("GU") && currentGear < gearRatios.Length-1)
            currentGear += 1;
        if (Input.GetButtonDown("GD") && currentGear > 0)
            currentGear -= 1;
    }

    /// <summary>
    /// Applies steering to the steering wheels..
    /// </summary>
    private void ApplySteering() {

        //  Getting all steerable wheels and set their steering angles related to player's input.
        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isSteering)
                wheels[i].wheelCollider.WheelCollider.steerAngle = (wheels[i].steeringAngle * InputProcessor.inputs.steerInput) * Mathf.Lerp(1f, .25f, speed / highSpeedSteerAngle);
            else
                wheels[i].wheelCollider.WheelCollider.steerAngle = 0f;

        }

    }

    /// <summary>
    /// Applies traction to the traction wheels.
    /// </summary>
    private void ApplyTraction() {

        //  Getting total number of the traction wheels for calculating torque per wheel. And then appyling to all wheelcolliders equally.
        int totalTractionWheels = 0;

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isTraction)
                totalTractionWheels++;

        }

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isTraction)
                wheels[i].wheelCollider.WheelCollider.motorTorque = (inputProcessor.inputs.throttleInput == 0 && inputProcessor.inputs.brakeInput == 0 && (speed > 1 || speed < -1 )) ? (engineTorque * gearRatios[currentGear]/4 * -direction) : (((engineTorque + turboState) * gearRatios[currentGear]) * (direction == 1 ? InputProcessor.inputs.throttleInput : -InputProcessor.inputs.brakeInput)) / Mathf.Clamp(totalTractionWheels, 1, 20);
            else
                wheels[i].wheelCollider.WheelCollider.motorTorque = 0f;

            if ((speed >= maximumSpeed || wheels[i].wheelCollider.wheelRPMToSpeed >= maximumSpeed) && wheels[i].isTraction)
                wheels[i].wheelCollider.WheelCollider.motorTorque = 0f;

        }

    }

    /// <summary>
    /// Applies brake torque to the brake wheels.
    /// </summary>
    private void ApplyBrake() {

        //  Getting total number of the brake wheels for calculating torque per wheel. And then appyling to all wheelcolliders equally.
        appliedBrake = false;
        int totalBrakeWheels = 0;

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isBrake)
                totalBrakeWheels++;

        }

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isBrake) {

                wheels[i].wheelCollider.WheelCollider.brakeTorque = brakeTorque * (direction == 1 ? InputProcessor.inputs.brakeInput : InputProcessor.inputs.throttleInput) / Mathf.Clamp(totalBrakeWheels, 1, 20);

                if (wheels[i].wheelCollider.WheelCollider.brakeTorque >= 5f)
                    appliedBrake = true;

            } else {

                wheels[i].wheelCollider.WheelCollider.brakeTorque = 0f;

            }

        }

    }

    /// <summary>
    /// Applying handbrake torque to the handbrake wheels.
    /// </summary>
    private void ApplyHandBrake() {

        //  If brake is applied before, return. This means player is applying brake to the wheels before handbrake.
        if (appliedBrake)
            return;

        //  Getting total number of the handbrake wheels for calculating torque per wheel. And then appyling to all wheelcolliders equally.
        int totalBrakeWheels = 0;

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isHandbrake)
                totalBrakeWheels++;

        }

        for (int i = 0; i < wheels.Length; i++) {

            if (wheels[i].isHandbrake) {

                wheels[i].wheelCollider.WheelCollider.brakeTorque = brakeTorque * InputProcessor.inputs.handbrakeInput / totalBrakeWheels;

            } else {

                wheels[i].wheelCollider.WheelCollider.brakeTorque = 0f;

            }

        }

    }

    /// <summary>
    /// Other calculations and variables.
    /// </summary>
    private void Others() {

        Rigid.centerOfMass = COM.localPosition;     //  Setting center of mass of the rigidbody.
        speed = Rigid.velocity.magnitude * 3.6f;        //  Speed of the vehicle.

        //  If speed is below 5, and player is still pressing brake, increase timerForReverse value. If this value exceeds the limit, set direction to -1 for reverse gear.
        if (speed <= 5f && InputProcessor.inputs.brakeInput >= .75f)
            timerForReverse += Time.deltaTime;
        else if (speed <= 5f && InputProcessor.inputs.brakeInput <= .25f)
            timerForReverse = 0f;

        if (timerForReverse >= .1f)
            direction = -1;
        else
            direction = 1;

    }

    private void Reset() {

        if (!GetComponent<Rigidbody>())
            gameObject.AddComponent<Rigidbody>();

        if (!GetComponent<SCC_InputProcessor>())
            gameObject.AddComponent<SCC_InputProcessor>();

        if (!GetComponent<SCC_Audio>())
            gameObject.AddComponent<SCC_Audio>();

        if (!GetComponent<SCC_Particles>())
            gameObject.AddComponent<SCC_Particles>();

        if (!GetComponent<SCC_AntiRoll>())
            gameObject.AddComponent<SCC_AntiRoll>();

        if (!GetComponent<SCC_RigidStabilizer>())
            gameObject.AddComponent<SCC_RigidStabilizer>();

        gameObject.GetComponent<Rigidbody>().mass = 1350f;
        gameObject.GetComponent<Rigidbody>().drag = .01f;
        gameObject.GetComponent<Rigidbody>().angularDrag = .5f;
        gameObject.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
        gameObject.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;

        GameObject NewCOM = new GameObject("COM");
        NewCOM.transform.SetParent(transform, false);
        NewCOM.transform.localPosition = new Vector3(0f, -.2f, 0f);
        COM = NewCOM.transform;

    }

}
