using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrunz : MonoBehaviour
{
    int Up_Down = 1;
    public int _speed;
    void Update()
    {
        gameObject.transform.Translate(0,0,_speed * Up_Down * Time.deltaTime);
        if (gameObject.transform.position.z >= 10)
        {
            Up_Down = -1;

        }
        if (gameObject.transform.position.z <= -10)
        {
            Up_Down = 1;

        }
    }
}
