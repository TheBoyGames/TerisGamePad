using System;
using UnityEngine;

public class Coordinate : Base
{
    public int x;
    public int y;

    private void Init()
    {
        base.Init ();
    }

    public Coordinate()
    {
        this.x = 0;
        this.y = 0;
        Init ();
    }

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
        Init ();
    }
}

