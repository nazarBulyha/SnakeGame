using System;
using System.Drawing;

namespace ProSnake
{
    public abstract class IShape : ICloneable
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }

        public virtual void DrawSnakeOnCanvas(ref Graphics canvas, MySnake SnakeObject, Brush snakeColour, int i) { }
        public virtual void DrawFoodOnCanvas(ref Graphics canvas, IShape FoodShape, int Width, int Height) { }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}