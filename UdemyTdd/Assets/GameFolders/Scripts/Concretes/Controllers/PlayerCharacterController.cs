using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Inputs;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerCharacterController : PlayerController
    {
        public IDirectionInputReader Input { get; set; }
        
        void Awake()
        {
            _mover = new MoveWithCharacterController(this.transform);
            Input = new DirectionInputReader();
        }

        void Update()
        {
            _direction = Input.Direction;
        }
    }    
}