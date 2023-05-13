using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomPet : MonoBehaviour
{
    //This script customises player Colours
    public Renderer playerColour;
    public GameObject player;
    public GameObject[] walls;

    int colorValue;
    [SerializeField] Color newColour;
    [SerializeField] Color[] colours;

    void Start()
    {
        playerColour = player.GetComponent<Renderer>();
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

    }

    public void ChangeWallColour()
    {
        colorValue++;
        if (colorValue > 8)
        {
            colorValue = 0;
        }

        foreach (GameObject walls in walls)
            walls.GetComponent<Renderer>().sharedMaterial.color = colours[colorValue];
    }
}
