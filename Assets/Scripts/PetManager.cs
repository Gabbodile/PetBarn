using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : GameBehaviour<PetManager>
{
    public enum Gamemode { Default, Washing, Feeding, Playing }
    public Gamemode gamemode;
    public GameObject[] cameras;

    void Start()
    {
        ChangeCameras();
    }
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeGamemode(Gamemode.Default);
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeGamemode(Gamemode.Washing);
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeGamemode(Gamemode.Feeding);
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
            ChangeGamemode(Gamemode.Playing);
    }

    public void ChangeGamemode(Gamemode gm)
    {
        gamemode = gm;
        ChangeCameras();
    }

    public void ChangeCameras()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
        cameras[(int)gamemode].gameObject.SetActive(true);
    }

}
