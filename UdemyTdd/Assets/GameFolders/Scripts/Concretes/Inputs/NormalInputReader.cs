using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyTdd.Inputs
{
    public class NormalInputReader
    {
        public Vector3 Direction { get; private set; }

        public NormalInputReader()
        {
            GameInputActions input = new GameInputActions();
            
            input.Player.Movement.performed += OnMovement;
            input.Player.Movement.canceled += OnMovement;
            
            input.Enable();
        }

        void OnMovement(InputAction.CallbackContext context)
        {
            Vector2 direction2D = context.ReadValue<Vector2>();
            Direction = new Vector3(direction2D.x, 0f, direction2D.y);
        }
    }    
}