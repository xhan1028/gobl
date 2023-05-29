using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControl : MonoBehaviour
{
    float RouletteSpeed = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.RouletteSpeed = 300;
        }

        transform.Rotate(0, 0, this.RouletteSpeed);

        this.RouletteSpeed *= 0.96f;
    }
}
