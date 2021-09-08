using System.Collections;
using System.Collections.Generic;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Abstracts.Movements;
using UdemyTdd.Inputs;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        IMover _mover;

        Vector3 _direction;
        
        public IInputReader Input { get; set; }
        
        void Awake()
        {
            Input = new NormalInputReader();
            _mover = new MoveWithCharacterController(this.transform);
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