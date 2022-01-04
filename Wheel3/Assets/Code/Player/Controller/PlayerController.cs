
using System;
using UnityEngine;

namespace Sergey
{
    public class PlayerController : IDisposable
    {
        private PlayerView _playerView;
        private Rigidbody2D _rigidbody2D;

        private ContactPoint2D[] _contactPoint;
        private Collider2D _collider2D;
        private int _contactsCount;
        private bool IsGrounded;

        public PlayerController(PlayerView playerView, ForceForPlayer forceForPlayer, SettingJump settingJump)
        {
            _contactPoint = new ContactPoint2D[10];
            _collider2D = playerView.GetComponent<Collider2D>();
            _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
            PlayerData._speedPlayerX = forceForPlayer._speedPlayerX;
            PlayerData._speedPlayerY = forceForPlayer._speedPlayerY;
            PlayerData._maxPlayerSpeedX = forceForPlayer._maxPlayerSpeedX;
            PlayerData._maxPlayerSpeedY = forceForPlayer._maxPlayerSpeedY;
            PlayerData._playerJumpX = settingJump.JumpX;
            PlayerData._playerJumpY = settingJump.JumpY;
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
            if (!IsGrounded || _rigidbody2D.velocity.x > PlayerData._maxPlayerSpeedX
                            || _rigidbody2D.velocity.y > PlayerData._maxPlayerSpeedY) return;

            _rigidbody2D.velocity += new Vector2(PlayerData._speedPlayerX, PlayerData._speedPlayerY);
        }

        public void PlayerJump()
        {
            if(!IsGrounded) return;

            _rigidbody2D.AddForce(new Vector2(PlayerData._playerJumpX,PlayerData._playerJumpY), ForceMode2D.Impulse);
        }

        public void Dispose()
        {
            _playerView.DoJump -= PlayerJump;
        }
    }
}