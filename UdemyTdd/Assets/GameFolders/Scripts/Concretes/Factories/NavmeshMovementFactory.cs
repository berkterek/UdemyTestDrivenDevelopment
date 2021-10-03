using UdemyTdd.Abstracts.Factories;
using UdemyTdd.Abstracts.Movements;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Factories
{
    public class NavmeshMovementFactory : Factory<IMover>
    {
        Transform _transform;
        
        public NavmeshMovementFactory(Transform transform)
        {
            _transform = transform;
        }
        
        public override IMover Create()
        {
            return new MoveWithNavmeshAgent(_transform);
        }
    }    
}

