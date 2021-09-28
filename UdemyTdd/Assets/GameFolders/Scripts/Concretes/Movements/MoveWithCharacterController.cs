using UdemyTdd.Abstracts.Movements;
using UnityEngine;

namespace UdemyTdd.Movements
{
    public class MoveWithCharacterController : IMover
    {
        readonly CharacterController _characterController;
        
        Vector3 _playerVelocity;
        bool _groundedPlayer;
        float _moveSpeed = 2.0f;
        float _gravityValue = -9.81f;

        public MoveWithCharacterController(Transform transform)
        {
            _characterController = transform.GetComponent<CharacterController>();
        }
        
        public void FixedTick(Vector3 direction)
        {
            _groundedPlayer = _characterController.isGrounded;
            if (_groundedPlayer && _playerVelocity.y < 0)
            {
                _playerVelocity.y = 0f;
            }

            _characterController.Move(direction * Time.deltaTime * _moveSpeed);

            if (direction != Vector3.zero)
            {
                _characterController.transform.forward = direction;
            }

            GravityProcess();
        }

        private void GravityProcess()
        {
            _playerVelocity.y += _gravityValue * Time.deltaTime;
            _characterController.Move(_playerVelocity * Time.deltaTime);
        }
    }    
}

