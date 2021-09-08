using UnityEngine;

namespace UdemyTdd.Abstracts.Movements
{
    public interface IMover
    {
        void FixedTick(Vector3 direction);
    }    
}

