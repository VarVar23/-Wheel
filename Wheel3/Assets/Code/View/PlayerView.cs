using Code.Controller;
using Code.ScriptableObject;
using UnityEngine;

namespace Code.View
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]private ForceForPlayer _forceForPlayer;
        private PlayerController _playerController;
        

        private void Start()
        {
            _playerController = new PlayerController(_forceForPlayer,this);
        }

        private void FixedUpdate()
        {
            _playerController.PlayerMove();
        }
    }
}