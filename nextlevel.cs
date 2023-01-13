using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    [SerializeField] Coin_manager _coinManager;
    [SerializeField] GameObject _dieWindow;
    [SerializeField] Shop _shop;
    private void Start()
    {
        _dieWindow.SetActive(false);
    }
    public void BuyFinalLevel()
    {
        if (_coinManager.NumberOfCoins >= 100)
        {
            _coinManager.SpendMoney(100);

        }
        else
        {
            DieW();
        
        }
        
    }
    public void DieW()
    {
        _dieWindow.SetActive(true);
 
    }
}
