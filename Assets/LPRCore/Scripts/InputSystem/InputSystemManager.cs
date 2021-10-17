// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/InputSystemManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemManager"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""7d69ed83-289d-445f-a0c7-dbb052ef3cc0"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""f125797b-7cab-4333-b716-788d2bc81823"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""3f0ce690-6cba-4e38-a15a-e214838fbeeb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpGear"",
                    ""type"": ""Button"",
                    ""id"": ""aad246cb-f8cc-4054-a9ae-b828c2900656"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DownGear"",
                    ""type"": ""Button"",
                    ""id"": ""5ad63ae0-c4df-4541-8d5d-43ef962a757f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""3b022221-5dd2-403b-9693-bd349693181e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""0043e833-f849-4dc8-821b-d67cdb9f9808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07d9186b-2ba5-4532-8d7a-3b0c2d50f2cf"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cde0c2b9-4cf0-40f9-9b42-96f316f8b25b"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be04bc13-dfb9-4427-81a5-22a56b669184"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""UpGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3901d7ef-fef3-43fc-8227-e5ff237cd186"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""DownGear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18ab855b-a26d-4ee2-9d71-997337d58a14"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be13d93-464d-4e0a-aa80-ed7b54e60b38"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PcXboxAndroid"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PcXboxAndroid"",
            ""bindingGroup"": ""PcXboxAndroid"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Acceleration = m_Player.FindAction("Acceleration", throwIfNotFound: true);
        m_Player_Turning = m_Player.FindAction("Turning", throwIfNotFound: true);
        m_Player_UpGear = m_Player.FindAction("UpGear", throwIfNotFound: true);
        m_Player_DownGear = m_Player.FindAction("DownGear", throwIfNotFound: true);
        m_Player_Brake = m_Player.FindAction("Brake", throwIfNotFound: true);
        m_Player_HandBrake = m_Player.FindAction("HandBrake", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Acceleration;
    private readonly InputAction m_Player_Turning;
    private readonly InputAction m_Player_UpGear;
    private readonly InputAction m_Player_DownGear;
    private readonly InputAction m_Player_Brake;
    private readonly InputAction m_Player_HandBrake;
    public struct PlayerActions
    {
        private @InputSystemManager m_Wrapper;
        public PlayerActions(@InputSystemManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Acceleration => m_Wrapper.m_Player_Acceleration;
        public InputAction @Turning => m_Wrapper.m_Player_Turning;
        public InputAction @UpGear => m_Wrapper.m_Player_UpGear;
        public InputAction @DownGear => m_Wrapper.m_Player_DownGear;
        public InputAction @Brake => m_Wrapper.m_Player_Brake;
        public InputAction @HandBrake => m_Wrapper.m_Player_HandBrake;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Acceleration.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                @Turning.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
                @UpGear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpGear;
                @UpGear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpGear;
                @UpGear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpGear;
                @DownGear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownGear;
                @DownGear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownGear;
                @DownGear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownGear;
                @Brake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                @HandBrake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandBrake;
                @HandBrake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandBrake;
                @HandBrake.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandBrake;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
                @UpGear.started += instance.OnUpGear;
                @UpGear.performed += instance.OnUpGear;
                @UpGear.canceled += instance.OnUpGear;
                @DownGear.started += instance.OnDownGear;
                @DownGear.performed += instance.OnDownGear;
                @DownGear.canceled += instance.OnDownGear;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @HandBrake.started += instance.OnHandBrake;
                @HandBrake.performed += instance.OnHandBrake;
                @HandBrake.canceled += instance.OnHandBrake;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_PcXboxAndroidSchemeIndex = -1;
    public InputControlScheme PcXboxAndroidScheme
    {
        get
        {
            if (m_PcXboxAndroidSchemeIndex == -1) m_PcXboxAndroidSchemeIndex = asset.FindControlSchemeIndex("PcXboxAndroid");
            return asset.controlSchemes[m_PcXboxAndroidSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAcceleration(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
        void OnUpGear(InputAction.CallbackContext context);
        void OnDownGear(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnHandBrake(InputAction.CallbackContext context);
    }
}
