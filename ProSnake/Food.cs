using System;
using System.Windows.Forms;

namespace ProSnake
{
    public class Food : IShape
    {
        public static int FoodCost { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Food()
        {
            X = 0;
            Y = 0;
        }

        public void GenerateFood(PictureBox pbCanvas, IShape food, int snakeWidth, int snakeHeight)
        {
            int maxXPos = pbCanvas.Size.Width / snakeWidth;
            int maxYPos = pbCanvas.Size.Height / snakeHeight;

            Random random = new Random();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);   
        }
    }
}