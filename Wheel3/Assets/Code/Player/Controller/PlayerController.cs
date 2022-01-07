using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerController : IDisposable
    {
        private PlayerView _playerView;
        private PlayerData _playerData;

        private Rigidbody2D _rigidbody2D;

        private ContactPoint2D[] _contactPoint;
        private Collider2D _collider2D;
        private int _contactsCount;

        private bool _isGrounded;


        public PlayerController(PlayerView playerView, PlayerMoveSO playerMoveSo, SettingJumpSO settingJumpSo)
        {
            _collider2D = playerView.GetComponent<Collider2D>();
            _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
            _contactPoint = new ContactPoint2D[10];
            _playerData = new PlayerData(playerMoveSo, settingJumpSo);
            _playerView = playerView;
            playerView.DoJump += PlayerJump;
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
                             || _rigidbody2D.velocity.y > _playerData._maxPlayerSpeedY ||
                             _rigidbody2D.angularVelocity < -1000) return;

            _rigidbody2D.AddTorque(_playerData._speedPlayerX);
        }

        public void PlayerJump()
        {
            if (!_isGrounded) return;

            _rigidbody2D.AddForce(new Vector2(_playerData._playerJumpX, _playerData._playerJumpY), ForceMode2D.Impulse);
        }

        public void Dispose()
        {
            _playerView.DoJump -= PlayerJump;
        }
    }
}