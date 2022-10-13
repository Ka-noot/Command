using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCommand : ICommand
{
    Score _score;
   
    public ScoreCommand(Score score)
    {
        _score = score;
    }
    // Start is called before the first frame update
    public void Execute()
    {
        Score.PointDisplay();
    }
    public void IncreaseNum()
    {
        Score.ChangeScore();
    }
}
