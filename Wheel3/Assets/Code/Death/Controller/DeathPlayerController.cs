using System;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Sergey
{
    internal class DeathPlayerController : IDisposable
    {
        private PlayerView _playerView;
        private DeathView _deathView;
        private DeathData _deathDataPlayer;
        public DeathPlayerController(PlayerView playerView, DeathView deathView, DeathPlayerSO deathPlayerSo)
        {
            _deathDataPlayer = new DeathData(deathPlayerSo);
            _playerView = playerView;
            _deathView = deathView;
            deathView.Death += Death;
        }
        public void Death()
        {
            Object.Destroy(_playerView.gameObject);
            Debug.Log("You DEAD!!!");
            /*AudioSource.PlayClipAtPoint(_deathDataPlayer.AudioClipsDeathPlayer[Random.Range(0, 5)],
                _deathView.transform.position); // возможно не коректно будет отрабатывать клип*/
        }

        public void Dispose()
        {
            _deathView.Death -= Death;
        }
    }
}