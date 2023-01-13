using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        PlayerBehafiour playerBehafiour= other.attachedRigidbody.GetComponent<PlayerBehafiour>();
        if (playerBehafiour) 
        { 
        playerBehafiour.StartPreFinishBefavior();
        }
    }
}
