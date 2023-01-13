using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] float _rotatespeed;
    [SerializeField] GameObject _effectPrefab;

    void Update()
    {
      transform.Rotate(0,_rotatespeed * Time.deltaTime, 0);
            
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Coin_manager>().AddOne();
 
        Destroy(gameObject);
        Instantiate(_effectPrefab,transform.position,transform.rotation);
    }
}
