using UdemyTdd.Abstracts.Movements;
using UnityEngine;

namespace UdemyTdd.Movements
{
    public class MoveWithTranslate : IMover
    {
        float _moveSpeed = 5f;
        Transform _transform;
        Transform _directionLookPoint;

        public MoveWithTranslate(Transform transform)
        {
            _transform = transform;
            _directionLookPoint = Camera.main.transform.GetChild(0).GetComponent<Transform>();
        }

        public void FixedTick(Vector3 direction)
        {
            if (direction.magnitude == 0f) return;
            
            _transform.Translate(direction * (_moveSpeed * Time.deltaTime),_directionLookPoint);
            _transform.forward = direction;
        }
    }    
}