using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
 
    [SerializeField] Coin_manager _coinManager;
    PlayerModifaer _playerModifaer;


    [DllImport("__Internal")]
    private static extern void SetToLeaderboard(int value);
    void Start()
    {
        _playerModifaer=FindObjectOfType<PlayerModifaer>();
     
    }
    public void BuyWidth()
    { 
    if(_coinManager.NumberOfCoins>=150)
        {
                _coinManager.SpendMoney(150);
            Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.PlayerInfo.Wight += 25;
            _playerModifaer.SetWight(Progress.Instance.PlayerInfo.Wight);
        }
    
    }

    public void BuyHeight()
    {
        if (_coinManager.NumberOfCoins >= 150)
        {
            _coinManager.SpendMoney(150);
            Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
            Progress.Instance.PlayerInfo.Height += 25;

            SetToLeaderboard(Progress.Instance.PlayerInfo.Height);

            _playerModifaer.SetHeight(Progress.Instance.PlayerInfo.Height);
        }

    }
    public void BuyFinalLevel()
    {
        if (_coinManager.NumberOfCoins >= 0)
        {
            _coinManager.SpendMoney(0);
            SceneManager.LoadScene("Finish");

        }
        else
        {
            DieW();

        }

    }
    public void DieW()
    {
        SceneManager.LoadScene("Final Level");
    }
public void BuyLevel()
    {
        if (_coinManager.NumberOfCoins >= 0)
        {
            _coinManager.SpendMoney(0);
            Restart();

        }

    }
    public void Restart()
    {

        SceneManager.LoadScene("Level 1");
    
    }
}
