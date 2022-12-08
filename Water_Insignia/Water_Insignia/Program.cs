using Raylib_cs;

// Fire emblemesque game

// create tilesystem
// make it so that characters can only move through the tiles and only a certain amount of tiles
// add different kinds of tiles that restrict or affect movement like water or forrest tiles
// add more characters with different movement types
// add music

// if I get this far, try to add enemies and add turns
// different weapon types and character classes
// add weapon durability
// add stats and combat
// feebly attempt to make somewhat of an enemy AI

Raylib.InitWindow(600, 800, "Water Insignia");
Raylib.SetTargetFPS(60);
Raylib.InitAudioDevice();

Texture2D AvatarImage = Raylib.LoadTexture("gremory.png");
Rectangle AvatarRect = new Rectangle(0, 0, AvatarImage.width, AvatarImage.height);
Texture2D EnemyImage = Raylib.LoadTexture("Barbarossa.png");
Rectangle EnemyRect = new Rectangle(0, 768, EnemyImage.width, EnemyImage.height);
int tileSize = 32;
string currentScene = "start";
int plrInfantryMov = 2;
int nmyFlyingMov = 5;
Music MainTheme = Raylib.LoadMusicStream("MainTheme.mp3");
Music ChasingDaybreak = Raylib.LoadMusicStream("ChasingDaybreak.mp3");
Music HeritorsOfArcadia = Raylib.LoadMusicStream("HeritorsOfArcadia.mp3");

while (!Raylib.WindowShouldClose())
{
    // Logik

    if (currentScene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "plrTurn";
        }
    }
    else if (currentScene == "plrTurn")
    {
        if (plrInfantryMov >= 0)
        {
            if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
            {
                AvatarRect.x += 32;
                plrInfantryMov--;
                if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
                {
                    AvatarRect.x -= 32;
                    plrInfantryMov++;
                }
            }
            else if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
            {

                AvatarRect.x -= 32;
                plrInfantryMov--;
            }
            else if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
            {
                AvatarRect.y -= 32;
                plrInfantryMov--;
            }
            else if (Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN))
            {
                AvatarRect.y += 32;
                plrInfantryMov--;
            }

            if (Raylib.CheckCollisionRecs(AvatarRect, EnemyRect))
            {
                currentScene = "gameOver";
            }

        }
        
        if (plrInfantryMov < 0)
        {
            currentScene = "nmyTurn";
            nmyFlyingMov = 5;
        }
    }
    else if (currentScene == "nmyTurn")
    {
        if (AvatarRect.x > EnemyRect.x)
        {
            EnemyRect.x += 32;
            nmyFlyingMov--;
        }
        else if (AvatarRect.x < EnemyRect.x)
        {
            EnemyRect.x -= 32;
            nmyFlyingMov--;
        }
        else if (AvatarRect.y > EnemyRect.y)
        {
            EnemyRect.y += 32;
            nmyFlyingMov--;
        }
        else if (AvatarRect.y < EnemyRect.y)
        {
            EnemyRect.y -= 32;
            nmyFlyingMov--;
        }
        
        if (nmyFlyingMov < 0 || nmyFlyingMov == 0)
        {
            currentScene = "plrTurn";
            plrInfantryMov = 2;
        }
    }
    else if (currentScene == "gameOver")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "plrTurn";
        }
    }
    else if (currentScene == "end")
    {
        // as of yet, not achievable
    }

    // Music

    if (currentScene == "start")
    {
        Raylib.PlayMusicStream(MainTheme);
        Raylib.UpdateMusicStream(MainTheme);
    }
    if (currentScene == "plrTurn" || currentScene == "nmyTurn")
    {
        Raylib.StopMusicStream(MainTheme);
        Raylib.PlayMusicStream(ChasingDaybreak);
        Raylib.UpdateMusicStream(ChasingDaybreak);
    }
    if (currentScene == "gameOver")
    {
        Raylib.StopMusicStream(ChasingDaybreak);
    }
    if (currentScene == "end")
    {
        Raylib.StopMusicStream(ChasingDaybreak);
        Raylib.PlayMusicStream(HeritorsOfArcadia);
    }

    // Grafik

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    if (currentScene == "start")
    {
        Raylib.DrawText("press Enter to start", 100, 300, 48, Color.DARKBLUE);
    }
    if (currentScene == "plrTurn" || currentScene == "nmyTurn")
    {
        Raylib.DrawTexture(AvatarImage, (int)AvatarRect.x, (int)AvatarRect.y, Color.WHITE);
        Raylib.DrawTexture(EnemyImage, (int)EnemyRect.x, (int)EnemyRect.y, Color.WHITE);

        for (int x = 0; x < Raylib.GetScreenWidth() + 1 / tileSize; x++)
        {
            Raylib.DrawLine(x * tileSize, 0, x * tileSize, Raylib.GetScreenHeight(), Color.BLACK);
        }
        for (int y = 0; y < Raylib.GetScreenHeight() / tileSize; y++)
        {
            Raylib.DrawLine(Raylib.GetScreenWidth(), y * tileSize, 0, y * tileSize, Color.BLACK);
        }
    }
    if (currentScene == "gameOver")
    {
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("crinch", 100, 300, 38, Color.RED);
    }
    if (currentScene == "end")
    {
        Raylib.DrawText("impossible", 100, 300, 38, Color.DARKBLUE);
    }

    // hielo
    Raylib.EndDrawing();
}
