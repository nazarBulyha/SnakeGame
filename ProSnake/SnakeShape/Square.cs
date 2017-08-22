using System.Drawing;

namespace ProSnake
{
    class Square : IShape
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Square()
        {
            X = 0;
            Y = 0;
        }

        public override void DrawSnakeOnCanvas(ref Graphics canvas, MySnake SnakeObject, Brush snakeColour, int i)
        {
            canvas.FillRectangle(snakeColour,
                new Rectangle(SnakeObject.Snake[i].X * SnakeObject.Width,
                              SnakeObject.Snake[i].Y * SnakeObject.Height,
                              SnakeObject.Width, SnakeObject.Height)
                              );
        }

        public override void DrawFoodOnCanvas(ref Graphics canvas, IShape FoodShape, int Width, int Height)
        {
            canvas.FillRectangle(Brushes.Red,
                new Rectangle(FoodShape.X * Width,
                              FoodShape.Y * Height,
                              Width, Height)
                              );
        }
    }
}