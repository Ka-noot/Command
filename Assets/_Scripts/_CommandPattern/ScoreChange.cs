using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreChange : MonoBehaviour
{
    public static ScoreChange instance;
    public static int score = 0;
   
    public static void SubtractScore()
    {
        score--;
        UIManager.GetInstance().scoreDisplay.text = "Points= " + score;
        Debug.Log(score);
    }
    public static void AddScore()
    {
        score++;
        UIManager.GetInstance().scoreDisplay.text = "Points= " + score;
        Debug.Log(score);
    }
   
}
