using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript2 : MonoBehaviour
{
    void Update(){
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
        }
        else if (Input.GetKeyDown("a"))
        {
            SceneManager.LoadScene("MapScene", LoadSceneMode.Single);
        }
    }
}
