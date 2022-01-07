using UnityEngine;

namespace Sergey
{
    public class ParalaxBackGround : MonoBehaviour // конфликт из-за оффсета камеры
    {
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private Vector2 _paralaxEfect;
        private Vector3 _lastTransformCamera;
        private void Start()
        {
            _cameraTransform.position = transform.position;
            _lastTransformCamera = _cameraTransform.position;
        }

        private void Update()
        {
            Vector3 deltaMovement = _cameraTransform.position - _lastTransformCamera;
            transform.position += new Vector3(deltaMovement.x * _paralaxEfect.x, deltaMovement.y * _paralaxEfect.y);
            _lastTransformCamera = transform.position;
        }
    }
}