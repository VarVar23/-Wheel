using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerMain : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private GameObject _prefabPlayer;
        [SerializeField] private Transform _parentPlayer;
        [SerializeField] private PlayerMoveSO playerMoveSo;
        [SerializeField] private SettingJumpSO settingJumpSo;

        
        private PlayerController _playerController;
        private PlayerSpawnController _playerSpawnController;

        private void Start()
        {
            _playerSpawnController = new PlayerSpawnController(_prefabPlayer, _parentPlayer);
            _playerController = new PlayerController(_playerView, playerMoveSo, settingJumpSo);
        }
        
        private void FixedUpdate()
        {
            _playerController.OnContact();
            _playerController.PlayerMove();
        }
    }
}