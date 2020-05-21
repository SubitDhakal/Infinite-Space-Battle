using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighestScore : MonoBehaviour
{

   
    Text scoreText;
    Text highestScore;
    GameSession gameSession;


    // Start is called before the first frame update
    void Start()
    {
      
        highestScore = GetComponent<Text>();
        highestScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();
      
        gameSession = FindObjectOfType<GameSession>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameSession.GetScore()>PlayerPrefs.GetInt("highScore",0))
        {
           PlayerPrefs.SetInt("highScore", gameSession.GetScore());
            highestScore.text = gameSession.GetScore().ToString();
        }

    }
}
