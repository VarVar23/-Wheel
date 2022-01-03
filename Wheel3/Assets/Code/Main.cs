using Code.Coin.Controller;
using Code.Coin.View;
using Sergey;
using UnityEngine;

public class Main : MonoBehaviour
{
  [SerializeField] private CoinView _coinView;
  [SerializeField] private CoinSO _coinSo;
  private CoinModel _coinModel;
  private CoinController _coinController;

  private void Start()
  {
    _coinController = new CoinController(_coinSo, _coinView);
  }
}
