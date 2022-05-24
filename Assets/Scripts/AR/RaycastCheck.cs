using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCheck : MonoBehaviour
{
    void Update(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.isTrigger && GameManager.Instance.score < GameManager.Instance.maxScore){
                GameManager.Instance.score += Time.deltaTime;
            }
        }
    }
}
