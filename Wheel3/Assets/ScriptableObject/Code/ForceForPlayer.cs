using UnityEngine;

namespace Sergey
{
    [CreateAssetMenu(fileName = "ForceForPlayerSO", menuName = "ScriptableObject/ForceForPlayerSO", order = 0)]
    public class ForceForPlayer : UnityEngine.ScriptableObject
    {
        public float _speedPlayerX; 
        public float _speedPlayerY;
        public float _maxPlayerSpeedX;
        public float _maxPlayerSpeedY;
    }
}