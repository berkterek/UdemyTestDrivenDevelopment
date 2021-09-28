using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Movements;

namespace UdemyTdd.Controllers
{
    public class PlayerTranslateController : PlayerController
    {
        protected override void Awake()
        {
            base.Awake();
            _mover = new MoveWithTranslate(this.transform);
        }
    }
}