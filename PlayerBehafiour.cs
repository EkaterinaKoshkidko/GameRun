using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehafiour : MonoBehaviour
{
    [SerializeField] manscript _playerMove;
    [SerializeField] PreFinishBehafior _preFinishBehafior;
    [SerializeField] Animator _animator;
  

   
    void Start()
    {
        _playerMove.enabled = false;
        _preFinishBehafior.enabled= false;
    }
   
    public void Play()
    {
        
        _playerMove.enabled = true;
       
    }
    public void StartPreFinishBefavior() 
    { 
    _playerMove.enabled = false;   
        _preFinishBehafior.enabled = true;
    }
    public void StartFinishBefavior ()
    {
        _preFinishBehafior.enabled = false;
        _animator.SetTrigger("Dance");
    }

}
