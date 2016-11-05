using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    Viewport viewport;
    Vector2 centre, screen;
    public Vector2 offset;
    public Vector2 levelSize;

    public Camera(Viewport viewport, Vector2 levelSize)
    {
        this.viewport = viewport;
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
        this.levelSize = levelSize;
        screen = new Vector2(GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
    }

    //public void Update(GameTime gameTime, Player player)
    //{
    //    centre = player.Position;

    //    if (player.Position.X < viewport.Width / 2)
    //    {
    //        centre.X = viewport.Width / 2;
    //    }

    //    if (player.Position.X > /*(levelSize.X * 72) - (viewport.Width / 2) - 207*/viewport.Width * (levelScale.X - 0.5f))
    //    {
    //        centre.X = /*(levelSize.X * 72) - (viewport.Width / 2) - 207 */viewport.Width * (levelScale.X - 0.5f) - 207;
    //    }

    //    if (player.Position.Y < viewport.Height / 2)
    //    {
    //        centre.Y = viewport.Height / 2;
    //    }

    //    if (player.Position.Y > viewport.Height * (levelScale.Y - 0.5f))
    //    {
    //        centre.Y = viewport.Height * (levelScale.Y - 0.5f);
    //    }

    //    offset = (centre - new Vector2(viewport.Width / 2, viewport.Height / 2)) / 10;

    //}

    public void Update(GameTime gameTime, Player player)
    {
        centre = player.Position;

        if (player.Position.X < screen.X / 2 - 207)
        {
            centre.X = screen.X / 2 - 207;
        }

        if (player.Position.X > (levelSize.X * 72) - (screen.X / 2) - 207)
        {
            centre.X = (levelSize.X * 72) - (screen.X / 2) - 207;
        }

        if (player.Position.Y < screen.Y / 2 - 52)
        {
            centre.Y = screen.Y / 2 - 52;
        }

        if (player.Position.Y > (levelSize.Y * 52) - (screen.Y / 2) - 48)
        {
            centre.Y = (levelSize.Y * 52) - (screen.Y / 2) - 48;
        }

        offset = (centre - new Vector2(viewport.Width / 2, viewport.Height / 2)) / 10;

    }

    public void Reset()
    {
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
    }

}

