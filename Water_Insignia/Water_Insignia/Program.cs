using Raylib_cs;

// Fire emblemesque game

// create tilesystem
// make it so that characters can only move through the tiles and only a certain amount of tiles
// add different kinds of tiles that restrict or affect movement like water or forrest tiles
// add more characters with different movement types
// add music

// if I get this far, try to add enemies and add turns
// different weapon types/classes
// add weapon durability
// add stats and combat
// feebly attempt to make somewhat of an enemy AI

Raylib.InitWindow(600, 800, "Water Insignia");
Raylib.SetTargetFPS(60);

Texture2D AvatarImage = Raylib.LoadTexture("gremory.png");
int tileSize = 32;

while (!Raylib.WindowShouldClose())
{
    // Logik



    // Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawTexture(AvatarImage, 0, 0, Color.WHITE);

    for (int x = 0; x < Raylib.GetScreenWidth() / tileSize; x++)
    {
        Raylib.DrawLine(x * tileSize, 0, x * tileSize, Raylib.GetScreenHeight(), Color.BLACK);
    }
    for (int y = 0; y < Raylib.GetScreenHeight() / tileSize; y++)
    {
        Raylib.DrawLine(Raylib.GetScreenWidth(), y * tileSize, 0, y * tileSize, Color.BLACK);
    }


    // hielo
    Raylib.EndDrawing();
}