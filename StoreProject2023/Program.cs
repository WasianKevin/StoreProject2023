using Raylib_cs;
using System.Threading;


//Gör en skärm
Raylib.InitWindow(1202, 800, "The Grand Ben Market");
Raylib.SetTargetFPS(30);


//Strings, Bools etc.
string room = "menu";
int Cash = 10000;
int x = 0;

int Bandanadas = 0;
int Bendejos = 0;
int HappilyMealus = 0;
int FruitToppers = 0;
int Tango = 0;
int PEPSIMAX = 0;


//Alla bilder i spelet
Texture2D Home = Raylib.LoadTexture("MenuGBM.png");
Texture2D Kassa = Raylib.LoadTexture("Kassa.png");
Texture2D Buy = Raylib.LoadTexture("Purchase1.png");
Texture2D Arrow = Raylib.LoadTexture("arrow.png");
Texture2D Bananas = Raylib.LoadTexture("Bananas.png");
Texture2D Ben = Raylib.LoadTexture("Ben.png");
Texture2D HappyMeal = Raylib.LoadTexture("SadMeal.png");
Texture2D FT = Raylib.LoadTexture("FT.png");
Texture2D Tama = Raylib.LoadTexture("Egg.png");
Texture2D PM = Raylib.LoadTexture("Bepsi.png");




while (!Raylib.WindowShouldClose())
{
    //Start Screen
    if (room == "menu") (room, Home) = Menu.HomeMenu(room, Home);

    //Start Screen
    if (room == "Purchase") (Cash, x, room, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX) = BuyThings.Purrchase(Cash, x, room, Buy, Bananas, Arrow, Ben, HappyMeal, FT, Tama, PM, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX);

    //Stats
    if (room == "Kassa") (room, Kassa, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX, Cash) = Stats.Statistics(room, Cash, Kassa, Bandanadas, Bendejos, HappilyMealus, FruitToppers, Tango, PEPSIMAX);
}