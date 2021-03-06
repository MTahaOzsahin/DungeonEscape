//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameFolder/Scripts/Concrates/Controllers/InputsControllers.inputactions
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

namespace DungeonEscape.Concrates.Controllers
{
    public partial class @InputsControllers : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputsControllers()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputsControllers"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""ec2de38d-1cc1-4cb6-853d-f958d0124b5a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""93cdfff6-8a1e-4415-ac9c-e72f68d05303"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e0dc0732-a622-4163-a4dd-1a9e38c452de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DoubleJump"",
                    ""type"": ""Button"",
                    ""id"": ""b4dbc037-3763-47c5-b626-c267faa2c9d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Value"",
                    ""id"": ""3ad343d9-f2ee-4f77-a87d-287013c820bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PowerAttack"",
                    ""type"": ""Value"",
                    ""id"": ""349e3584-90ed-4940-a77b-ad8c9b1dfa3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ae284012-f243-44ad-9c3b-d22b421080c0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""59a20726-12b9-4691-8972-da15ad38d0dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""52e9ac95-5c44-4441-a3da-1dd2ce054ea8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""bf6f5b5d-3362-485e-9d99-56914ed77f02"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""990e7dd1-f37e-4314-8239-0c5605e71c14"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""85edc545-a18c-428a-923c-f8c744353622"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""JoyStick"",
                    ""id"": ""616b7f2a-5b86-4ee3-9101-2f82d6e37f0c"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d76195da-ab40-45ff-873e-47f3938911dc"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad675e8d-84d3-434c-9072-2bcbdb2deeb1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2cdac270-b666-430f-ba8c-5bfd909c4380"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec040b33-be92-48fd-8824-01db8d20f0fc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81ca08b8-be71-49c1-96eb-727230bf9acc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""DoubleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aea2bb62-a690-4c1f-8469-95ea0a014a79"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""DoubleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac7a0eee-b9dd-471e-82ea-2d1c0c6fa385"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2ee3fe6-f68b-443c-b616-63f572897961"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6986dacd-a755-430c-aa65-a9cd8d635141"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Hold(pressPoint=1.401298E-45)"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""PowerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bdb04cb-4255-41f6-980b-fa500eeb203e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""PowerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard"",
            ""bindingGroup"": ""KeyBoard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Land
            m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
            m_Land_Movement = m_Land.FindAction("Movement", throwIfNotFound: true);
            m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
            m_Land_DoubleJump = m_Land.FindAction("DoubleJump", throwIfNotFound: true);
            m_Land_Attack = m_Land.FindAction("Attack", throwIfNotFound: true);
            m_Land_PowerAttack = m_Land.FindAction("PowerAttack", throwIfNotFound: true);
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

        // Land
        private readonly InputActionMap m_Land;
        private ILandActions m_LandActionsCallbackInterface;
        private readonly InputAction m_Land_Movement;
        private readonly InputAction m_Land_Jump;
        private readonly InputAction m_Land_DoubleJump;
        private readonly InputAction m_Land_Attack;
        private readonly InputAction m_Land_PowerAttack;
        public struct LandActions
        {
            private @InputsControllers m_Wrapper;
            public LandActions(@InputsControllers wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Land_Movement;
            public InputAction @Jump => m_Wrapper.m_Land_Jump;
            public InputAction @DoubleJump => m_Wrapper.m_Land_DoubleJump;
            public InputAction @Attack => m_Wrapper.m_Land_Attack;
            public InputAction @PowerAttack => m_Wrapper.m_Land_PowerAttack;
            public InputActionMap Get() { return m_Wrapper.m_Land; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
            public void SetCallbacks(ILandActions instance)
            {
                if (m_Wrapper.m_LandActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                    @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                    @DoubleJump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDoubleJump;
                    @DoubleJump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDoubleJump;
                    @DoubleJump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDoubleJump;
                    @Attack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                    @PowerAttack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnPowerAttack;
                    @PowerAttack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnPowerAttack;
                    @PowerAttack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnPowerAttack;
                }
                m_Wrapper.m_LandActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @DoubleJump.started += instance.OnDoubleJump;
                    @DoubleJump.performed += instance.OnDoubleJump;
                    @DoubleJump.canceled += instance.OnDoubleJump;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @PowerAttack.started += instance.OnPowerAttack;
                    @PowerAttack.performed += instance.OnPowerAttack;
                    @PowerAttack.canceled += instance.OnPowerAttack;
                }
            }
        }
        public LandActions @Land => new LandActions(this);
        private int m_KeyBoardSchemeIndex = -1;
        public InputControlScheme KeyBoardScheme
        {
            get
            {
                if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.FindControlSchemeIndex("KeyBoard");
                return asset.controlSchemes[m_KeyBoardSchemeIndex];
            }
        }
        private int m_GamePadSchemeIndex = -1;
        public InputControlScheme GamePadScheme
        {
            get
            {
                if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
                return asset.controlSchemes[m_GamePadSchemeIndex];
            }
        }
        public interface ILandActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnDoubleJump(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnPowerAttack(InputAction.CallbackContext context);
        }
    }
}
