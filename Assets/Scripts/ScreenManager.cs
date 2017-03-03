using System;
using UnityEngine;

public class ScreenManager : Base
{
    // this manager should setup the screen and manage the draw cube in the screen
    private int borderCubeWidthCount;
    private int  borderCubeHeightCount;

    public ScreenManager()
    {
        SetUp ();
    }

    private void SetUp()
    {
        SetUpBorder ();
        Debug.Log ("init screnManager");
    }

    private void SetUpBackground()
    {
        int width = gameManager.cubeWidthCount;
        int height = gameManager.cubeHeightCount;

        for (int i = width / 2 * -1; i < width / 2 - 1; i++) 
        {
            for (int n = height / 2 * -1; n < gameManager.cubeHeightCount; n++)
            {
            }
        }
    }

    private void SetUpBorder()
    {
        float borderWidth = gameManager.bgCubeWidth * gameManager.cubeWidthCount + 2 * gameManager.borderCubeWidth;
        borderCubeWidthCount = (int) (borderWidth / gameManager.borderCubeWidth);

        float borderHeight = gameManager.bgCubeHeight * gameManager.cubeHeightCount + 2 * gameManager.borderCubeHeight;
        borderCubeHeightCount = (int) (borderHeight / gameManager.borderCubeHeight);

        for (int i = borderCubeWidthCount / 2 * -1; i < borderCubeWidthCount / 2 - 1; i++)
        {
            for (int n = borderCubeHeightCount / 2 * -1; n < borderCubeHeightCount / 2 - 1; n++)
            {
                if(i == borderCubeWidthCount / 2 * -1 || i == borderCubeWidthCount / 2 - 2 ||　n == borderCubeHeightCount / 2 * -1 || n == borderCubeHeightCount / 2 - 2)
                {
                    Vector3 position = new Vector3 (i * gameManager.borderGapLengthRate, n * gameManager.borderGapLengthRate - gameManager.topPadding, 0.0f);
                    GameObject.Instantiate (gameManager.borderCube, position, Quaternion.identity); 
                }
            }
        }
    
    }

}

