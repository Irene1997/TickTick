using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bom : Rocket
{
    public Rocket(bool moveToLeft, Vector2 startPosition, Vector2 levelSize)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Mirror = moveToLeft;
        this.startPosition = startPosition;
        this.levelSize = levelSize;
        Reset();
    }
}

