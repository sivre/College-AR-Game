using UnityEngine;

using Niantic.ARDK.AR;
using Niantic.ARDK.AR.ARSessionEventArgs;
using Niantic.ARDK.Utilities;

public class ARManager : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;
    [SerializeField] BallSystem _ballSystem;
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
            _ballSystem.ShootBall(touch);
        }
    }

    void OnSessionInitialized(AnyARSessionInitializedArgs args){
        ARSessionFactory.SessionInitialized -= OnSessionInitialized;
        _ARsession = args.Session;
    }
}
