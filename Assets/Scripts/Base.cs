using System;
using UnityEngine;

public abstract class Base: MonoBehaviour
{
    protected GameManager gameManager;
        
    protected void Awake()
    {
        gameManager = GameObject.FindObjectOfType (typeof(GameManager)) as GameManager;
        if (null == gameManager)
        {
            gameManager = new GameManager ();
        }
    }

}

