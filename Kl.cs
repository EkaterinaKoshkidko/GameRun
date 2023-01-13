using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kl : MonoBehaviour
{
    [SerializeField] GameObject _adv;
    public void OpenAdv()
    {

        _adv.SetActive(true);
   

    }
    public void NoThanks()
    {
        _adv.SetActive(false);
       
    }
}
