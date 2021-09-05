using System.Collections;
using System.Collections.Generic;
using UdemyTdd.Inputs;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        NormalInputReader _input;
        MoveWithTranslate _mover;

        Vector3 _direction;
        
        void Awake()
        {
            _input = new NormalInputReader();
            _mover = new MoveWithTranslate(this.transform);
        }

        void Update()
        {
            _direction = _input.Direction;
        }

        void FixedUpdate()
        {
            _mover.FixedTick(_direction);
        }
    }    
}