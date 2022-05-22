using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public static Paint Instance { get; private set; }

    private void Awake(){
        if(Instance != null && Instance != this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
    }


    [SerializeField] InsideOf _insideOf;
    [SerializeField] Color _color;

    void Update(){
        if(PlayerVariables.wonARGame){
            StartCoroutine(PaintBuildings());
            PlayerVariables.wonARGame = false;
        }
    }

    IEnumerator PaintBuildings(){
        yield return new WaitForSeconds(2f);
        foreach(GameObject building in _insideOf.insideMe){
            var materials = building.GetComponent<Renderer>().materials;
            materials[0].color = _color;
            materials[1].color = _color;
            building.GetComponent<Renderer>().materials = materials;
        }
    }
}
