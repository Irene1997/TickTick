using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    Viewport viewport;
    Vector2 centre;
    public Vector2 offset;
    public Vector2 levelScale, levelSize;

    public Camera(Viewport viewport, Vector2 levelScale, Vector2 levelSize)
    {
        this.viewport = viewport;
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
        this.levelScale = levelScale;
        this.levelSize = levelSize;
    }

    public void Update(GameTime gameTime, Player player)
    {
        centre = player.Position;

        if (player.Position.X < viewport.Width / 2)
        {
            centre.X = viewport.Width / 2;
        }

        if (player.Position.X > /*(levelSize.X * 72) - (viewport.Width / 2)*/viewport.Width * (levelScale.X - 0.5f))
        {
            centre.X = /*(levelSize.X * 72) - (viewport.Width / 2)*/viewport.Width * (levelScale.X - 0.5f);
        }

        if (player.Position.Y < viewport.Height / 2)
        {
            centre.Y = viewport.Height / 2;
        }

        if (player.Position.Y > viewport.Height * (levelScale.Y - 0.5f))
        {
            centre.Y = viewport.Height * (levelScale.Y - 0.5f);
        }

        offset = (centre - new Vector2(viewport.Width / 2, viewport.Height / 2))/10;

    }

    public void Reset()
    {
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
    }

}

