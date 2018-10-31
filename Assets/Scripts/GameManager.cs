using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;
    [SerializeField]
    int gameTime;

    [SerializeField]
    int gameScore;

    void Awake()
    {
        if (Instance = null)
            Instance = this;
    }

    public void ChangeScrore(int value)
    {
        gameScore += value;
    }
}
