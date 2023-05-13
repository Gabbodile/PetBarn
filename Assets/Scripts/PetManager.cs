using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : GameBehaviour<PetManager>
{
    public enum Gamemode { Default, Washing, Feeding, Playing, Hunting }
    public Gamemode gamemode;
    public GameObject[] cameras;

    [Header("GameObjects")]
    public GameObject pong;
    public GameObject pet;

    void Start()
    {
        ChangeCameras();
        pong.SetActive(false);
    }

    void Update()
    {
        if (gamemode == Gamemode.Default)
        {
            pet.SetActive(true);
            pong.SetActive(false);
        }
        if (gamemode == Gamemode.Washing)
            pet.SetActive(false);
        if (gamemode == Gamemode.Feeding)
            pet.SetActive(false);
        if (gamemode == Gamemode.Playing)
            pet.SetActive(false);
    }

    public void DefaultCam()
    {
        ChangeGamemode(Gamemode.Default);
    }
    public void WashCam()
    {
        ChangeGamemode(Gamemode.Washing);
    }

    public void FeedCam()
    {
        ChangeGamemode(Gamemode.Feeding);
    }

    public void PlayCam()
    {
        ChangeGamemode(Gamemode.Playing);
        pong.SetActive(true);
    }

    public void HuntingCam()
    {
        ChangeGamemode(Gamemode.Hunting);
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
