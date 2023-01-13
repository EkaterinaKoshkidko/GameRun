using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;
public class GameManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string ShowAdv();


    [SerializeField] GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] Coin_manager _coin_Manager;
 



 
    private void Start()
    {
#if UNITY_WEBGL
        ShowAdv();
#endif
        _levelText.text = SceneManager.GetActiveScene().name;
       


    }
    public void Play()
    {
#if UNITY_WEBGL
        Progress.Instance.Save();
#endif
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehafiour>().Play();
     


    }

    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }
    public void NextLevel()
    {

        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coin_Manager.SaveToProgress();

            Progress.Instance.PlayerInfo.Level = SceneManager.GetActiveScene().buildIndex;

            Progress.Instance.Save();

            SceneManager.LoadScene(next);
        }
    }
    


    }
   


