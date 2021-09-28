using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerCharacterController : PlayerController
    {
        protected override void Awake()
        {
            base.Awake();
            _mover = new MoveWithCharacterController(this.transform);
        }
    }    
}