using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty { Easy, Medium, Hard }
public enum GameState { Title, Playing, Pause }
public class GameManager : GameBehaviour<GameManager>
{
    public Difficulty difficulty;
    public GameState gameState;

    void Start()
    {
        
    }

     void Update()
     {
        switch (gameState)
        {
            case GameState.Title:
                break;

            case GameState.Playing:
                break;

            case GameState.Pause:
                break;
        }
    }

}
