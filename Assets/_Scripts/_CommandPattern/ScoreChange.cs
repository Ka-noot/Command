using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreChange : MonoBehaviour
{
    public static ScoreChange instance;
    public static int score = 0;
   
    public static void ShowScore()
    {
        score++;
        UIManager.GetInstance().scoreDisplay.text = "Points= " + score;
        Debug.Log(score);
    }
    public static void ChangeScore()
    {
        score--;
        UIManager.GetInstance().scoreDisplay.text = "Points= " + score;
        Debug.Log(score);
    }
   
}
