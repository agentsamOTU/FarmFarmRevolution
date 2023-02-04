//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputActions/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player_Actions"",
            ""id"": ""1c26497f-d584-4c8e-ac09-a74a5becad03"",
            ""actions"": [
                {
                    ""name"": ""MovementAxis"",
                    ""type"": ""Value"",
                    ""id"": ""232cf3a5-bb7c-4316-bea5-5d7b9b058de5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PickupSeed"",
                    ""type"": ""Button"",
                    ""id"": ""8f36c3df-16d2-4625-b335-fa52b75c2500"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""895e49eb-4b67-460d-9052-27219a6eff42"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7c4808c9-17b3-4c1b-abae-84cf0737a864"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a5a2be0f-5d1a-4256-ba62-7590ab9c9db4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12148aff-f812-47ac-9bc3-5df151f9bdc1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""40589087-74d7-4ac1-9ff5-98747c6c00df"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51acf795-70fc-4315-8110-ae9e8a95bd75"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickupSeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_Actions
        m_Player_Actions = asset.FindActionMap("Player_Actions", throwIfNotFound: true);
        m_Player_Actions_MovementAxis = m_Player_Actions.FindAction("MovementAxis", throwIfNotFound: true);
        m_Player_Actions_PickupSeed = m_Player_Actions.FindAction("PickupSeed", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player_Actions
    private readonly InputActionMap m_Player_Actions;
    private IPlayer_ActionsActions m_Player_ActionsActionsCallbackInterface;
    private readonly InputAction m_Player_Actions_MovementAxis;
    private readonly InputAction m_Player_Actions_PickupSeed;
    public struct Player_ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public Player_ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementAxis => m_Wrapper.m_Player_Actions_MovementAxis;
        public InputAction @PickupSeed => m_Wrapper.m_Player_Actions_PickupSeed;
        public InputActionMap Get() { return m_Wrapper.m_Player_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_ActionsActions instance)
        {
            if (m_Wrapper.m_Player_ActionsActionsCallbackInterface != null)
            {
                @MovementAxis.started -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnMovementAxis;
                @MovementAxis.performed -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnMovementAxis;
                @MovementAxis.canceled -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnMovementAxis;
                @PickupSeed.started -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnPickupSeed;
                @PickupSeed.performed -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnPickupSeed;
                @PickupSeed.canceled -= m_Wrapper.m_Player_ActionsActionsCallbackInterface.OnPickupSeed;
            }
            m_Wrapper.m_Player_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementAxis.started += instance.OnMovementAxis;
                @MovementAxis.performed += instance.OnMovementAxis;
                @MovementAxis.canceled += instance.OnMovementAxis;
                @PickupSeed.started += instance.OnPickupSeed;
                @PickupSeed.performed += instance.OnPickupSeed;
                @PickupSeed.canceled += instance.OnPickupSeed;
            }
        }
    }
    public Player_ActionsActions @Player_Actions => new Player_ActionsActions(this);
    public interface IPlayer_ActionsActions
    {
        void OnMovementAxis(InputAction.CallbackContext context);
        void OnPickupSeed(InputAction.CallbackContext context);
    }
}