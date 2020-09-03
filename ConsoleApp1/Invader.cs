using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Invader : Sprite
    {
        public float cTime = 0;
        public float moveRate=1f;
        public Invader(SpriteBank _bank, float _interval, Raylib.Vector2 _pos, params int[] _index) : base( _bank,  _interval,  _pos, _index)
        { 
        }

        public override void Move()
        {
            cTime += Raylib.Raylib.GetFrameTime();
            if (cTime > 1 / moveRate)
            {
                cTime = 0;
                pos += movePerSecond;
            }

        }

    }
}
