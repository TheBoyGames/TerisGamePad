using System;
using UnityEngine;

public abstract class Base : MonoBehaviour
{
    protected GameManager gameManager;
        
    protected void Init()
    {
        gameManager = GameObject.FindObjectOfType ("GameManager");
        if (null == gameManager)
        {
            gameManager = new GameManager ();
        }
    }
}

