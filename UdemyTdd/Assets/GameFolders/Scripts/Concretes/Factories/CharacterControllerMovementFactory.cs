using UdemyTdd.Abstracts.Factories;
using UdemyTdd.Abstracts.Movements;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Factories
{
    public class CharacterControllerMovementFactory : Factory<IMover>
    {
        Transform _transform;

        public CharacterControllerMovementFactory(Transform transform)
        {
            _transform = transform;
        }

        public override IMover Create()
        {
            return new MoveWithCharacterController(_transform);
        }
    }
}