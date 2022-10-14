using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCommand : ICommand
{
    
    public void Execute()
    {
       
    }
    public void IncreaseNum()
    {
        ScoreChange.AddScore();
    }

    public void DecreaseNum()
    {
        ScoreChange.SubtractScore();
    }
}
