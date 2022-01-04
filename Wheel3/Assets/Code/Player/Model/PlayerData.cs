using UnityEngine;

namespace Sergey
{
    public class PlayerData
    {
        private  PlayerMoveSO _playerMoveSo;
        private  SettingJumpSO _settingJumpSo;
        
        public  float _speedPlayerX;
        public  float _speedPlayerY;
        public  float _maxPlayerSpeedX;
        public  float _maxPlayerSpeedY;

        public  float _playerJumpX;
        public  float _playerJumpY;

        public  AudioClip _AudioClip; // прокинуть клип и дописать логику в Controller`e
        
        public PlayerData(PlayerMoveSO playerMoveSo, SettingJumpSO settingJumpSo)
        {
            _speedPlayerX = playerMoveSo._speedPlayerX;
            _speedPlayerY = playerMoveSo._speedPlayerY;
            _maxPlayerSpeedX = playerMoveSo._maxPlayerSpeedX;
            _maxPlayerSpeedY = playerMoveSo._maxPlayerSpeedY;
            _playerJumpX = settingJumpSo.JumpX;
            _playerJumpY = settingJumpSo.JumpY;
            _AudioClip = settingJumpSo._AudioClip;
        }
    }
}