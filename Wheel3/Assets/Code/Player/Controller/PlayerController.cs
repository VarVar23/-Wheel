using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerController : IDisposable
    {
        private PlayerView _playerView;
<<<<<<< HEAD
        private PlayerData _playerData;

        private PlayerMoveSO _playerMoveSo;
=======
>>>>>>> 32c80f6776635e880831ce50ff255b083186555d
        private Rigidbody2D _rigidbody2D;

        private ContactPoint2D[] _contactPoint;
        private Collider2D _collider2D;
        private int _contactsCount;
        private bool IsGrounded;

        public PlayerController(PlayerView playerView, PlayerMoveSO playerMoveSo, SettingJumpSO settingJumpSo)
        {
            _collider2D = playerView.GetComponent<Collider2D>();
            _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
            _contactPoint = new ContactPoint2D[10];
            _playerData = new PlayerData(playerMoveSo,settingJumpSo);
            playerView.DoJump += PlayerJump;
        }


        public void OnContact()
        {
            _contactsCount = _collider2D.GetContacts(_contactPoint);

            if (_contactsCount > 0)
            {
                IsGrounded = true;
            }
            else
            {
                IsGrounded = false;
            }
        }

        public void PlayerMove()
        {
            if (!IsGrounded || _rigidbody2D.velocity.x > _playerData._maxPlayerSpeedX
                            || _rigidbody2D.velocity.y > _playerData._maxPlayerSpeedY) return;

            _rigidbody2D.velocity += new Vector2(_playerData._speedPlayerX, _playerData._speedPlayerY);
        }

        public void PlayerJump()
        {
            if(!IsGrounded) return;
<<<<<<< HEAD
           
            _rigidbody2D.AddForce(new Vector2(_playerData._playerJumpX,_playerData._playerJumpY), ForceMode2D.Impulse);
                
=======

            _rigidbody2D.AddForce(new Vector2(PlayerData._playerJumpX,PlayerData._playerJumpY), ForceMode2D.Impulse);
>>>>>>> 32c80f6776635e880831ce50ff255b083186555d
        }

        public void Dispose()
        {
            _playerView.DoJump -= PlayerJump;
        }
    }
}