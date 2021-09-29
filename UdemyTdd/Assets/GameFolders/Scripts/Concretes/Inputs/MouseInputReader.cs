using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInputReader : IMouseInputReader
{
    float _currentTime = 0f;

    public Vector3 Direction { get; private set; }
    public bool IsLeftButtonDown { get; private set; }

    public MouseInputReader()
    {
        GameInputActions input = new GameInputActions();

        input.PlayerMouse.LeftButtonDown.started += HandleOnLeftButtonDown;
        input.PlayerMouse.LeftButtonDown.canceled += HandleOnLeftButtonDown;

        input.PlayerMouse.MousePosition.performed += HandleOnMousePosition;

        input.Enable();
    }

    void HandleOnMousePosition(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        Direction = new Vector3(value.x, value.y, 0f);
    }

    void HandleOnLeftButtonDown(InputAction.CallbackContext context)
    {
        if (context.ReadValueAsButton() && _currentTime < Time.time)
        {
            IsLeftButtonDown = true;
            _currentTime = Time.time + 0.5f;
        }
        else
        {
            IsLeftButtonDown = false;
        }
    }
}