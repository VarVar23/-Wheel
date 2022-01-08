using UnityEngine;

namespace Sergey
{
    public class CoinModel
    {
<<<<<<< Updated upstream
        //private Animation _animationCoin;
        //private AudioClip _audioClipCoin;
        //private int _countCoin;
=======
        private Animation _animationCoin;
        private AudioSource _audioClipCoin;
        private int _countCoin;
>>>>>>> Stashed changes
        
        public int CountCoin { get; set; }
        public Animation AnimationCoin { get; private set; }
        public AudioSource AudioClipCoin { get; private set; }

        public CoinModel(CoinSO coinSo)
        {
            AnimationCoin = coinSo._animationCoin;
            AudioClipCoin = coinSo._audioClipCoin;
            CountCoin = coinSo._countCoin;
            PlayerPrefs.SetInt("Money", CountCoin); // соглосавать с Олегом по playerPrefs.Не понятно куда их ставить
        }
    }
}