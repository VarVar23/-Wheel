<<<<<<< HEAD
﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Main : MonoBehaviour
//{
//    [SerializeField] private playerView1 _playerView;
//    [SerializeField] private ForceForPlayer _forceForPlayer;

//    private PlayerController _playerController;

//    private void Start()
//    {
//        _playerController = new PlayerController(_forceForPlayer, _playerView);
//    }

//    private void FixedUpdate()
//    {
//        _playerController.PlayerMove();
//    }
//}
=======
﻿using Code.Coin.Controller;
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
>>>>>>> main
