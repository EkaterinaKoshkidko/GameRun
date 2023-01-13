using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] AudioSource _win;
    [SerializeField] GameObject _winEffect;
    
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehafiour playerBehafiour = other.attachedRigidbody.GetComponent<PlayerBehafiour>();
        if (playerBehafiour)
        {
            _win.Play();
       
            Instantiate(_winEffect, transform.position, transform.rotation);
            playerBehafiour.StartFinishBefavior();
            FindObjectOfType<GameManager>().ShowFinishWindow();
         
        }
    }

}

