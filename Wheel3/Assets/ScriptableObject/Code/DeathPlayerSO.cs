using UnityEngine;

namespace Sergey
{
    [CreateAssetMenu(fileName = "DeathPlayerSO", menuName = "ScriptableObject/DeathPlayerSO", order = 0)]
    public class DeathPlayerSO : ScriptableObject
    {
        public AudioClip[] _AudioClipsDeathPlayer;
    }
}