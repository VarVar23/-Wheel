using UnityEngine;

namespace Code.ScriptableObject
{
    [CreateAssetMenu(fileName = "ForceForPlayer", menuName = "ForceForPlayer", order = 0)]
    public class ForceForPlayer : UnityEngine.ScriptableObject
    {
        public float ConstantForce; //постоянная сила
        public float UphillForce; // в гору
        public float TiltForce; // c горы
    }
}