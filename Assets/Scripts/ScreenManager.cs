using System;
using UnityEngine;

public class ScreenManager
{
    private int horizontalCubeCount;
    private int verticalCubeCount;
    private float gapPaddingRate;
    private float topPadding;
    
    public ScreenManager (int horizontalCubeCount, int verticalCubeCount, float gapPaddingRate, float topPadding)
    {
        this.horizontalCubeCount = horizontalCubeCount;
        this.verticalCubeCount = verticalCubeCount;
        this.gapPaddingRate = gapPaddingRate;
        this.topPadding = topPadding;
    }
}

