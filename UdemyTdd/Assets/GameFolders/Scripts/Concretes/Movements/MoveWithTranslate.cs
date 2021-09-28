using UdemyTdd.Abstracts.Movements;
using UnityEngine;

namespace UdemyTdd.Movements
{
    public class MoveWithTranslate : IMover
    {
        float _moveSpeed = 5f;
        Transform _transform;
        Camera _camera;

        public MoveWithTranslate(Transform transform)
        {
            _transform = transform;
            _camera = Camera.main;
        }

        public void FixedTick(Vector3 direction)
        {
            if (direction.magnitude == 0f) return;
            
            _transform.Translate(direction * (_moveSpeed * Time.deltaTime),_camera.transform);
            _transform.forward = direction;
        }
    }    
}