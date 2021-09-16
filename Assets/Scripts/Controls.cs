// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""2b389d4b-ed76-4acc-8771-f92912fc4216"",
            ""actions"": [
                {
                    ""name"": ""MovementLR"",
                    ""type"": ""Button"",
                    ""id"": ""dc6a5ab9-5a93-4827-a483-e74236d81e06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementUD"",
                    ""type"": ""Value"",
                    ""id"": ""b018e7d5-d5b7-4e97-84f4-20e61f9f9dfe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LaunchBall"",
                    ""type"": ""Button"",
                    ""id"": ""686538b1-b652-49ee-b182-2a3244adfce7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""bd6c1018-b1c4-489a-b5e3-76ad09eedf37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LR"",
                    ""id"": ""9f4b3f9c-ce54-4ffc-829d-1540d65dc921"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69d14b3f-62a3-40ce-9e8e-ad02e7df77a4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f3e5dd09-7b43-4769-94b2-3ce475c12e52"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UD"",
                    ""id"": ""68b17e07-70ef-492e-8e91-6ec829cba5b3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c16e6b8b-e554-40ec-863d-611977913e84"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ed3cb0f9-22f2-44bc-aaf4-5cf8dca45cb0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""38d0f431-0d8f-4850-ac22-12674d42d527"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""583d417f-c676-42ff-890b-b3b00545e5f9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""121ce43d-f2c4-4f9b-bf60-b06bf5f62209"",
            ""actions"": [
                {
                    ""name"": ""MovementLR"",
                    ""type"": ""Value"",
                    ""id"": ""94f3ed6e-a5bb-4147-b3e2-ab5f78aede1a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementUD"",
                    ""type"": ""Value"",
                    ""id"": ""b652263b-d7c7-411a-9ab5-4b732015bfe4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LR"",
                    ""id"": ""185a1fc9-0888-4ff2-abaa-2815db1069be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6a8c4782-a2ee-4801-aba6-05f5219aa97f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bbcde3d1-65b0-46cb-a7e4-bd058cd5a780"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UD"",
                    ""id"": ""9e587285-5d30-480a-8875-40934add9c78"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""89d869b9-bc1d-4563-abb9-7480d8575285"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""706a7a3f-d6a3-4062-b6e7-4598b3d6cb18"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_MovementLR = m_Player1.FindAction("MovementLR", throwIfNotFound: true);
        m_Player1_MovementUD = m_Player1.FindAction("MovementUD", throwIfNotFound: true);
        m_Player1_LaunchBall = m_Player1.FindAction("LaunchBall", throwIfNotFound: true);
        m_Player1_PauseGame = m_Player1.FindAction("PauseGame", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_MovementLR = m_Player2.FindAction("MovementLR", throwIfNotFound: true);
        m_Player2_MovementUD = m_Player2.FindAction("MovementUD", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_MovementLR;
    private readonly InputAction m_Player1_MovementUD;
    private readonly InputAction m_Player1_LaunchBall;
    private readonly InputAction m_Player1_PauseGame;
    public struct Player1Actions
    {
        private @Controls m_Wrapper;
        public Player1Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementLR => m_Wrapper.m_Player1_MovementLR;
        public InputAction @MovementUD => m_Wrapper.m_Player1_MovementUD;
        public InputAction @LaunchBall => m_Wrapper.m_Player1_LaunchBall;
        public InputAction @PauseGame => m_Wrapper.m_Player1_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @MovementLR.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementLR;
                @MovementLR.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementLR;
                @MovementLR.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementLR;
                @MovementUD.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementUD;
                @MovementUD.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementUD;
                @MovementUD.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovementUD;
                @LaunchBall.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLaunchBall;
                @LaunchBall.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLaunchBall;
                @LaunchBall.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLaunchBall;
                @PauseGame.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementLR.started += instance.OnMovementLR;
                @MovementLR.performed += instance.OnMovementLR;
                @MovementLR.canceled += instance.OnMovementLR;
                @MovementUD.started += instance.OnMovementUD;
                @MovementUD.performed += instance.OnMovementUD;
                @MovementUD.canceled += instance.OnMovementUD;
                @LaunchBall.started += instance.OnLaunchBall;
                @LaunchBall.performed += instance.OnLaunchBall;
                @LaunchBall.canceled += instance.OnLaunchBall;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_MovementLR;
    private readonly InputAction m_Player2_MovementUD;
    public struct Player2Actions
    {
        private @Controls m_Wrapper;
        public Player2Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementLR => m_Wrapper.m_Player2_MovementLR;
        public InputAction @MovementUD => m_Wrapper.m_Player2_MovementUD;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @MovementLR.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementLR;
                @MovementLR.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementLR;
                @MovementLR.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementLR;
                @MovementUD.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementUD;
                @MovementUD.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementUD;
                @MovementUD.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovementUD;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementLR.started += instance.OnMovementLR;
                @MovementLR.performed += instance.OnMovementLR;
                @MovementLR.canceled += instance.OnMovementLR;
                @MovementUD.started += instance.OnMovementUD;
                @MovementUD.performed += instance.OnMovementUD;
                @MovementUD.canceled += instance.OnMovementUD;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer1Actions
    {
        void OnMovementLR(InputAction.CallbackContext context);
        void OnMovementUD(InputAction.CallbackContext context);
        void OnLaunchBall(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMovementLR(InputAction.CallbackContext context);
        void OnMovementUD(InputAction.CallbackContext context);
    }
}
