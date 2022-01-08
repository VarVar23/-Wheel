using System;

namespace Sergey
{
    public class CoinController : IDisposable
    {
        private CoinModel _coinModel;
        private CoinView[] _coinView;
        private CoinSO _coinSo;

        public CoinController(CoinSO coinSo, CoinView[] coinView)
        {
            _coinModel = new CoinModel(coinSo);
            _coinSo = coinSo;
            _coinView = coinView;
<<<<<<< Updated upstream
            coinView._playSound += PlayAudioCoin;
            coinView._playAnimation += PlayAnimationCoin;
=======
            
            for (int i = 0; i < coinView.Length; i++)
            {
                coinView[i].CountCoin += CountCoin;
                coinView[i].PlaySound += PlayAudioCoin;
                coinView[i].PlayAnimation += PlayAnimationCoin;
            }
            PlayerPrefs.GetInt("Money", 0); // возможно не здесь должен находиться
>>>>>>> Stashed changes
        }

        private void CountCoin()
        {
            _coinModel.CountCoin += _coinSo._countCoin;
            Debug.Log(_coinModel.CountCoin);
        }

        private void PlayAnimationCoin()
        {
            //_coinModel.AudioClipCoin.Play();
            Debug.Log("Play");
        }

        public void PlayAudioCoin()
        {
            _coinModel.AudioClipCoin.Play(); // возможно не будет проигрываться
        }


        public void Dispose()
        {
            for (int i = 0; i < _coinView.Length; i++)
            {
                _coinView[i].CountCoin -= CountCoin;
                _coinView[i].PlaySound -= PlayAudioCoin;
                _coinView[i].PlayAnimation -= PlayAnimationCoin;
            }
        }
    }
}