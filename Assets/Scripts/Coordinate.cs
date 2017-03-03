using System;
using UnityEngine;

public class Coordinate : Base
{
    public int x;
    public int y;

    private void Init()
    {
    }

    public Coordinate()
    {
        this.x = 0;
        this.y = 0;
    }

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

