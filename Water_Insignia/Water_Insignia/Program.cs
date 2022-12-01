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

Texture2D AvatarImage = Raylib.LoadTexture("gremory.png");
Rectangle AvatarRect = new Rectangle(0, 0, AvatarImage.width, AvatarImage.height);
int tileSize = 32;
string currentScene = "start";
    int plrInfantryMov = 3;
    int nmyInfantryMov = 0;

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
    if (currentScene == "plrTurn")
    {
    if (plrInfantryMov >= 0)
    {
        if (Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT))
        {
            AvatarRect.x += 32;
            plrInfantryMov -= 1;
            if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
            {
                AvatarRect.x -= 32;
                plrInfantryMov += 1;
            }
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT))
        {

            AvatarRect.x -= 32;
            plrInfantryMov -= 1;
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP))
        {
            AvatarRect.y -= 32;
            plrInfantryMov -= 1;
        }
        else if (Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN))
        {
            AvatarRect.y += 32;
            plrInfantryMov -= 1;
        }

        }
        if (plrInfantryMov < 0)
        {
        currentScene = "nmyTurn";
        }
    }
    if (currentScene == "nmyTurn")
    {
       if (nmyInfantryMov <= 0)
       {
            currentScene = "plrTurn";
       }
    }

    // Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    if (currentScene == "start")
    {
        Raylib.DrawText("press Enter to start", 200, 300, 48, Color.DARKBLUE);
    }
    
    if (currentScene == "plrTurn" || currentScene == "nmyTurn")
    {
      Raylib.DrawTexture(AvatarImage, (int)AvatarRect.x, (int)AvatarRect.y, Color.WHITE);

      for (int x = 0; x < Raylib.GetScreenWidth() + 1 / tileSize; x++)
      {
          Raylib.DrawLine(x * tileSize, 0, x * tileSize, Raylib.GetScreenHeight(), Color.BLACK);
      }
      for (int y = 0; y < Raylib.GetScreenHeight() / tileSize; y++)
      {
          Raylib.DrawLine(Raylib.GetScreenWidth(), y * tileSize, 0, y * tileSize, Color.BLACK);
      }
    }


    // hielo
    Raylib.EndDrawing();
}