using UnityEngine;

public class PlayerSpawnController
{
    private GameObject _gameObjectPlayer;
    private Vector3 _positionSpawn;

    public PlayerSpawnController(GameObject CreateGameObjectPlayer, Transform parent)
    {
        _positionSpawn = new Vector3(0, 0, 0);
        //_gameObjectPlayer = GameObject.Instantiate(CreateGameObjectPlayer, _positionSpawn, Quaternion.identity, parent);
        PlayerPrefs.GetInt("ActiveSkin", 0);
    }
}
