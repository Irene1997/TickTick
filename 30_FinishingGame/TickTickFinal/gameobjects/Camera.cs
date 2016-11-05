﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    Vector2 centre, screen;
    public Vector2 offset, levelSize;

    public Camera(Vector2 levelSize)
    {
        screen = new Vector2(GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
        centre = new Vector2(screen.X / 2, screen.Y / 2);
        this.levelSize = levelSize;
        
    }

    public void Update(GameTime gameTime, Player player)
    {
        centre = player.Position;

        if (player.Position.X < screen.X / 2)
        {
            centre.X = screen.X / 2;
        }

        if (player.Position.X > (levelSize.X * 72) - (screen.X / 2))
        {
            centre.X = (levelSize.X * 72) - (screen.X / 2);
        }

        if (player.Position.Y < screen.Y / 2)
        {
            centre.Y = screen.Y / 2;
        }

        if (player.Position.Y > (levelSize.Y * 55) - (screen.Y / 2))
        {
            centre.Y = (levelSize.Y * 55) - (screen.Y / 2);
        }

        offset = (centre - new Vector2(screen.X / 2, screen.Y / 2)) / 10;

    }

    public void Reset()
    {
        centre = new Vector2(screen.X / 2, screen.Y / 2);
    }

}

