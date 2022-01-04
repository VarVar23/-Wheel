using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerMain : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private GameObject _prefabPlayer;
        [SerializeField] private Transform _parentPlayer;
        [SerializeField] private ForceForPlayer _forceForPlayer;
        [SerializeField] private SettingJump _settingJump;

        
        private PlayerController _playerController;

        private void Awake()
        {
            PlayerSpawnController _playerSpawnController = new PlayerSpawnController(_prefabPlayer,_parentPlayer);
            _playerController = new PlayerController(_playerView,_forceForPlayer,_settingJump);
        }
        private void FixedUpdate()
        {
            _playerController.OnContact();
            _playerController.PlayerMove();
        }
    }
}