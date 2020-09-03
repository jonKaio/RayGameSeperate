using System;
using System.Collections.Generic;
using System.Text;

using Raylib;

namespace ConsoleApp1
{
    class SpriteBank
    {
        public List<Texture2D> bank = new List<Texture2D>();
        public List<string> bankImgNames = new List<string>();
        public bool testing = true;
        public int spriteCounter = 0;
        public int AddTexture(string _imgName)
        {
            if (bankImgNames.Contains(_imgName))
            {
                return bankImgNames.IndexOf(_imgName);
            }
            Texture2D texture2D = Raylib.Raylib.LoadTexture(_imgName);
            if (texture2D.format == 0)
            {
                Console.WriteLine("Error loading texture");
                return -1;
            }
            bank.Add(texture2D);
            bankImgNames.Add(_imgName);
            return spriteCounter++;
        }
    }
}
