using UnityEngine;

namespace Sergey
{
    public class Camera : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _smooth;
        [SerializeField] private Vector3 _offset;

        private void FixedUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, _target.position + _offset, Time.deltaTime * _smooth);
        }
    }
}