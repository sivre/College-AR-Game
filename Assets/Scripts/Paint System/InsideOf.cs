using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideOf : MonoBehaviour
{
    public List<GameObject> insideMe = new List<GameObject>();

    private void OnTriggerEnter(Collider other) {
        if(!insideMe.Contains(other.gameObject)){
            if(other.gameObject.layer == 6){
                insideMe.Add(other.gameObject);
            }
        }
        Debug.Log(other + "entered the log.");
    }

    private void OnTriggerExit(Collider other) {
        if(this.insideMe.Contains(other.gameObject)){
            this.insideMe.Remove(other.gameObject);
        }
    }
}
