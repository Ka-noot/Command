using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager controller;

    public PlayerAction inputAction;

    public GameObject player;
    /*private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }*/

    //start is called before the first frame update
    void Awake()
    {
        //instance
        if (controller == null)
        {
            controller = this;
        }
        inputAction = new PlayerAction();
    }
}
