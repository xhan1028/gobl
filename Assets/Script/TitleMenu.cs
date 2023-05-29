using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    //void Start()
    //{
//Invoke("StartBtn", 3.0f);
    //}
    // Start is called before the first frame update
    public void StartBtn()
    {
        SceneManager.LoadScene("MainScreen");   
    }
}
