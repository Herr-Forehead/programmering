using Raylib_cs;

Raylib.InitWindow(800, 600, "Leonards crinch spel");
Raylib.SetTargetFPS(60);

Color royalBlue = new Color(85, 118, 209, 255);
Color transparent = new Color(255, 255, 255, 0);

Texture2D avatarImage = Raylib.LoadTexture("stolencharacteravatar.png");
Texture2D bkgImage = Raylib.LoadTexture("actual_background.png");

Rectangle playerRect = new Rectangle(368, 268, avatarImage.width, avatarImage.height);
Rectangle trapRect = new Rectangle (700, 500, 64, 64);

float speed = 5.5f;

string currentScene = "start"; // start, game, end


while (Raylib.WindowShouldClose() == false)
{
    // Logik

    if (currentScene == "game")
    {
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

    if (Raylib.CheckCollisionRecs(playerRect, trapRect))
    {
        currentScene = "end";
    }
    }
    else if (currentScene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "game";
        }
    }

    // Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DARKPURPLE);

    if (currentScene == "game")
    {
     Raylib.DrawTexture(bkgImage, 0, 0, Color.WHITE);

     Raylib.DrawTexture(avatarImage,
          (int)playerRect.x, 
          (int)playerRect.y, 
          Color.WHITE);

     Raylib.DrawRectangleRec(trapRect, Color.RED);
    }
    else if (currentScene == "start")
    {

        Raylib.DrawText("press ENTER to start", 400, 300, 30, Color.GREEN);
    }
    else if (currentScene == "end")
    {
        Raylib.DrawText("you lost?, how crinch", 350, 250, 30, Color.GREEN);
    }


    // Raylib.DrawRectangleRec(playerRect, royalBlue);
    // Raylib.DrawRectangle(384, 284, 32, 32, royalBlue);

    Raylib.EndDrawing();
}