using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Camera
{
    Vector2 position;
    int levelWidth;
    int screenWidth;

    public Camera()
    {
        position = Vector2.Zero;
        levelWidth = 2000;
        screenWidth = 1000;
    }

    public void StartPosition(int x, int y)
    {
        position.X = x;
        position.Y = y;
    }

    public void SetPosition(int x, int y)
    {
        if(x < screenWidth / 2)
        {
            position.X = screenWidth / 2;
        }
        else if(x > levelWidth - screenWidth / 2)
        {
            position.X = levelWidth - screenWidth / 2;
        }
        else
        {
            position.X = x;
        }
    }
}

