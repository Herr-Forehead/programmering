using Raylib_cs;

Raylib.InitWindow(800, 600, "Leonards crinch spel");
Raylib.SetTargetFPS(60);

Color royalBlue = new Color(85, 118, 209, 255);

Rectangle playerRect = new Rectangle(368, 268, 64, 64);

float speed = 5;


while (Raylib.WindowShouldClose() == false)
{
    // Logik

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        playerRect.x += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        playerRect.x -= speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        playerRect.y -= speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        playerRect.y += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    {
        playerRect.y += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
    {
        playerRect.x += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    {
        playerRect.y -= speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
    {
        playerRect.x -= speed;
    }


    // Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DARKPURPLE);

Raylib.DrawRectangleRec(playerRect, royalBlue);
    // Raylib.DrawRectangle(384, 284, 32, 32, royalBlue);

    Raylib.EndDrawing();
}