using Raylib;

using System;
using System.Collections.Generic;
using System.Text;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    class Sprite : GameObject
    {
        public SpriteBank spriteBank;
        public int[] spriteIndex;
        public float interval;
        int currentFrame = 0;
        public Sprite() { }

        /// <summary>
        /// Create a sprite that can be drawn on screen, this sprite can
        /// automatically animate between different textures in a sprite bank.
        /// those textures are identifies using indexes from the spritebank array.
        /// </summary>
        /// <param name="_bank">The sprite bank that contains all the individual textures to be used</param>
        /// <param name="_interval">The framerate of the animation</param>
        /// <param name="_index">The indexes of the various sprites to animate.</param>
        public Sprite(SpriteBank _bank, float _interval, Vector2 _pos, params int[] _index)
        {
            spriteIndex = new int[_index.Length];
            interval = _interval;
            spriteBank = _bank;
            pos = _pos;
            for (int i = 0; i < _index.Length; i++)
                spriteIndex[i] = _index[i];
        }
        float cTime = 0;
        /// <summary>
        /// Responsible for drawing and animating the sprites at the given frame rate
        /// </summary>
        public void Draw()
        {
            cTime += Raylib.Raylib.GetFrameTime();

            if (cTime > 1 / interval)
            {
                cTime = 0;
                currentFrame++;
            }

            if (currentFrame == spriteIndex.Length)
                currentFrame = 0;

            Texture2D tmp = spriteBank.bank[spriteIndex[currentFrame]];
            size = new Vector2(tmp.width, tmp.height) * .5f;
            rl.DrawTexturePro(tmp,
                new Rectangle(0, 0, tmp.width, tmp.height),
                new Rectangle(pos.x - size.x / 2, pos.y - size.y / 2, size.x, size.y), new Vector2(.5f, .5f), rotation, Raylib.Color.WHITE);
            if (debug)
                rl.DrawCircleV(pos, 5, Color.RED);
        }
    }
}
