using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalscennetrigger : MonoBehaviour
{
    [SerializeField] Animator _animatorTribun;

    private void OnTriggerEnter(Collider other)
    {
        PlayerBehafiour playerBehafiour = other.attachedRigidbody.GetComponent<PlayerBehafiour>();
        if (playerBehafiour)
        {
            _animatorTribun.SetTrigger("DanceTribun");
            playerBehafiour.StartPreFinishBefavior();
        }
    }
}
