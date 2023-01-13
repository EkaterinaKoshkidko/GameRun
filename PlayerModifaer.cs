using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerModifaer : MonoBehaviour
{
    [SerializeField] int _weight;
    [SerializeField] int _height;

    float _wightMultiplayer = 0.0005f;
    float _heightMultiplayer = 0.01f;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;

    [SerializeField] Transform _colliderTransform;
    [SerializeField] AudioSource _audioSourseUp;
    [SerializeField] AudioSource _audioSourceDown;



    [SerializeField] AudioSource _dieSound;
   


    void Start()
    {
        SetWight(Progress.Instance.PlayerInfo.Wight);
        SetHeight(Progress.Instance.PlayerInfo.Height);

    }
    void Update()
    {
    
        float offsetY = _height * _heightMultiplayer + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);

        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplayer, 1);

    }

    public void AddWeight(int value)
    {
        _weight += value;
        UpdateWeight();
        if (value > 0)
        {
            _audioSourseUp.Play();
        }
        else
        {
            _audioSourceDown.Play();
        }

    }

    public void AddHeight(int value)
    {
        _height += value;
        if (value > 0)
        {
            _audioSourseUp.Play();

        }
        else
        {
            _audioSourceDown.Play();
        }


    }

    public void SetWight(int value)
    {
        _weight += value;
        UpdateWeight();
    }

    public void SetHeight(int value)
    {
        _height += value;

    }

    public void HitBarrier()
    {
        if (_height > 0)
        {
            _height -= 50;


        }
        else if (_weight > 0)
        {
            _weight -= 50;
            UpdateWeight();


        }
        else
        {
           
            _dieSound.Play();

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);



        }

    }
    void UpdateWeight()
    {
        _renderer.material.SetFloat("_PushValue", _weight * _wightMultiplayer);
    }


  
}