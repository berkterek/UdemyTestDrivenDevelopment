using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Factories;
using UdemyTdd.Inputs;

namespace UdemyTdd.Controllers
{
    public class PlayerTranslateController : PlayerController
    {
        public IDirectionInputReader Input { get; set; }
        
        void Awake()
        {
            _mover = new TranslateMovementFactory(this.transform).Create();
            Input = new DirectionInputReader();
        }

        void Update()
        {
            _direction = Input.Direction;
        }
    }
}