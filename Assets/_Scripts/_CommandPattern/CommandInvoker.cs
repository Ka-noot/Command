using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputActions;
   

    void Start() 
    {
        inputActions = PlayerManager.instance.pc.inputAction;
        inputActions.Editor.IncreaseNum.performed += cntxt => IncreaseCommand();
        inputActions.Editor.DecreaseNum.performed += cntxt => DecreaseCommand();
    }
    public void IncreaseCommand()
    {
        ICommand firstCommand = new ScoreCommand();
        firstCommand.IncreaseNum();
    }
    public void DecreaseCommand()
    {
        ICommand firstCommand = new ScoreCommand();
        firstCommand.DecreaseNum();
    }
    void Update()
    {
        ICommand secondCommand = new ScoreCommand();
        secondCommand.Execute();
    }
}
