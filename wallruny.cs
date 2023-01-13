using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallruny : MonoBehaviour
{
    int Up_Down = 1;
    public int _speed;
    void Update()
    {
        gameObject.transform.Translate( _speed * Up_Down * Time.deltaTime,0, 0);
        if (gameObject.transform.position.x >= 10)
        {
            Up_Down = -1;

        }
        if (gameObject.transform.position.x <= -10)
        {
            Up_Down = 1;

        }
    }
}
