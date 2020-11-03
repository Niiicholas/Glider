using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    private static GameManager instance;

    public bool GameStarted { get; private set; } = false;
    public int GameScore { get; private set; } = 0;


    public static GameManager Instance { 
        get {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }

    private GameManager() { }

}
