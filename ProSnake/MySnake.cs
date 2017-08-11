using System.Collections.Generic;

namespace ProSnake
{
    public class MySnake
    {
        public int Speed { get; set; } = 10;
        public int Width { get; set; } = 5;
        public int Height { get; set; } = 5;
        public Direction Direction { get; set; } = Direction.Down;
        public IShape SnakeShape { get; set; } = new Circle();
        public List<IShape> Snake { get; set; }

        public MySnake() {}

        public void ChooseDirection(int i)
        {
            switch (Direction)
            {
                case Direction.Right:
                    Snake[i].X++;
                    break;
                case Direction.Left:
                    Snake[i].X--;
                    break;
                case Direction.Up:
                    Snake[i].Y--;
                    break;
                case Direction.Down:
                    Snake[i].Y++;
                    break;
            }
        }
    }
}