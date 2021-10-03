using UdemyTdd.Abstracts.Controllers;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Factories;
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
            _mover = new NavmeshMovementFactory(this.transform).Create();
            Input = new MouseInputFactory().Create();
            _camera = Camera.main;
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