using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Factories;
using UdemyTdd.Inputs;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerCharacterController : PlayerController
    {
        public IDirectionInputReader Input { get; set; }
        
        void Awake()
        {
            _mover = new CharacterControllerMovementFactory(this.transform).Create();
            Input = new DirectionInputReader();
        }

        void Update()
        {
            _direction = Input.Direction;
        }
    }    
}