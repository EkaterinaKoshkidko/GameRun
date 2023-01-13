using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class manscript : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private float _oldmousepositionx;
    [SerializeField] private float _eu;
   
    [SerializeField] Animator _animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _oldmousepositionx=Input.mousePosition.x;
            _animator.SetBool("run", true);
        }
       
        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition=transform.position+transform.forward*Time.deltaTime*_speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f,2.5f);
            transform.position=newPosition;
            float deltax = Input.mousePosition.x - _oldmousepositionx;
            _oldmousepositionx = Input.mousePosition.x;
            _eu += deltax;
             _eu = Mathf.Clamp(_eu, -30, 30);
             transform.eulerAngles = new Vector3(0, _eu, 0);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("run", false);
        }

    }
        //if (Input.GetMouseButton(0))
        //{
        //  _oldmousepositionx = Input.mousePosition.x;
        // }
        // if (Input.GetMouseButton(0))
        //{
        //  Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
        //  newPosition.x = Mathf.Clamp(newPosition.x, -10f, 10f);

        //float deltax = Input.mousePosition.x - _oldmousepositionx;
        // _oldmousepositionx = Input.mousePosition.x;

        // _eu += deltax;
        // _eu = Mathf.Clamp(_eu, -70, 70);
        // transform.eulerAngles = new Vector3(0, _eu, 0);
    }
    

