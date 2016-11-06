using Microsoft.Xna.Framework;

class Bomb : Rocket
{
    Vector2 playerPosition;

    public Bomb(bool moveToLeft, Vector2 startPosition, Vector2 levelSize) : base(moveToLeft, startPosition, levelSize)
    {
        id = "bomb";
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
        position = playerPosition;
        velocity = Vector2.Zero;
        this.Mirror = false;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        

        // check if we are outside the screen
        Rectangle screenBox = new Rectangle(0, 0, (int)levelSize.X * 72, (int)levelSize.Y * 52);
        if (!screenBox.Intersects(this.BoundingBox))
        {
            Reset();
        }
    }

    public Vector2 PlayerPosition
    {
        get { return playerPosition; }
        set { playerPosition = value; }
    }

    public void Shoot(bool playerMirror)
    {
        if (playerMirror)
        {
            this.Mirror = true;
        }

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
    }
        


    public override void CheckCollision()
    {

    }
}

