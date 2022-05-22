using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCamera : MonoBehaviour
{
    Vector2 _startPos;
    Vector2 _direction;

    [SerializeField] GameObject _player;
    [SerializeField] CameraFollow _cameraFollow;

    void Update(){
        transform.LookAt(_player.transform.position);

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            switch(touch.phase){
                case TouchPhase.Began:
                    _startPos = touch.position;
                    _cameraFollow.enabled = false;
                    break;
                case TouchPhase.Moved:
                    _direction = touch.position - _startPos;
                    transform.RotateAround(_player.transform.position, new Vector3(0f, _direction.x, 0f), Mathf.Abs(_direction.x) * Time.deltaTime * 0.5f);
                    break;
                case TouchPhase.Ended:
                    _cameraFollow.enabled = true;
                    break;
            }
        }
    }
}
