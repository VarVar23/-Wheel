using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerView : MonoBehaviour
    {
        public event Action DoJump;

        private void Start()
        {
            PlayerPrefs.GetInt("ActiveSkin", 0);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                DoJump.Invoke();
            }
        }
    }
}