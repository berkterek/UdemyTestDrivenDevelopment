using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Factories;

namespace UdemyTdd.Controllers
{
    public class PlayerTranslateController : PlayerController
    {
        public IDirectionInputReader Input { get; set; }
        
        void Awake()
        {
            _mover = new TranslateMovementFactory(this.transform).Create();
            Input = new DirectionInputFactory().Create();
        }

        void Update()
        {
            _direction = Input.Direction;
        }
    }
}