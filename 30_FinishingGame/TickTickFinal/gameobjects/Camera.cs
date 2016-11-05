using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    Viewport viewport;
    Vector2 centre;
    public Vector2 offset;
    public Vector2 levelScale;

    public Camera(Viewport viewport, Vector2 levelScale)
    {
        this.viewport = viewport;
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
        this.levelScale = levelScale;
    }

    public void Update(GameTime gameTime, Player player)
    {
        centre = player.Position;

        if (player.Position.X < viewport.Width / 2)
        {
            centre.X = viewport.Width / 2;
        }

        if (player.Position.X > viewport.Width * (levelScale.X - 0.5f))
        {
            centre.X = viewport.Width * (levelScale.X - 0.5f);
        }

        if (player.Position.Y < viewport.Height / 2)
        {
            centre.Y = viewport.Height / 2;
        }

        if (player.Position.Y > viewport.Height * (levelScale.Y - 0.5f))
        {
            centre.Y = viewport.Height * (levelScale.Y - 0.5f);
        }

        offset = centre - new Vector2(viewport.Width / 2, viewport.Height / 2);



    /*    foreach(thing as things)
        {
            if(thing.layer = 0)
            {

            }
            else if (thing.layer = 1)
            {

            }
            else if (thing.layer = 2)
            {

            }
            else
            {

            }
        }*/

    }

    public void Reset()
    {
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
    }

}

