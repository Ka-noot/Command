using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputActions;
    Score _score;

    
    // Start is called before the first frame update
    void Start()
    {
        inputActions = PlayerManager.controller.inputAction;
        Debug.Log(inputActions);
        inputActions.Editor.IncreaseNum.performed += cntxt => IncreaseCommand();
        inputActions.Editor.NewAction.performed += cntxt => Debug.Log("NEw Action");
    }
    public void IncreaseCommand()
    {
        Debug.Log("BUTTONPRESS");
        ICommand secondCommand = new ScoreCommand(_score);
        secondCommand.IncreaseNum();
    }
  
    // Update is called once per frame
    void Update()
    {
        ICommand mainCommand = new ScoreCommand(_score);
        mainCommand.Execute();
    }
}
