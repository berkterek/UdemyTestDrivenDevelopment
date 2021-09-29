using UdemyTdd.Abstracts.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace UdemyTdd.Movements
{
    public class MoveWithNavmeshAgent : IMover
    {
        NavMeshAgent _navMeshAgent;
        
        public MoveWithNavmeshAgent(Transform transform)
        {
            _navMeshAgent = transform.GetComponent<NavMeshAgent>();
        }
        
        public void FixedTick(Vector3 direction)
        {
            if (direction.x == _navMeshAgent.destination.x && direction.z == _navMeshAgent.destination.z) return;
            
            _navMeshAgent.SetDestination(direction);
        }
    }    
}