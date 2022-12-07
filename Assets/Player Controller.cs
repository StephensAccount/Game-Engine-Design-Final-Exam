// GENERATED AUTOMATICALLY FROM 'Assets/Player Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controller"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""43416804-be38-4fd7-8efa-9d881f76fd6a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""665bf62b-82ab-4bd7-8d2d-f1f2473cadd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5536eaa6-ebd6-4778-8626-51ce04b1eba5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f496b849-1c30-4992-9e50-443247ef1420"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""713f61d7-ec7f-43e4-b3c0-2878f72872e4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Game Editor"",
            ""id"": ""92f59746-9395-4258-9fd9-da1289ec9ea6"",
            ""actions"": [
                {
                    ""name"": ""Undo"",
                    ""type"": ""Button"",
                    ""id"": ""82827fa9-154f-4a63-b1a5-446c73031d2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Object Pooling"",
                    ""type"": ""Button"",
                    ""id"": ""30facb3e-4d8d-4522-988c-beb7c9e5dccb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cce634e0-01a4-479e-89ed-a3c9c635ac95"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2017d411-4596-4daf-84cd-47c35811f66d"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Object Pooling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efe7f402-5956-42d3-9209-a76559b26e4c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Object Pooling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Game Editor
        m_GameEditor = asset.FindActionMap("Game Editor", throwIfNotFound: true);
        m_GameEditor_Undo = m_GameEditor.FindAction("Undo", throwIfNotFound: true);
        m_GameEditor_ObjectPooling = m_GameEditor.FindAction("Object Pooling", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerController m_Wrapper;
        public MovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Game Editor
    private readonly InputActionMap m_GameEditor;
    private IGameEditorActions m_GameEditorActionsCallbackInterface;
    private readonly InputAction m_GameEditor_Undo;
    private readonly InputAction m_GameEditor_ObjectPooling;
    public struct GameEditorActions
    {
        private @PlayerController m_Wrapper;
        public GameEditorActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Undo => m_Wrapper.m_GameEditor_Undo;
        public InputAction @ObjectPooling => m_Wrapper.m_GameEditor_ObjectPooling;
        public InputActionMap Get() { return m_Wrapper.m_GameEditor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameEditorActions set) { return set.Get(); }
        public void SetCallbacks(IGameEditorActions instance)
        {
            if (m_Wrapper.m_GameEditorActionsCallbackInterface != null)
            {
                @Undo.started -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnUndo;
                @Undo.performed -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnUndo;
                @Undo.canceled -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnUndo;
                @ObjectPooling.started -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnObjectPooling;
                @ObjectPooling.performed -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnObjectPooling;
                @ObjectPooling.canceled -= m_Wrapper.m_GameEditorActionsCallbackInterface.OnObjectPooling;
            }
            m_Wrapper.m_GameEditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Undo.started += instance.OnUndo;
                @Undo.performed += instance.OnUndo;
                @Undo.canceled += instance.OnUndo;
                @ObjectPooling.started += instance.OnObjectPooling;
                @ObjectPooling.performed += instance.OnObjectPooling;
                @ObjectPooling.canceled += instance.OnObjectPooling;
            }
        }
    }
    public GameEditorActions @GameEditor => new GameEditorActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGameEditorActions
    {
        void OnUndo(InputAction.CallbackContext context);
        void OnObjectPooling(InputAction.CallbackContext context);
    }
}
