// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/ControlsNav.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlsNav : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlsNav()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlsNav"",
    ""maps"": [
        {
            ""name"": ""Nave"",
            ""id"": ""ec80f0f3-a5aa-4370-8b68-5fd554d777f6"",
            ""actions"": [
                {
                    ""name"": ""Movimiento"",
                    ""type"": ""Value"",
                    ""id"": ""00971895-613a-48f5-a21c-a7fa419db2fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c1651cff-cabe-4f88-8d01-96ce413f34fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""82fefc80-fd48-4cc0-8938-3bde1c98a725"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c13fc2fc-f52e-4caa-bdd7-1479b76bf2db"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ad3bcb51-6ca9-4dee-b020-9af6b2e8ce3e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6fe4051e-3991-4623-a3ef-af12cc98678c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c1c846d-1a76-4ed3-8e96-7c7359bd83fd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5c923d1c-d3c4-44f1-ae0f-3bafe9c7b710"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f4a05dca-188b-4a6d-8115-172ee2423a6f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0485825-c777-413d-bf1b-cb2ec806a16d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Nave
        m_Nave = asset.FindActionMap("Nave", throwIfNotFound: true);
        m_Nave_Movimiento = m_Nave.FindAction("Movimiento", throwIfNotFound: true);
        m_Nave_Attack = m_Nave.FindAction("Attack", throwIfNotFound: true);
        m_Nave_Pause = m_Nave.FindAction("Pause", throwIfNotFound: true);
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

    // Nave
    private readonly InputActionMap m_Nave;
    private INaveActions m_NaveActionsCallbackInterface;
    private readonly InputAction m_Nave_Movimiento;
    private readonly InputAction m_Nave_Attack;
    private readonly InputAction m_Nave_Pause;
    public struct NaveActions
    {
        private @ControlsNav m_Wrapper;
        public NaveActions(@ControlsNav wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimiento => m_Wrapper.m_Nave_Movimiento;
        public InputAction @Attack => m_Wrapper.m_Nave_Attack;
        public InputAction @Pause => m_Wrapper.m_Nave_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Nave; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NaveActions set) { return set.Get(); }
        public void SetCallbacks(INaveActions instance)
        {
            if (m_Wrapper.m_NaveActionsCallbackInterface != null)
            {
                @Movimiento.started -= m_Wrapper.m_NaveActionsCallbackInterface.OnMovimiento;
                @Movimiento.performed -= m_Wrapper.m_NaveActionsCallbackInterface.OnMovimiento;
                @Movimiento.canceled -= m_Wrapper.m_NaveActionsCallbackInterface.OnMovimiento;
                @Attack.started -= m_Wrapper.m_NaveActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_NaveActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_NaveActionsCallbackInterface.OnAttack;
                @Pause.started -= m_Wrapper.m_NaveActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_NaveActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_NaveActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_NaveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimiento.started += instance.OnMovimiento;
                @Movimiento.performed += instance.OnMovimiento;
                @Movimiento.canceled += instance.OnMovimiento;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public NaveActions @Nave => new NaveActions(this);
    public interface INaveActions
    {
        void OnMovimiento(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
