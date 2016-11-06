using Microsoft.Xna.Framework;

class Bomb : AnimatedGameObject
{
    protected Vector2 playerPosition, levelSize;

    public Bomb(Vector2 startPosition, Vector2 levelSize)
    {
        //initialize Bomb
        id = "bomb";
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        playerPosition = startPosition;
        this.levelSize = levelSize;
        Reset();
    }

    public override void Reset()
    {
        //reset visible, put position to current player position, speed to zero
        visible = false;
        position = playerPosition;
        velocity = Vector2.Zero;
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
        //reset, make visible, give speed, mirror if necessary
        Reset();
        visible = true;
        velocity.X = 600;
        if (playerMirror)
        {
            this.Mirror = true;
            this.velocity.X *= -1;
        }
        else
        {
            this.Mirror = false;
        }

    }
        
}

