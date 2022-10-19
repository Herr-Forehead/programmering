using Raylib_cs;

Raylib.InitWindow(800, 600, "Leonards crinch spel");
Raylib.SetTargetFPS(60);

Color royalBlue = new Color(85, 118, 209, 255);
Color transparent = new Color(255, 255, 255, 0);

Rectangle playerRect = new Rectangle(368, 268, 64, 64);
Texture2D avatarImage = Raylib.LoadTexture("test_character.png");

float speed = 5;


while (Raylib.WindowShouldClose() == false)
{
    // Logik

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
    {
        playerRect.x += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
    {
        playerRect.x -= speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    {
        playerRect.y -= speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    {
        playerRect.y += speed;
    }


    // Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DARKPURPLE);

    Raylib.DrawTexture(avatarImage,
     (int)playerRect.x, 
     (int)playerRect.y, 
     Color.WHITE);

    // Raylib.DrawRectangleRec(playerRect, royalBlue);
    // Raylib.DrawRectangle(384, 284, 32, 32, royalBlue);

    Raylib.EndDrawing();
}