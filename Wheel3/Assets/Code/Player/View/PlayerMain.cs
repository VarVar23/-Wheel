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
        [SerializeField] private DeathPlayerSO audioClipDeathPlayerSo;
        [SerializeField] private GameObject _modelPlayer;
        [SerializeField] private DeathView _deathView;


        private PlayerController _playerController;
        private PlayerSpawnController _playerSpawnController;

        private void Start()
        {
            _modelPlayer.transform.position = Vector3.zero;
            _playerSpawnController = new PlayerSpawnController(_prefabPlayer, _parentPlayer);
            _playerController = new PlayerController(_playerView, playerMoveSo, settingJumpSo, audioClipDeathPlayerSo,
                _deathView);
        }

        private void FixedUpdate()
        {
            _playerController.OnContact();
            _playerController.PlayerMove();
        }
    }
}