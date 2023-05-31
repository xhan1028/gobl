using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinChat : MonoBehaviour
{
    public GameObject ChatControllerObj;
    public GameObject ChatImg;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChatImg.SetActive(true);
            StartCoroutine(ChatControllerObj.GetComponent<ChatController>().TextPractice());
        }
    }
}
