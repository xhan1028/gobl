using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChatController : MonoBehaviour
{
    public TextMeshProUGUI tx;
    private string g_text = "그래..무슨게임이 하고싶다고?";

    public GameObject ChatImg;

    private bool joonMoBabo = false;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && joonMoBabo == false)
        {
            joonMoBabo = true;

            ChatImg.SetActive(true);
            StartCoroutine(_typing());
        }
        
    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i <= g_text.Length; i++)
        {
            tx.text = g_text.Substring(0, i);
            yield return new WaitForSeconds(0.07f);
        }
    }

}
