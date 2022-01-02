using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]private GameObject _parentTransform;
    private GameObject _player;

    private void Awake()
    {
        var load = Resources.Load("Sphere") as GameObject;
        var postionPlayerSpawn = new Vector3(0, 0, 0);
        _player = Instantiate(load, postionPlayerSpawn, Quaternion.identity,_parentTransform.transform);
        _player.name = "Player";
    }
}
