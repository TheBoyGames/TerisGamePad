using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject cube;

    public int cubeCount = 1;

    // 10 * 12 cubes
    public void SpawnCubes()
    {
        Instantiate (cube, new Vector3(4.0f, 0f, 0f), Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
