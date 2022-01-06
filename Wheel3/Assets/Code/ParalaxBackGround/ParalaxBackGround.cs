using UnityEngine;

namespace Sergey.ParalaxBackGround
{
    public class ParalaxBackGround : MonoBehaviour // конфликт из-за оффсета камеры
    {
        [SerializeField] private Transform _cameraTransform;
        private Vector3 _lastTransformCamera;
        private void Start()
        {
            _cameraTransform.position = transform.position;
            _lastTransformCamera = _cameraTransform.position;
        }

        private void Update()
        {
            Vector3 deltaMovement = _cameraTransform.position - _lastTransformCamera;
            transform.position += deltaMovement;
            _lastTransformCamera = transform.position;
        }
    }
}