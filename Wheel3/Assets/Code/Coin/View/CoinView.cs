using System;
using UnityEngine;

namespace Sergey
{
    public class CoinView : MonoBehaviour
    {
        [SerializeField] private GameObject[] _coins;
        public event Action _playSound;
        public event Action _playAnimation;

        private void Start()
        {
            _playSound += delegate {  };
            _playAnimation += delegate {  };
            PlayerPrefs.GetInt("Money", 0); // возможно не здесь должен находиться
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.GetComponent<PlayerView>())
            {
                _playAnimation?.Invoke();
                _playSound?.Invoke();
                GameObject.Destroy(this.gameObject,5.0f); // обратить внимание на уаляемый обыъкт, возможно будет удалять все объекты со сцены
            }
        }
    }
}