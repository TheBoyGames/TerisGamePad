using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public GameObject cube;
    public int screenWidth;
    public int screenHeight;
    public float gapLengthRate;
    public float topPadding;

    public Coordinate GetCoordinate(int x, int y)
    {
        Coordinate coordinate = new Coordinate ();
        return coordinate;
    }

    // Cube count = screenHeight * screenHeight
    public void SpawnCubes()
    {
        for (int i = screenWidth / 2 * (-1); i < screenWidth / 2; i++) 
        {
            for (int n = screenHeight / 2 * (-1); n < screenHeight / 2; n++) 
            {
                Vector3 position = new Vector3 (i * gapLengthRate, n * gapLengthRate + topPadding, 0);
                Instantiate (cube, position, Quaternion.identity);    
            }
        }
    }

    // Use this for initialization
	void Start () {
        SpawnCubes ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BuildScreenLayout()
    {
        
    }
}

