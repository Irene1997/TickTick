using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


class Camera
{
    public Matrix transform;
    Viewport view;
    Vector2 centre;

    public Camera(Viewport newView)
    {
        view = newView;
    }

    public void Update(GameTime gameTime, Player player)
    {
        centre = new Vector2(player.Origin.X - 400, 0);
        transform = Matrix.CreateScale(new Vector3(1, 1, 0)) *
            Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y, 0));
    }

}

