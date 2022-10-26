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
  for (int i = 0; i < enemyRects.Count; i++)
  {
     Rectangle rect = enemyRects[i];
     rect.y++;
     enemyRects[i] = rect;
  }


  // GRAFIK
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.DARKBLUE);

  foreach(Rectangle rect in enemyRects)
  {
     Raylib.DrawTexture(enemyTexture, 
         (int)rect.x,
         (int)rect.y,
         Color.WHITE
     );
  }


    Raylib.EndDrawing();
}