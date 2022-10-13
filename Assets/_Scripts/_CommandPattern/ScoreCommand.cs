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
        ScoreChange.ChangeScore();
        Debug.Log("SECOND");
    }

    public void DecreaseNum()
    {
        ScoreChange.ShowScore();
        Debug.Log("SECOND");
    }
}
