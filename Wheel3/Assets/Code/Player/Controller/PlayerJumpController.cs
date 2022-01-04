using UnityEngine;

namespace Sergey
{
    public class PlayerJumpController
    {
        private Rigidbody2D _rigidbody2DPlayer;
        private PlayerData _playerData;

        public PlayerJumpController(PlayerData playerData, PlayerView playerView)
        {
            _playerData = playerData;
            _rigidbody2DPlayer = playerView.GetComponent<Rigidbody2D>();
        }

        public void Jump()
        {
            _rigidbody2DPlayer.AddForce(new Vector2(_playerData._playerJumpX, _playerData._playerJumpY),
                ForceMode2D.Impulse);
        }
    }
}