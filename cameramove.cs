using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    [SerializeField] Transform _target;
     void Start()
    {
        transform.parent = null;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (_target)
        {
            transform.position = _target.position;
        }
    }
}
