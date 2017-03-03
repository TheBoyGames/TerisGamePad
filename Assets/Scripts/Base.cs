using System;
using UnityEngine;

public abstract class Base
{
    protected GameManager gameManager;
        
    public  Base()
    {
        gameManager = GameObject.FindObjectOfType (typeof(GameManager)) as GameManager;
        if (null == gameManager)
        {
            gameManager = new GameManager ();
        }
    }

}

