using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake(){
        if(Instance != null && Instance != this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
    }

    public float score = 0f;
    public float maxScore = 12f;
    
    void Update(){
        if(score >= maxScore){
            score = 12f;
            PlayerVariables.wonARGame = true;
            Debug.Log("won");
        }
    }
}
