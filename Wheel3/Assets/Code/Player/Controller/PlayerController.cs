using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerController : IDisposable
    {
        private PlayerView _playerView;
        private PlayerData _playerData;
        private DeathPlayerController _deathPlayerController;
        private PlayerJumpController _playerJumpController;

        private PlayerMoveSO _playerMoveSo;
        private Rigidbody2D _rigidbody2D;

        private ContactPoint2D[] _contactPoint;
        private Collider2D _collider2D;
        private int _contactsCount;
        private bool _isGrounded;

        public PlayerController(PlayerView playerView, PlayerMoveSO playerMoveSo, SettingJumpSO settingJumpSo,
            DeathPlayerSO deathPlayerSoSo,
            DeathView deathView)
        {
            _collider2D = playerView.GetComponent<Collider2D>();
            _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
            _contactPoint = new ContactPoint2D[10];
            _playerData = new PlayerData(playerMoveSo, settingJumpSo);
            _playerJumpController = new PlayerJumpController(_playerData, playerView);
            _deathPlayerController = new DeathPlayerController(playerView, deathView, deathPlayerSoSo);
            playerView.DoJump += Jumps;
        }

        public void OnContact()
        {
            _contactsCount = _collider2D.GetContacts(_contactPoint);

            if (_contactsCount > 0)
            {
                _isGrounded = true;
            }
            else
            {
                _isGrounded = false;
            }
        }

        public void PlayerMove()
        {
            if (!_isGrounded || _rigidbody2D.velocity.x > _playerData._maxPlayerSpeedX
                             || _rigidbody2D.velocity.y > _playerData._maxPlayerSpeedY) return;

            _rigidbody2D.velocity += new Vector2(_playerData._speedPlayerX, _playerData._speedPlayerY);
        }

        public void Jumps()
        {
            if (!_isGrounded) return;

            _playerJumpController.Jump();
        }

        public void Dispose()
        {
            _playerView.DoJump -= Jumps;
        }
    }
}