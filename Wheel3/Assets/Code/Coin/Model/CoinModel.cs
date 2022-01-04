using UnityEngine;

namespace Sergey
{
    public class CoinModel
    {
        private Animation _animationCoin;
        private AudioClip _audioClipCoin;
        private int _countCoin;
        
        public int CountCoin { get; private set; }
        public Animation AnimationCoin { get; private set; }
        public AudioClip AudioClipCoin { get; private set; }

        public CoinModel(CoinSO coinSo)
        {
            _animationCoin = coinSo._animationCoin;
            _audioClipCoin = coinSo._audioClipCoin;
            _countCoin = coinSo._countCoin;
            PlayerPrefs.SetInt("Money", CountCoin); // соглосавать с Олегом по playerPrefs.Не понятно куда их ставить
        }
    }
}