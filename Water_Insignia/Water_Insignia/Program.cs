using Raylib_cs;

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
    Raylib.DrawTexture(AvatarImage, 0, 32, Color.WHITE);

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