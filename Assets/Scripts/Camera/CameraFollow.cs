using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 _position = new Vector3();
    [SerializeField] GameObject _player;

    void Update(){
        transform.position = _position + _player.transform.position;
    }
}
