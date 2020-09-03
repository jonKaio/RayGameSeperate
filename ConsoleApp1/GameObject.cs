using Raylib;
using rl = Raylib.Raylib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GameObject
    {
        public Vector2 pos=new Vector2(100,100);
        public Vector2 size=new Vector2(0,0);
        public Vector2 movePerSecond = new Vector2(10, 0);
        public float rotation = 0f;
        static public  bool debug = false;

        public virtual void Move()
        {
            pos += movePerSecond * rl.GetFrameTime();
        }
    }
}
