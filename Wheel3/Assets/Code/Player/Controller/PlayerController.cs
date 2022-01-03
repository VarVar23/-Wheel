
using UnityEngine;

namespace Sergey
{
    public class PlayerController
    {
        private PlayerMain _playerMain;
        private PlayerView _playerView;

        private ForceForPlayer _forceForPlayer;
        private Rigidbody2D _rigidbody2D;

        private ContactPoint2D[] _contactPoint;
        private Collider2D _collider2D;
        private int _contactsCount;
        private bool IsGrounded;

        public PlayerController(PlayerView playerView, ForceForPlayer forceForPlayer)
        {
            _contactPoint = new ContactPoint2D[10];
            _collider2D = playerView.GetComponent<Collider2D>();
            _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
            PlayerData._speedPlayerX = forceForPlayer._speedPlayerX;
            PlayerData._speedPlayerY = forceForPlayer._speedPlayerY;
            PlayerData._maxPlayerSpeedX = forceForPlayer._maxPlayerSpeedX;
            PlayerData._maxPlayerSpeedY = forceForPlayer._maxPlayerSpeedY;
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

            Debug.Log(IsGrounded);
        }


        public void PlayerMove()
        {
            if (!IsGrounded || _rigidbody2D.velocity.x > PlayerData._maxPlayerSpeedX
                            || _rigidbody2D.velocity.y > PlayerData._maxPlayerSpeedY) return;

            _rigidbody2D.velocity += new Vector2(PlayerData._speedPlayerX, PlayerData._speedPlayerY);
        }
    }
}