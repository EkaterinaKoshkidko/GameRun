using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrun : MonoBehaviour
{
    int Up_Down = 1;
    public int _speed;
    void Update()
    {
        gameObject.transform.Translate(0, _speed * Up_Down * Time.deltaTime, 0);
        if (gameObject.transform.position.y >= 10)
        {
            Up_Down = -1;

        }
        if (gameObject.transform.position.y <= -10)
        {
            Up_Down = 1;
        
        }
    }
}
