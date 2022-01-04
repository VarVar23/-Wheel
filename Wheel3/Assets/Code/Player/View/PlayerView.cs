using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sergey
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Button _buttonToJump;
        [SerializeField] private Button _otherButton;
        public event Action DoJump;

        private void Start()
        {
            _buttonToJump.onClick.AddListener(() => DoJump.Invoke());
            _otherButton.onClick.AddListener(()=>
            {
                Time.timeScale = 0.0f; // для проверки работы
                Debug.Log("Other");
            });
        }
    }
}