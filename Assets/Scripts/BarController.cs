using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarController : GameBehaviour<BarController>
{
    public TMP_Text valueText;
    int bar = 100;
    public Slider slider;

    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }

    public void BarProgress()
    {
        slider.value = bar;
    }
}
