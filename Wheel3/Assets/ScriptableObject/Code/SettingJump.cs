using UnityEngine;

namespace Sergey
{
    [CreateAssetMenu(fileName = "SettingJumpSO", menuName = "ScriptableObject/SettingJumpSO", order = 0)]
    public class SettingJump : ScriptableObject
    {
        public float JumpX;
        public float JumpY;
        public AudioClip _AudioClip;
    }
}