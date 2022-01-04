using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sergey
{
    public class PlayerView : MonoBehaviour
    {
       public event Action DoJump;

        private void Update()
        {
<<<<<<< HEAD
            if (Input.GetMouseButtonDown(0))
            {
                DoJump.Invoke();
            }
=======
            _buttonToJump.onClick.AddListener(() => DoJump.Invoke());
            _otherButton.onClick.AddListener(()=>
            {
                Time.timeScale = 0.0f; // для проверки работы
                Debug.Log("Other");
            });
>>>>>>> 32c80f6776635e880831ce50ff255b083186555d
        }
    }
}