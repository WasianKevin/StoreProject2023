using System;
using Raylib_cs;

public class Stats
{
    public static (String, Texture2D, int, int, int, int, int, int, int) Statistics(String room, int Cash, Texture2D Kassa, int Bandanadas, int Bendejos, int HappilyMealus, int FruitToppers, int Tango, int PEPSIMAX)
    {

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(Kassa, 0, 0, Color.WHITE);



        Raylib.DrawText($"Bananas: {Bandanadas}.", 400, 250, 30, Color.BLACK);
        Raylib.DrawText($"Ben: {Bendejos}.", 400, 300, 30, Color.BLACK);
        Raylib.DrawText($"Happy Meals: {HappilyMealus}.", 400, 350, 30, Color.BLACK);
        Raylib.DrawText($"Frukt Toppar: {FruitToppers}.", 400, 400, 30, Color.BLACK);
        Raylib.DrawText($"Eggs: {Tango}.", 400, 450, 30, Color.BLACK);
        Raylib.DrawText($"Pepsi Max: {PEPSIMAX}.", 400, 500, 30, Color.BLACK);


        //I switch room if i press ENTER
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            room = "Purchase";
            Cash = 10000;
            Bandanadas = 0;
            Bendejos = 0;
            HappilyMealus = 0;
            FruitToppers = 0;
            Tango = 0;
            PEPSIMAX = 0;
        }


        //I close the game with ESCAPE
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE)) System.Environment.Exit(0);


        Raylib.EndDrawing();
        return (room, Kassa, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX, Cash);
    }
}

