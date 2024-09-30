//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/SCC_InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @SCC_InputActions : IInputActionCollection2, IDisposable {
    public InputActionAsset asset { get; }
    public @SCC_InputActions() {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SCC_InputActions"",
    ""maps"": [
        {
            ""name"": ""Vehicle"",
            ""id"": ""dab82b1c-787e-4a36-b968-b40e68121a11"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""90dd0b16-b17c-4e2f-816d-3f6f472fbe4d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""fd45c78a-8d28-433b-938d-216a05e39978"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""07554ee5-17d2-4f02-a18b-c167de4685b5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""862a1da3-327a-425f-bc3a-c144667b0f07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""arrows"",
                    ""id"": ""f11f01e4-cf2c-47ed-ab18-9f957fe8913a"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e0cd1536-dbc9-4a1c-85e1-a1a092c6d2dc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1ba4f3e-7db4-494b-94a9-609e76725d20"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""3fdb6416-2def-4c85-8aaa-8bc786eee672"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""20f6ae90-cf5c-4fdf-a3b2-156ecb775171"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f637e88-9cd0-42a6-93cf-ce55b89ff212"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""34d118d2-ab65-4ccd-bb89-78a9a042d4de"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""af0c3935-4ef0-4f3b-8a8d-13853137f6db"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e323a5f2-36c3-459c-813e-d6bbb9e3bac7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""G29/920"",
                    ""id"": ""917fc2f9-b027-48ea-a670-9f4f3cb137af"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""be73745b-397e-4185-9283-ea2f38bf4f84"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""24631aa9-3d4f-4a4c-9348-c76dc524a7bf"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b7f469da-1f0b-4649-a1d2-d5c6795d48b5"",
                    ""path"": ""<OculusTouchController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""719ca6b9-d323-4341-8e55-caa156a602e8"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4d2b585c-6f0c-4907-8009-b23e2a8bfce1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ebd5b62c-f128-414b-8280-7decced19010"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""3d7e56ad-b8c0-434a-8415-72fa857776ac"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bab83804-84b2-4e39-9fc1-9bb9787d2a60"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3db07aa2-78b1-4e62-869e-5540b1d2ea11"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5aaefde0-b9f2-4263-ada8-08c4754560fc"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cbd8e1e-8b86-4741-8cb2-876fb108b2a3"",
                    ""path"": ""<OculusTouchController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""a135f3bc-f45c-479f-ad28-b4581890cd28"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b1647269-c5f0-41dc-b651-b4e2f87d8fdb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f7d779b9-21fe-4e3d-9744-a94e504b04fc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""c8307ec0-22ef-43bb-8351-b6aef882fa5f"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b17286eb-c31a-424d-97bc-ffc8ee35b47a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ee6ed4f-8f71-47d6-af83-3d0b1e20860c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""885ad1e3-b856-4be1-a7cb-32bb8bfb2b88"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6a9790aa-c6f0-48b7-b93c-c2d033442261"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""69462041-e882-40fd-bed8-deff21837f89"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aaf2efcb-4c14-4b5f-8669-de517f4ad583"",
                    ""path"": ""<OculusTouchController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""G29/920"",
                    ""id"": ""ea42dd76-8279-4357-8568-5591d76a5189"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c803aabc-d4e4-43bd-8c6f-ada81a3a4ce8"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""G920"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""b84118c6-f280-4827-aec2-23b358ff2839"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""e39a68f9-d10f-4dfb-9c23-4911299ada81"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""95b1dcb4-e179-495b-9829-2441e822fa9c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""c9265635-9301-4f28-857f-f8c35c3aeaa3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0efc1b5a-a2af-4412-9c79-657c31d182ad"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""f8373c7a-eb6c-4d91-afe6-1f8f9db75611"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""c33597ed-2d60-4495-acd6-1898c0c03435"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""2605240c-dc7a-4c85-a40f-3976962910e4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""dfa77fc0-a4e7-4963-ba95-c84d55d9166b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a72b71b3-a5a9-476e-ba2f-303039d7d7f9"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/x"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": ""G920"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f884a2c-fc71-409f-85a6-58868973caca"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""9833443b-7a36-43d9-b723-68beac1a943a"",
            ""actions"": [
                {
                    ""name"": ""Orbit"",
                    ""type"": ""Value"",
                    ""id"": ""36c3b66b-e716-43bf-8b0f-d41f0459994b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10705ed5-34a8-40b6-afab-e3723c412fd4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.25,y=0.25)"",
                    ""groups"": ""Keyboard Mouse"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""gamepads"",
                    ""id"": ""adf39205-15ba-43f3-9a61-30694bdff208"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e88670fd-67e0-46a4-93ff-edfecf9d387a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bed807c8-3819-4858-bbef-fc3a524d09fe"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ca2a81c-e237-4897-90c2-2430527a1da7"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""858ac0f9-c985-4d92-a793-44c779f559ab"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a8ebc1cc-3aa1-4d4b-88d3-f03fd85805ef"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Oculus Quest"",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard Mouse"",
            ""bindingGroup"": ""Keyboard Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""G920"",
            ""bindingGroup"": ""G920"",
            ""devices"": []
        },
        {
            ""name"": ""Oculus Quest"",
            ""bindingGroup"": ""Oculus Quest"",
            ""devices"": []
        }
    ]
}");
        // Vehicle
        m_Vehicle = asset.FindActionMap("Vehicle", throwIfNotFound: true);
        m_Vehicle_Throttle = m_Vehicle.FindAction("Throttle", throwIfNotFound: true);
        m_Vehicle_Brake = m_Vehicle.FindAction("Brake", throwIfNotFound: true);
        m_Vehicle_Steering = m_Vehicle.FindAction("Steering", throwIfNotFound: true);
        m_Vehicle_Handbrake = m_Vehicle.FindAction("Handbrake", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Orbit = m_Camera.FindAction("Orbit", throwIfNotFound: true);
    }

    public void Dispose() {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action) {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator() {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public void Enable() {
        asset.Enable();
    }

    public void Disable() {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action) {
        return asset.FindBinding(bindingMask, out action);
    }

    // Vehicle
    private readonly InputActionMap m_Vehicle;
    private IVehicleActions m_VehicleActionsCallbackInterface;
    private readonly InputAction m_Vehicle_Throttle;
    private readonly InputAction m_Vehicle_Brake;
    private readonly InputAction m_Vehicle_Steering;
    private readonly InputAction m_Vehicle_Handbrake;
    public struct VehicleActions {
        private @SCC_InputActions m_Wrapper;
        public VehicleActions(@SCC_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_Vehicle_Throttle;
        public InputAction @Brake => m_Wrapper.m_Vehicle_Brake;
        public InputAction @Steering => m_Wrapper.m_Vehicle_Steering;
        public InputAction @Handbrake => m_Wrapper.m_Vehicle_Handbrake;
        public InputActionMap Get() { return m_Wrapper.m_Vehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleActions instance) {
            if (m_Wrapper.m_VehicleActionsCallbackInterface != null) {
                @Throttle.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnThrottle;
                @Brake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Steering.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnSteering;
                @Handbrake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnHandbrake;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null) {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
            }
        }
    }
    public VehicleActions @Vehicle => new VehicleActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Orbit;
    public struct CameraActions {
        private @SCC_InputActions m_Wrapper;
        public CameraActions(@SCC_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Orbit => m_Wrapper.m_Camera_Orbit;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance) {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null) {
                @Orbit.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
                @Orbit.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
                @Orbit.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnOrbit;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null) {
                @Orbit.started += instance.OnOrbit;
                @Orbit.performed += instance.OnOrbit;
                @Orbit.canceled += instance.OnOrbit;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme {
        get {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme {
        get {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_G920SchemeIndex = -1;
    public InputControlScheme G920Scheme {
        get {
            if (m_G920SchemeIndex == -1) m_G920SchemeIndex = asset.FindControlSchemeIndex("G920");
            return asset.controlSchemes[m_G920SchemeIndex];
        }
    }
    private int m_OculusQuestSchemeIndex = -1;
    public InputControlScheme OculusQuestScheme {
        get {
            if (m_OculusQuestSchemeIndex == -1) m_OculusQuestSchemeIndex = asset.FindControlSchemeIndex("Oculus Quest");
            return asset.controlSchemes[m_OculusQuestSchemeIndex];
        }
    }
    public interface IVehicleActions {
        void OnThrottle(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
    }
    public interface ICameraActions {
        void OnOrbit(InputAction.CallbackContext context);
    }
}
