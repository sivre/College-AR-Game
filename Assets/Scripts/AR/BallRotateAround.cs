using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotateAround : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] GameObject _target;
    Vector3 _rot = new Vector3(0f, 0f, 0f);

    void Start(){
        InvokeRepeating("ReturnRandomVector3", 1f, 2f);
    }

    void Update()
    {
        transform.RotateAround(_target.transform.position, _rot, _speed * Time.deltaTime);
        if(transform.position.y < -1f || transform.position.y > 1f){
            StartCoroutine(ConvertFloat());
        }
    }

    void ReturnRandomVector3(){
        _rot = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    IEnumerator ConvertFloat(){
        _rot = -_rot;
        yield return new WaitForSeconds(1f);
    }
}
