using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Language : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string GetLang();

    public string CurrentLanguage;// ru en tr
   
    public static Language Instance;
    void Awake()
    {
        if (Instance == null)
        {
           Instance = this;
            DontDestroyOnLoad(gameObject);

            CurrentLanguage = GetLang();
        
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
