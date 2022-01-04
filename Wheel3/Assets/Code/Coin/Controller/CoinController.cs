using System;

namespace Sergey
{
    public class CoinController : IDisposable
    {
        private CoinModel _coinModel;
        private CoinView _coinView;

        public CoinController(CoinSO coinSo, CoinView coinView)
        {
            _coinModel = new CoinModel(coinSo);
            _coinView = coinView;
            coinView._playSound += PlayAudioCoin;
            coinView._playAnimation += PlayAnimationCoin;
        }

        public void PlayAnimationCoin()
        {
            _coinModel.AnimationCoin.Play();
        }

        public void PlayAudioCoin()
        {
            _coinModel.AudioClipCoin.LoadAudioData(); // возможно не будет проигрываться
        }


        public void Dispose()
        {
            _coinView._playSound -= PlayAudioCoin;
            _coinView._playAnimation -= PlayAnimationCoin;
        }
    }
}