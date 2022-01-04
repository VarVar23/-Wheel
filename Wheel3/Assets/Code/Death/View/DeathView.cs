using System;
using UnityEngine;

namespace Sergey
{
    public class DeathView : MonoBehaviour
    {
        public event Action Death;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.GetComponent<PlayerView>())
                Death?.Invoke();
        }
    }
}