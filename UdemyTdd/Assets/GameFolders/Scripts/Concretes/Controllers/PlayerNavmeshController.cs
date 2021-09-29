using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Movements;
using UnityEngine;

namespace UdemyTdd.Controllers
{
    public class PlayerNavmeshController : PlayerController
    {
        bool _isLeftButtonDown;
        Camera _camera;

        public IMouseInputReader Input { get; set; }

        void Awake()
        {
            _mover = new MoveWithNavmeshAgent(this.transform);
            _camera = Camera.main;
            Input = new MouseInputReader();
        }

        void Update()
        {
            if (!Input.IsLeftButtonDown) return;

            Ray ray = _camera.ScreenPointToRay(Input.Direction);

            if (!Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)) return;

            _direction = hit.point;
        }
    }
}