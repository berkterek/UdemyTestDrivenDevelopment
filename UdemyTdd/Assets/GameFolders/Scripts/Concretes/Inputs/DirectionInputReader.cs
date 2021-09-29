using UdemyTdd.Abstracts.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyTdd.Inputs
{
    public class DirectionInputReader : IDirectionInputReader
    {
        public Vector3 Direction { get; private set; }

        public DirectionInputReader()
        {
            GameInputActions input = new GameInputActions();
            
            input.PlayerGamepad.Movement.performed += OnMovement;
            input.PlayerGamepad.Movement.canceled += OnMovement;
            
            input.Enable();
        }

        void OnMovement(InputAction.CallbackContext context)
        {
            Vector2 direction2D = context.ReadValue<Vector2>();
            Direction = new Vector3(direction2D.x, 0f, direction2D.y);
        }
    }    
}