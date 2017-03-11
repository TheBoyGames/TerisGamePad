using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScreenManager : Base
{
    // this manager should setup the screen and manage the draw cube in the screen
    public  int[,] screen;

    private int screenWidth;
    private int screenHeight;

    private const int ENUM_BG = 0;
    private const int ENUM_CB = 1;
    private List<GameObject> cubeList = new List<GameObject>();

    public void DrawPoint()
    {
        screen [1, 3] = ENUM_CB;
    }

    public void TurnRight()
    {
        
    }

    public void Draw()
    {
        for (int i = 0; i < screenWidth; i++)
        {
            for (int n = 0; n < screenHeight; n++) 
            {
                int index = n * screenHeight + i;

                if (1 == screen [i, n])
                {
                    cubeList [index].SetActive (true);

                } else
                {
                    cubeList [index].SetActive (false);
                }
            }
        }
    }

    public IEnumerator DrawCoroutine()
    {
        for(int i = 0 ; i < cubeList.Count;i++)
        {
            cubeList [i].SetActive (true);
            yield return new WaitForSeconds(1);
        }
    }

    private void Awake()
    {
        base.Awake ();
        screenWidth = gameManager.cubeWidthCount;
        screenHeight = gameManager.cubeHeightCount;
        SetUp ();
    }

    private void Start()
    {
    }

    private void SetUp()
    {
        InitScreen ();
    }

    private void AddDot()
    {
        screen [10, 10] = ENUM_CB;
    }

    private void InitScreen()
    {
        screen = new int[screenWidth, screenHeight];

        for (int i = 0; i < screenWidth; i++) 
        {
            for (int n = 0; n < screenHeight; n++)
            {
                screen[i, n] = 0;
                Vector3 position = new Vector3 (i * gameManager.gapLengthRate, n * gameManager.gapLengthRate + gameManager.topPadding, 0.0f);
                GameObject.Instantiate (gameManager.bgCube, position, Quaternion.identity);
            }
        }

        for (int i = 0; i < screenWidth * screenHeight; i++) 
        {
            Vector3 position = GetPosition(i % screenWidth, i / screenWidth);
            GameObject cube = GameObject.Instantiate (gameManager.cube, position, Quaternion.identity);
            cube.SetActive (false);
            cubeList.Add (cube);
        }
    }

    private Vector3 GetPosition(int x, int y)
    {
        return new Vector3 (x * gameManager.gapLengthRate, y * gameManager.gapLengthRate + gameManager.topPadding, 0.0f);
    }
}

