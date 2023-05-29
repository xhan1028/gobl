using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TItleMenu_Click : MonoBehaviour
{
    public AudioSource ClickTITLE;
    // Start is called before the first frame update
    public void click()
    {
        ClickTITLE.Play();
    }
}
