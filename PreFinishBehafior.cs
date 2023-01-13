using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehafior : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * 4f);
        float z=transform.position.z+6f*Time.deltaTime;
        transform.position= new Vector3(x,0,z);

        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
        transform.localEulerAngles=new Vector3(0,rot, 0);
    }
}
