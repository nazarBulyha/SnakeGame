using System.Drawing;

namespace ProSnake
{
    public interface IShape
    {
        int X { get; set; }
        int Y { get; set; }

        void DrawObjectOnCanvas(ref Graphics canvas, Food FoodObject, MySnake SnakeObject, Brush snakeColour, int i);
    }
}