using System;
using UnityEngine;

namespace Sergey
{
    public class CoinView : MonoBehaviour
    {
<<<<<<< Updated upstream
        [SerializeField] private GameObject[] _coins;
        public event Action _playSound;
        public event Action _playAnimation;

        private void Start()
        {
            _playSound += delegate {  };
            _playAnimation += delegate {  };
            PlayerPrefs.GetInt("Money", 0); // возможно не здесь должен находиться
        }
=======
        [SerializeField] private GameObject _coins;
        public event Action PlaySound;
        public event Action PlayAnimation;
        public event Action CountCoin;
>>>>>>> Stashed changes

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.GetComponent<PlayerView>())
            {
                PlaySound?.Invoke();
                CountCoin?.Invoke();
                Destroy(this.gameObject, 5.0f);
                //PlayAnimation?.Invoke(); пока выкидывает exeption т.к. нет значений
            }
        }
    }
}