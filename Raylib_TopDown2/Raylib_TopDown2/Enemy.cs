using Raylib_cs;

public class Enemy
{
  public Rectangle rect;
  public Texture2D image;

  public Enemy()
  {
    image = Raylib.LoadTexture("octosnipah.png");
    rect = new Rectangle(0, 0, image.width, image.height);
  }

  public void Draw()
  {
    Raylib.DrawTexture(
      image, 
      (int) rect.x, 
      (int) rect.y, 
      Color.WHITE
    );
  }

}
