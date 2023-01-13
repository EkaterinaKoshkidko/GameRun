using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject _brickEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaer playerModifaer=other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playerModifaer) 
        {
            playerModifaer.HitBarrier();
            Destroy(gameObject);
            Instantiate(_brickEffectPrefab, transform.position, transform.rotation);
        }
    }
}
