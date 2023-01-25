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

Color selectorBlue = new Color(0, 102, 204, 127);

//Sprites + Images + Variables
Texture2D bkgImage = Raylib.LoadTexture("background.png");
Texture2D AvatarImage = Raylib.LoadTexture("gremory.png");
Rectangle AvatarRectStart = new Rectangle(0, 64, AvatarImage.width, AvatarImage.height);
Rectangle AvatarRect;
Texture2D AvatarImage2 = Raylib.LoadTexture("stolencharacteravatar.png");
Rectangle AvatarRect2Start = new Rectangle(64, 64, AvatarImage2.width, AvatarImage2.height);
Rectangle AvatarRect2;
Texture2D EnemyImage = Raylib.LoadTexture("Barbarossa.png");
Rectangle EnemyRect = new Rectangle(0, 768, EnemyImage.width, EnemyImage.height);
Rectangle Selector = new Rectangle(0, 0, 32, 32);
int tileSize = 32;
string currentScene = "start";
int characters = 2;

// Movements
int plrInfMov = 2;
int plrInfMov2 = 2;
int nmyFlyMov = 5;

// Music tracks
Music MainTheme = Raylib.LoadMusicStream("MainTheme.mp3");
Music ChasingDaybreak = Raylib.LoadMusicStream("ChasingDaybreak.mp3");
Music HeritorsOfArcadia = Raylib.LoadMusicStream("HeritorsOfArcadia.mp3");
Music gameOverSerious6b = Raylib.LoadMusicStream("gameOver(Serious6b).mp3");
Music death = Raylib.LoadMusicStream("death.mp3");

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
        AvatarRect = AvatarRectStart;
        AvatarRect2 = AvatarRect2Start;
        if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
        {
            Selector.x += 32;
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
        {
            Selector.x -= 32;
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
        {
            Selector.y -= 32;
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN))
        {
            Selector.y += 32;
        }
        if (Raylib.CheckCollisionRecs(Selector, AvatarRectStart) == true && Raylib.IsKeyDown(KeyboardKey.KEY_ENTER) || Raylib.CheckCollisionRecs(Selector, AvatarRectStart) == true && Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
            if (plrInfMov >= 0)
            {
                if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
                {
                    AvatarRectStart.x += 32;
                    plrInfMov--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
                {
                    AvatarRectStart.x -= 32;
                    plrInfMov--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
                {
                    AvatarRectStart.y -= 32;
                    plrInfMov--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN))
                {
                    AvatarRectStart.y += 32;
                    plrInfMov--;
                }
            }
        }
        else if (Raylib.CheckCollisionRecs(Selector, AvatarRect2Start) == true && Raylib.IsKeyDown(KeyboardKey.KEY_ENTER) || Raylib.CheckCollisionRecs(Selector, AvatarRect2Start) == true && Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
            if (plrInfMov2 >= 0)
            {

                if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
                {
                    AvatarRect2Start.x += 32;
                    plrInfMov2--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
                {
                    AvatarRect2Start.x -= 32;
                    plrInfMov2--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
                {
                    AvatarRect2Start.y -= 32;
                    plrInfMov2--;
                }
                else if (Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN))
                {
                    AvatarRect2Start.y += 32;
                    plrInfMov2--;
                }
            }
        }
        if (Raylib.CheckCollisionRecs(AvatarRectStart, EnemyRect) || Raylib.CheckCollisionRecs(AvatarRect2Start, EnemyRect))
        {
            currentScene = "death";
            characters -= 1;
        }
        if (characters < 0 || characters == 0)
        {
            currentScene = "gameOver";
        }
        if (plrInfMov < 0 && plrInfMov2 < 0)
        {
            currentScene = "nmyTurn";
            nmyFlyMov = 5;
        }
    }
    else if (currentScene == "nmyTurn")
    {
        if (AvatarRectStart.x > EnemyRect.x)
        {
            EnemyRect.x += 32;
            nmyFlyMov--;
        }
        else if (AvatarRectStart.x < EnemyRect.x)
        {
            EnemyRect.x -= 32;
            nmyFlyMov--;
        }
        else if (AvatarRectStart.y > EnemyRect.y)
        {
            EnemyRect.y += 32;
            nmyFlyMov--;
        }
        else if (AvatarRectStart.y < EnemyRect.y)
        {
            EnemyRect.y -= 32;
            nmyFlyMov--;
        }
        if (Raylib.CheckCollisionRecs(AvatarRectStart, EnemyRect) || Raylib.CheckCollisionRecs(AvatarRect2Start, EnemyRect))
        {
            currentScene = "death";
        }
        if (nmyFlyMov < 0 || nmyFlyMov == 0)
        {
            currentScene = "plrTurn";
            plrInfMov = 2;
            plrInfMov2 = 2;
        }
    }
    else if (currentScene == "death")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "start";
            // bugged
        }
    }
    else if (currentScene == "gameOver")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "start";
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
    else if (currentScene == "plrTurn" || currentScene == "nmyTurn")
    {
        Raylib.StopMusicStream(MainTheme);
        Raylib.StopMusicStream(death);
        Raylib.PlayMusicStream(ChasingDaybreak);
        Raylib.UpdateMusicStream(ChasingDaybreak);
    }
    else if (currentScene == "death")
    {
        Raylib.StopMusicStream(ChasingDaybreak);
        Raylib.PlayMusicStream(death);
        Raylib.UpdateMusicStream(death);
    }
    else if (currentScene == "gameOver")
    {
        Raylib.StopMusicStream(ChasingDaybreak);
        Raylib.PlayMusicStream(gameOverSerious6b);
        Raylib.UpdateMusicStream(gameOverSerious6b);
    }
    else if (currentScene == "end")
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
    else if (currentScene == "plrTurn" || currentScene == "nmyTurn")
    {
        Raylib.DrawTexture(bkgImage, 0, 0, Color.WHITE);
        Raylib.DrawTexture(AvatarImage, (int)AvatarRectStart.x, (int)AvatarRectStart.y, Color.WHITE);
        Raylib.DrawTexture(AvatarImage2, (int)AvatarRect2Start.x, (int)AvatarRect2Start.y, Color.WHITE);
        Raylib.DrawTexture(EnemyImage, (int)EnemyRect.x, (int)EnemyRect.y, Color.WHITE);
        Raylib.DrawRectangleRec(Selector, selectorBlue);

        for (int x = 0; x < Raylib.GetScreenWidth() + 1 / tileSize; x++)
        {
            Raylib.DrawLine(x * tileSize, 0, x * tileSize, Raylib.GetScreenHeight(), Color.BLACK);
        }
        for (int y = 0; y < Raylib.GetScreenHeight() / tileSize; y++)
        {
            Raylib.DrawLine(Raylib.GetScreenWidth(), y * tileSize, 0, y * tileSize, Color.BLACK);
        }
    }
    else if (currentScene == "Death")
    {
        Raylib.ClearBackground(Color.WHITE);
    }
    else if (currentScene == "gameOver")
    {
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("crinch", 100, 300, 38, Color.RED);
    }
    else if (currentScene == "end")
    {
        Raylib.DrawText("impossible", 100, 300, 38, Color.DARKBLUE);
    }

    // hielo
    Raylib.EndDrawing();
}
