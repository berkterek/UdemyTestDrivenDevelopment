using UdemyTdd.Abstracts.Movements;
using UnityEngine;

namespace UdemyTdd.Abstracts.Controllers
{
    public abstract class PlayerController : MonoBehaviour
    {
        protected IMover _mover;

        protected Vector3 _direction;
        
        void FixedUpdate()
        {
            _mover.FixedTick(_direction);
        }
    }    
}