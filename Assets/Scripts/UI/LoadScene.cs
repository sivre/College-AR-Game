using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadARScene(){
        SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
    }

    public void LoadMapScene(){
        SceneManager.LoadScene("MapScene", LoadSceneMode.Single);
    }
}
