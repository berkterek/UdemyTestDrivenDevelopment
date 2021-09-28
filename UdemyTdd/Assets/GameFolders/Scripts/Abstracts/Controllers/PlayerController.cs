using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Abstracts.Movements;
using UdemyTdd.Inputs;
using UnityEngine;

namespace UdemyTdd.Abstracts.Controllers
{
    public abstract class PlayerController : MonoBehaviour
    {
        protected IMover _mover;

        Vector3 _direction;
        
        public IInputReader Input { get; set; }

        protected virtual void Awake()
        {
            Input = new NormalInputReader();
        }

        void Update()
        {
            _direction = Input.Direction;
        }

        void FixedUpdate()
        {
            _mover.FixedTick(_direction);
        }
    }    
}