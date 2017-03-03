using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public GameObject cube;
    public GameObject bgCube;
    public GameObject borderCube;

    public int cubeWidthCount;
    public int cubeHeightCount;
    public float gapLengthRate;
    public float borderGapLengthRate;
    public float topPadding;
    public float cubeWidth;
    public float cubeHeight;
    public float bgCubeWidth;
    public float bgCubeHeight;
    public float borderCubeWidth;
    public float borderCubeHeight;

    private ScreenManager screenManager;

    public Coordinate GetCoordinate(int x, int y)
    {
        Coordinate coordinate = new Coordinate ();
        return coordinate;
    }

    // Use this for initialization
	void Start () {
        
        screenManager = new ScreenManager();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BuildScreenLayout()
    {
        
    }
}

