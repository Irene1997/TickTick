using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    //public Matrix transform;
    Viewport viewport;
    Vector2 centre;
    public Vector2 offset;
    Vector2 levelScale;

    public Camera(Viewport viewport, Level level)
    {
        this.viewport = viewport;
        centre = new Vector2(viewport.Width / 2, viewport.Height / 2);
        levelScale = level.levelScale;
    }

    public void Update(GameTime gameTime, Player player)
    {
        if ((player.Position.X < centre.X && player.Position.X > viewport.Width / 2) || (player.Position.X > centre.X && player.Position.X < viewport.Width * (levelScale.X - 0.5f)))
        {
            centre.X = player.Position.X;
        }



        if ((player.Position.Y < centre.Y && player.Position.Y > viewport.Height / 2) || (player.Position.Y > centre.Y && player.Position.Y < viewport.Height * (levelScale.Y - 0.5f)))
        {
            centre.Y = player.Position.Y;
        }



        offset = centre - new Vector2(viewport.Width / 2, viewport.Height / 2);

        //centre = new Vector2(player.Origin.X - 400, 0);
        //transform = Matrix.CreateScale(new Vector3(1, 1, 0)) *
        //    Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y, 0));
    }

}

