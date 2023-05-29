using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameRule : MonoBehaviour
{
    // Start is called before the first frame update
    public void Rule()
    {
        SceneManager.LoadScene("RuleScene");
    }
}
