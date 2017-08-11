using System;
using System.Drawing;

namespace ProSnake
{
    class Circle : IShape
    {
        //List<Circle> circleList;
        public int X { get; set; }
        public int Y { get; set; }

        public Circle()
        {
            X = 0;
            Y = 0;
        }

        public void DrawObjectOnCanvas(ref Graphics canvas, Food FoodObject, MySnake SnakeObject, Brush snakeColour, int i)
        {
            canvas.FillEllipse(snakeColour,
                new Rectangle(SnakeObject.Snake[i].X * SnakeObject.Width,
                              SnakeObject.Snake[i].Y * SnakeObject.Height,
                              SnakeObject.Width, SnakeObject.Height));

        }
    }
}