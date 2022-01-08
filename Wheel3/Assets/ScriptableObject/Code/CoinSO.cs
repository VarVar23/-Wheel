using UnityEngine;

namespace Sergey
{
    [CreateAssetMenu(fileName = "CoinSO", menuName = "ScriptableObject/CoinSO", order = 0)]
    public class CoinSO : ScriptableObject
    {
        public Animation _animationCoin;
        public AudioSource _audioClipCoin; // возможно придется заменить на AudioSource
        public int _countCoin;
    }
}