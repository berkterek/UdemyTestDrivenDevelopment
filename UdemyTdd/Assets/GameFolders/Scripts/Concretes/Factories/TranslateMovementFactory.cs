using UdemyTdd.Abstracts.Factories;
using UdemyTdd.Abstracts.Movements;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Factories
{
    public class TranslateMovementFactory : Factory<IMover>
    {
        Transform _transform;
        
        public TranslateMovementFactory(Transform transform)
        {
            _transform = transform;
        }
        
        public override IMover Create()
        {
            return new MoveWithTranslate(_transform);
        }
    }
}