//using Code.Model;
//using Code.View;
//using UnityEngine;


//public class PlayerController
//{
//    private ForceForPlayer _forceForPlayer;
//    private PlayerData _playerData;
//    private playerView1 _playerView;
//    private Rigidbody2D _rigidbody2D;
//    private Vector2 _move = new Vector3(0, 0);


//    public PlayerController(ForceForPlayer forceForPlayer, playerView1 playerView)
//    {
//        _playerData = new PlayerData(forceForPlayer);
//        _rigidbody2D = playerView.GetComponent<Rigidbody2D>();
//        _playerView = playerView;
//    }

//    public void PlayerMove()
//    {
//        if (!(_playerView.OnGround || _rigidbody2D.velocity.y == 0)) return;
//        Debug.Log(_playerData.ForceToSpeedPlayer.ConstantForce);
//        _rigidbody2D.velocity += new Vector2(_playerData.ForceToSpeedPlayer.ConstantForce, 0);



//        //var positionY = _rigidbody2D.transform.position.y; // наклон
//        //if (positionY > 0 && positionY < 0.5)
//        //{
//        //    _move = new Vector2(_rigidbody2D.transform.position.x + _playerData.ForceToSpeedPlayer.ConstantForce,
//        //        _rigidbody2D.transform.position.y);
//        //    _rigidbody2D.velocity += _move * Time.deltaTime ;
//        //}
//        //else if( positionY > 0.5)
//        //{
//        //    _move = new Vector2(_rigidbody2D.transform.position.x + (_playerData.ForceToSpeedPlayer.ConstantForce -
//        //                                                             _playerData.ForceToSpeedPlayer.UphillForce),
//        //        _rigidbody2D.transform.position.y);

//        //    _rigidbody2D.velocity += _move * Time.deltaTime;
//        //}
//        //else if (positionY < 0)
//        //{
//        //    _move = new Vector2(_rigidbody2D.transform.position.x + 
//        //                        (_playerData.ForceToSpeedPlayer.ConstantForce + _playerData.ForceToSpeedPlayer.TiltForce),
//        //        _rigidbody2D.transform.position.y);

//        //    _rigidbody2D.velocity += (_move * Time.deltaTime);
//        //}
//    }
//}