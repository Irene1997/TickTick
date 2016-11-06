using Microsoft.Xna.Framework;

class Bomb : Rocket
{
    public Bomb(bool moveToLeft, Vector2 startPosition, Vector2 levelSize) : base(moveToLeft, startPosition, levelSize)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Mirror = moveToLeft;
        this.startPosition = startPosition;
        this.levelSize = levelSize;
        Reset();
    }

    public override void Reset()
    {
        visible = false;
        position = startPosition;
        velocity = Vector2.Zero;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        visible = true;
        if (velocity.Y == 0)
        {
            velocity.X = 600;
        }
        if (Mirror)
        {
            this.velocity.X *= -1;
        }
        CheckCollision();

        // check if we are outside the screen
        Rectangle screenBox = new Rectangle(0, 0, (int)levelSize.X * 72, (int)levelSize.Y * 52);
        if (!screenBox.Intersects(this.BoundingBox))
        {
            Reset();
        }
    }

    public virtual void CheckCollision()
    {
        Player player = GameWorld.Find("player") as Player;
        if (CollidesWith(player) && visible && player.Velocity.Y <= velocity.Y)
        {
            player.Die(false);
        }
        if (CollidesWith(player) && visible && player.Velocity.Y > velocity.Y)
        {
            velocity.X = 0;
            velocity.Y = 600;
            player.Velocity = new Vector2(player.Velocity.X, -500);
        }
    }
}

