using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Inputs;
using UdemyTdd.Movements;

namespace UdemyTdd.Controllers
{
    public class PlayerTranslateController : PlayerController
    {
        public IDirectionInputReader Input { get; set; }
        
        void Awake()
        {
            _mover = new MoveWithTranslate(this.transform);
            Input = new DirectionInputReader();
        }

        void Update()
        {
            _direction = Input.Direction;
        }
    }
}