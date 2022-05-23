using UnityEngine;

using Niantic.ARDK.AR;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.Utilities;

public class ARManager : MonoBehaviour
{
    [SerializeField] GameObject _ballPrefab;
    [SerializeField] Camera _mainCamera;
    IARSession _ARsession;

    void Start(){
        ARSessionFactory.SessionInitialized += OnSessionInitialized;
    }

    void Update(){
        if(PlatformAgnosticInput.touchCount <= 0){
            return;
        }

        var touch = PlatformAgnosticInput.GetTouch(0);
        if(touch.phase == TouchPhase.Began){
            ShootBall(touch);
        }
    }

    void OnSessionInitialized(AnyARSessionInitializedArgs args){
        ARSessionFactory.SessionInitialized -= OnSessionInitialized;
        _ARsession = args.Session;
    }

    void ShootBall(Touch touch){
        GameObject newBall = Instantiate(_ballPrefab);
        newBall.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        newBall.transform.position = _mainCamera.transform.position + _mainCamera.transform.forward;

        Rigidbody rb = newBall.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, 0f);
        float force = 300f;
        rb.AddForce(_mainCamera.transform.forward * force);
    }
}
