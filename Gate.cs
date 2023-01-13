using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DevormationType _devormationType;
    [SerializeField] GateAppereance _getAppereanse;
    private void OnValidate()
    {
        _getAppereanse.UpdateVisual(_devormationType, _value);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaer playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playerModifaer!=null) {
            if (_devormationType == DevormationType.Wight)
            {
                playerModifaer.AddWeight(_value);
            }
            else if (_devormationType==DevormationType.Height) 
            {
                playerModifaer.AddHeight(_value);
            }
        }
        Destroy(gameObject);
    }
}
