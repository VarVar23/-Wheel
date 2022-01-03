using System;
using Code.Coin.View;
using Sergey;
using UnityEngine;

namespace Code.Coin.Controller
{
    public class CoinController : IDisposable
    {
        private CoinModel _coinModel;
        private CoinView _coinView;
        private CoinSO _coinSo;
        
        public CoinController(CoinSO coinSo,CoinView coinView)
        {
            _coinModel = new CoinModel(coinSo);
            _coinView = coinView;
            coinView._playSound += PlayAudioCoin;
            coinView._playAnimation += PlayAnimationCoin;
            _coinSo = coinSo;
            PlayerPrefs.GetInt("Money", 0); // возможно не здесь должен находиться

        }

        public void PlayAnimationCoin()
        {
            _coinSo._animationCoin.Play();
        }
        
        public void PlayAudioCoin()
        {
            _coinSo._audioClipCoin.LoadAudioData();
        }


        public void Dispose()
        {
            _coinView._playSound -= PlayAudioCoin;
            _coinView._playAnimation -= PlayAnimationCoin;
        }
    }
}