using System.Drawing;

namespace ProSnake
{
    class Circle : IShape
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Circle()
        {
            X = 0;
            Y = 0;
        }

        public override void DrawSnakeOnCanvas(ref Graphics canvas, MySnake SnakeObject, Brush snakeColour, int i)
        {
            canvas.FillEllipse(snakeColour,
                new Rectangle(SnakeObject.Snake[i].X * SnakeObject.Width,
                              SnakeObject.Snake[i].Y * SnakeObject.Height,
                              SnakeObject.Width, SnakeObject.Height)
                              );
        }

        public override void DrawFoodOnCanvas(ref Graphics canvas, IShape FoodShape, int Width, int Height)
        {
            canvas.FillEllipse(Brushes.Red,
                new Rectangle(FoodShape.X * Width,
                              FoodShape.Y * Height, 
                              Width, Height)
                              );
        }
    }
}