using System.Linq;
using System.Windows.Forms;

namespace ProSnake
{
    public class GameField
    {
        private PictureBox _pbCanvas { get; set; }
        public MySnake SnakeObject { get; set; }
        public Food FoodObject { get; set; }
        public int Score { get; set; } = 0;
        public int Points { get; set; } = 100;
        public int SnakeSpeed => SnakeObject.Speed;
        public bool GameOver { get; set; } = false;


        public GameField(Shape shape, int speed)
        {
            SnakeObject = new MySnake()
            {
                Speed = speed,
                Width = 16,
                Height = 16,
                Direction = Direction.Down,
                SnakeShape = ShapeFactory.GetObjectShape(shape),
                Snake = ShapeFactory.GetListSnakeShape(shape).ToList()
            };
            FoodObject = new Food()
            {
                X = 30,
                Y = 30,
                FoodShape = ShapeFactory.GetObjectShape(shape)
            };

        }

        public void SnakeEatFood()
        {
            //Add shape to body
            IShape Shape = (IShape)FoodObject.FoodShape.Clone();
            Shape.X = SnakeObject.Snake[SnakeObject.Snake.Count - 1].X;
            Shape.Y = SnakeObject.Snake[SnakeObject.Snake.Count - 1].Y;
            SnakeObject.Snake.Add(Shape);

            Score += Points;
        }

        public void MoveSnake()
        {
            for (int i = SnakeObject.Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) //Move head
                {
                    SnakeObject.ChooseDirection(i);
                    DetectCollision(i);
                }
                else //Move body
                {
                    SnakeObject.Snake[i].X = SnakeObject.Snake[i - 1].X;
                    SnakeObject.Snake[i].Y = SnakeObject.Snake[i - 1].Y;
                }
            }
        }

        private void DetectCollision(int i)
        {
            //Get maximum X and Y Pos
            int maxXPos = _pbCanvas.Size.Width / SnakeObject.Width;
            int maxYPos = _pbCanvas.Size.Height / SnakeObject.Height;

            //with game borders.
            if (SnakeObject.Snake[i].X < 0 || SnakeObject.Snake[i].Y < 0 || 
                SnakeObject.Snake[i].X >= maxXPos || SnakeObject.Snake[i].Y >= maxYPos)
            {
                EndGame();
            }


            //with body
            for (int j = 1; j < SnakeObject.Snake.Count; j++)
            {
                if (SnakeObject.Snake[i].X == SnakeObject.Snake[j].X &&
                   SnakeObject.Snake[i].Y == SnakeObject.Snake[j].Y)
                {
                    EndGame();
                }
            }

            //with food piece
            if (SnakeObject.Snake[0].X == FoodObject.FoodShape.X && 
                SnakeObject.Snake[0].Y == FoodObject.FoodShape.Y)
            {
                SnakeEatFood();
                FoodObject.FoodShape = FoodObject.GenerateFood(_pbCanvas, SnakeObject.Width, SnakeObject.Height);
            }
        }

        public void EndGame()
        {
            GameOver = true;
        }

        public void GetCanvasFromGameForm(PictureBox pbCanvasField)
        {
            _pbCanvas = pbCanvasField;
        }
    }
}