using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public GameObject cube;
    public GameObject bgCube;

    public int cubeWidthCount;
    public int cubeHeightCount;
    public float gapLengthRate;
    public float topPadding;
    public float cubeWidth;
    public float cubeHeight;
    public float bgCubeWidth;
    public float bgCubeHeight;

    private ScreenManager screenManager;

    // Use this for initialization
	void Start () 
    {

        screenManager = gameObject.AddComponent <ScreenManager>() as ScreenManager;

    }
	
	// Update is called once per frame
	void Update ()
    {
        screenManager.Draw ();
    }

    void FixUpdate()
    {
    }
}

