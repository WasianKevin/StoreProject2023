using System;
using Raylib_cs;

public class Menu
{

    public static (String, Texture2D) HomeMenu(String room, Texture2D Home)
    {

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(Home, 0, 0, Color.WHITE);

        //I switch room if i press ENTER
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) room = "Purchase";

        //I close the game with ESCAPE
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE)) System.Environment.Exit(0);

        Raylib.EndDrawing();
        return (room, Home);
    }
}