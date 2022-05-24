using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    float _maximum;
    float _current;
    [SerializeField] Image _mask;

    void GetCurrentFill(){
        float fillAmount = _current / _maximum;
        _mask.fillAmount = fillAmount;
    }

    void Start(){
        _maximum = GameManager.Instance.maxScore;
    }

    void Update(){
        _current = GameManager.Instance.score;
        GetCurrentFill();
        if(_current == _maximum){
            _mask.color = Color.green;
        }
        else if(_current > _maximum/2){
            _mask.color = Color.yellow;
        }
    }
}
