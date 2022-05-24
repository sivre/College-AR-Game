using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSystem : MonoBehaviour
{
    [SerializeField] GameObject _ballPrefab;
    [SerializeField] Camera _mainCamera;

    public void ShootBall(Touch touch){
        GameObject newBall = Instantiate(_ballPrefab);
        newBall.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        newBall.transform.position = _mainCamera.transform.position + _mainCamera.transform.forward;

        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, 0f);
        float force = 300f;
        rb.AddForce(_mainCamera.transform.forward * force);
    }
}
