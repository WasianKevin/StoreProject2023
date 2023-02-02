using System;
using Raylib_cs;

public class BuyThings
{

    int Cash = 2500;
    int x = 0;


    public static (int, int, string, int, int, int, int, int, int) Purrchase(int Cash, int x, string room, Texture2D Buy, Texture2D Bananas, Texture2D Arrow, Texture2D Ben, Texture2D HappyMeal, Texture2D FT, Texture2D Tama, Texture2D PM, int Bandanadas, int Bendejos, int HappilyMealus, int FruitToppers, int Tango, int PEPSIMAX)
    {

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(Buy, 0, 0, Color.WHITE);

        Raylib.DrawText($"You have ${Cash}.", 10, 5, 30, Color.BLACK);



        Raylib.DrawText($"Press ENTER to finish purchasing!", 600, 760, 30, Color.BLACK);


        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) room = "Kassa";



        //Draw Banana and Banana Price
        Raylib.DrawTexture(Bananas, 70, 60, Color.WHITE);
        Raylib.DrawText("$250", 100, 330, 30, Color.BLACK);

        //Press Q to purchase Banana
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
        {
            Raylib.SetTargetFPS(30);
            x = 250;

            if (Cash >= 0) Bandanadas += 1;
            Cash -= x;
        }



        //Draw Ben and Ben Price
        Raylib.DrawTexture(Ben, 480, 85, Color.WHITE);
        Raylib.DrawText("$3000", 480, 330, 30, Color.BLACK);

        //Press Q to purchase Ben
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
        {
            Raylib.SetTargetFPS(30);
            x = 3000;

            Cash -= x;

            if (Cash >= 0) Bendejos += 1;
        }






        //Draw Happy Meal and Happy Meal Price
        Raylib.DrawTexture(HappyMeal, 825, 150, Color.WHITE);
        Raylib.DrawText("$15", 850, 330, 30, Color.BLACK);

        //Press Q to purchase Happy Meal
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
        {
            Raylib.SetTargetFPS(30);
            x = 15;

            if (Cash >= 0) HappilyMealus += 1;
            Cash -= x;
        }




        //Draw Frukt Toppar and Frukt Toppar Price
        Raylib.DrawTexture(FT, 70, 430, Color.WHITE);
        Raylib.DrawText("$30", 100, 690, 30, Color.BLACK);

        //Press Q to purchase Frukt Toppar
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
        {
            Raylib.SetTargetFPS(30);
            x = 30;

            if (Cash >= 0) FruitToppers += 1;
            Cash -= x;
        }





        //Draw Egg and Egg Price
        Raylib.DrawTexture(Tama, 473, 430, Color.WHITE);
        Raylib.DrawText("$5", 480, 690, 30, Color.BLACK);

        //Press Q to purchase Egg
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
        {
            Raylib.SetTargetFPS(30);
            x = 5;

            if (Cash >= 0) Tango += 1;
            Cash -= x;
        }






        //Draw Pepsi Max and Pepsi Max Price
        Raylib.DrawTexture(PM, 850, 430, Color.WHITE);
        Raylib.DrawText("$1", 850, 690, 30, Color.BLACK);

        //Press Q to purchase Pepsi Max
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
        {
            Raylib.SetTargetFPS(30);
            x = 1;

            if (Cash >= 0) PEPSIMAX += 1;
            Cash -= x;
        }









        while (Cash <= -1)
        {
            Raylib.SetTargetFPS(5);
            Raylib.DrawTexture(Arrow, 175, 40, Color.WHITE);
            Cash += x;
        }

        Raylib.EndDrawing();

        return (Cash, x, room, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX);
    }
}