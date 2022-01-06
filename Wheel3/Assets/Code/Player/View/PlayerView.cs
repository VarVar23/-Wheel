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
            if (Input.GetMouseButtonDown(0))
            {
                DoJump.Invoke();
            };
        }
    }
}