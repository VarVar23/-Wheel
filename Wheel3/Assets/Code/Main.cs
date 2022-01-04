using UnityEngine;

namespace Sergey
{
  public class Main : MonoBehaviour
  {
    [SerializeField] private CoinView _coinView;
    [SerializeField] private CoinSO _coinSo;
    private CoinController _coinController;
  
    private void Start()
    {
      _coinController = new CoinController(_coinSo, _coinView);
    }
  }
}

