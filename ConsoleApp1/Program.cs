using Raylib;

using System;

using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    static class Program
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            int screenWidth = 800;
            int screenHeight = 450;

            rl.InitWindow(screenWidth, screenHeight, "Invaders");
          // GameObject.debug = true;


            SpriteBank myBank = new SpriteBank();
            int spriteNum = myBank.AddTexture(@"Resources\shipBeige_manned1.png");
            int spriteNum2 = myBank.AddTexture(@"Resources\shipBeige_manned2.png");
            GameObject[] row = new Invader[5];
            for (int i=0; i<5; i++)
            {
                row[i]= new Invader(myBank, 1, new Vector2(100+75*i , 100), spriteNum, spriteNum2);
            }
            rl.SetTargetFPS(60);
            //-------------------------

            // Main game loop
            while (!rl.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //-----------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                rl.BeginDrawing();

                rl.ClearBackground(Color.BLACK);
                foreach (Invader inv in row)
                {
                    inv.Move();
                    inv.Draw();
                }
               

                rl.EndDrawing();
                //-----------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            rl.CloseWindow();        // Close window and OpenGL context
                                     //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}
