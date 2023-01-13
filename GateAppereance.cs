using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public enum DevormationType
{
    Wight,
    Height
}
public class GateAppereance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _imageTop;
    [SerializeField] Image _imageGlass;

    [SerializeField] Color _colorPozitive;
    [SerializeField] Color _colorNegative;

 

    [SerializeField] GameObject _expendLabel;
    [SerializeField] GameObject _shrinkLabel;
    [SerializeField] GameObject _upLabel;
    [SerializeField] GameObject _downLabel;

    // Update is called once per frame
    public void UpdateVisual(DevormationType devormationType,int value)
    {
        string prefix = "";

      
        if (value > 0)
        {
            prefix = "+";
            SetColor(_colorPozitive);
        }
        else if (value==0)
        {
            SetColor(Color.grey);
        }
        else
        {
            SetColor(_colorNegative);
        }
        _text.text = prefix + value.ToString();

        _expendLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);
        if (devormationType == DevormationType.Wight)
        {
            if (value > 0)
            {
                _expendLabel.SetActive(true);
            }
            else 
            {
                _shrinkLabel.SetActive(true);
            }
        }
        else if(devormationType==DevormationType.Height) 
        {
            if (value > 0)
            {
                _upLabel.SetActive(true);
            }
            else
            {
                _downLabel.SetActive(true);
            }
        }

        void SetColor(Color color)
        {
        _imageTop.color = color;
            _imageGlass.color = new Color(color.r, color.g, color.b, 0.5f);
        }
    
    }
}

