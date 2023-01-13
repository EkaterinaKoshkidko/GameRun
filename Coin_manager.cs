using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Runtime.InteropServices;

public class Coin_manager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string AddCoinsExtern(int value);

    public int NumberOfCoins;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] TextMeshProUGUI _text1;
    [SerializeField] GameObject _buttonAdv;
   
    private void Start()
    {
        NumberOfCoins = Progress.Instance.PlayerInfo.Coins;
        _text.text = NumberOfCoins.ToString();
        _text1.text = NumberOfCoins.ToString();
        transform.parent = null;
      
    

    }
    public void AddOne()
    {
        NumberOfCoins = Progress.Instance.PlayerInfo.Coins;
        NumberOfCoins += 1;
        _text.text = NumberOfCoins.ToString();
        _text1.text = NumberOfCoins.ToString();
       
     

    }

    public void SaveToProgress()
    {
        Progress.Instance.PlayerInfo.Coins = NumberOfCoins;
      

    }

    public void SpendMoney(int value)
    {
        NumberOfCoins -= value;
        _text.text = NumberOfCoins.ToString();
        _text1.text = NumberOfCoins.ToString();
    }
    public void ShowAdvButton()
    {
        AddCoinsExtern(100);
        _buttonAdv.SetActive(false);
        
    }
    public void AddCoins(int value)
    {
        NumberOfCoins = Progress.Instance.PlayerInfo.Coins;
        NumberOfCoins += value;
        _text.text = NumberOfCoins.ToString();
        _text1.text = NumberOfCoins.ToString();
        SaveToProgress();
     


    }
   
}

