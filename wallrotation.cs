using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrotation : MonoBehaviour
{
    public int _rotatespeed;
    void Update()
    {
        transform.Rotate(0, _rotatespeed * Time.deltaTime, 0);

    }
}

