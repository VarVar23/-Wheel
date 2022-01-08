using System.Collections.Generic;
using UnityEngine;

namespace Sergey
{
<<<<<<< Updated upstream
    public class Main : MonoBehaviour
=======
  public class Main : MonoBehaviour
  {
    [SerializeField] private CoinView[] _coinView;
    [SerializeField] private CoinSO _coinSo;
    private CoinController _coinController;

    private void Start()
>>>>>>> Stashed changes
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