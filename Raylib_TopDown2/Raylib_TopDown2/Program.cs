using Raylib_cs;

Raylib.InitWindow(800, 600, "Leonards even more crinch game");
Raylib.SetTargetFPS(60);

Texture2D enemyTexture = Raylib.LoadTexture("octosnipah.png");
// Rectangle enemyRect = new Rectangle(
//   0,  0, 
//   enemyTexture.width, enemyTexture.height
//   );

List<Rectangle> enemyRects = new List<Rectangle>();

enemyRects.Add(new Rectangle(0, 0, enemyTexture.width, enemyTexture.height));
enemyRects.Add(new Rectangle(300, 0, enemyTexture.width, enemyTexture.height));
enemyRects.Add(new Rectangle(700, 0, enemyTexture.width, enemyTexture.height));


while(!Raylib.WindowShouldClose())
{
    // LOGIK

    // GRAFIK
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.DARKBLUE);

    Raylib.DrawTexture(enemyTexture, 
      (int)enemyRects[0].x,
      (int)enemyRects[0].y,
      Color.WHITE
    );

    Raylib.EndDrawing();
}