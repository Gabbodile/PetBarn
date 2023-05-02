using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPet : MonoBehaviour
{
    //This script customises player Colours
    public Renderer playerColour;
    public GameObject player;
    public GameObject UI;
    public Image UIColour;

    int colorValue;
    [SerializeField] Color newColour;
    [SerializeField] Color[] colours;

    void Start()
    {
        playerColour = player.GetComponent<Renderer>();
        UIColour = UI.GetComponent<Image>();
    }

    //Cycles through colours
    public void ChangeColour()
    {
        colorValue++;
        if (colorValue > 7)
        {
            colorValue = 0;
        }

        playerColour.material.color = colours[colorValue];
        UIColour.material.color = colours[colorValue];
    }
}
