using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProSnake
{
    public class Food
    {
        public IShape FoodShape { get; set; } = new Circle();
        public static int FoodCost { get; set; } = 100;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Food()
        {
            X = 0;
            Y = 0;
        }

        public IShape GenerateFood(PictureBox pbCanvas, int snakeWidth, int snakeHeight)
        {
            int maxXPos = pbCanvas.Size.Width / snakeWidth;
            int maxYPos = pbCanvas.Size.Height / snakeHeight;

            Random random = new Random();
            FoodShape.X = random.Next(0, maxXPos);
            FoodShape.Y = random.Next(0, maxYPos);

            return FoodShape;
        }

        public void DrawFoodOnCanvas(ref Graphics canvas, Food FoodObject, MySnake SnakeObject)
        {
            //TODO: Change for drawing to derived IShape classes(switch Shapes of Snake head, draw diffrent shape)
            canvas.FillEllipse(Brushes.Red,
                new Rectangle(FoodObject.FoodShape.X * SnakeObject.Width,
                              FoodObject.FoodShape.Y * SnakeObject.Height,
                              SnakeObject.Width, SnakeObject.Height));
        }
    }
}