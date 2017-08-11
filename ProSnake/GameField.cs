using System.Linq;
using System.Windows.Forms;

namespace ProSnake
{
    public class GameField
    {
        PictureBox _pbCanvas { get; set; }
        GameForm GameForm { get; set; }
        public Food FoodObject { get; set; }
        public MySnake SnakeObject { get; set; }
        public Shape SnakeShape { get; set; }
        public static int Score { get; set; } = 0;
        public static int Points { get; set; } = 100;
        public bool GameOver { get; set; } = false;
        public int SnakeSpeed => SnakeObject.Speed;


        public GameField(Shape shape, int speed)
        {
            SnakeShape = shape;
            SnakeObject = new MySnake()
            {
                Speed = speed,
                Width = 15,
                Height = 15,
                Direction = Direction.Down,
                SnakeShape = ShapeFactory.GetSnakeShape(SnakeShape),
                Snake = ShapeFactory.GetListSnakeShape(SnakeShape).ToList()
            };
            FoodObject = new Food()
            {
                X = 10,
                Y = 10
            };

        }

        public void SnakeEatFood()
        {
            //Add circle to body
            IShape shape = SnakeObject.SnakeShape;
            shape.X = SnakeObject.Snake[SnakeObject.Snake.Count - 1].X;
            shape.Y = SnakeObject.Snake[SnakeObject.Snake.Count - 1].Y;
            SnakeObject.Snake.Add(shape);

            //Update Score
            Score += Points;
            //lblScore.Text = Settings.Score.ToString();
        }

        public void MoveSnake()
        {
            for (int i = SnakeObject.Snake.Count - 1; i >= 0; i--)
            {
                if (i != 0) //Move body
                {
                    SnakeObject.Snake[i].X = SnakeObject.Snake[i - 1].X;
                    SnakeObject.Snake[i].Y = SnakeObject.Snake[i - 1].Y;
                }
                else //Move head
                {
                    SnakeObject.ChooseDirection(i);
                    DetectCollision(i);
                }
            }
        }

        private void DetectCollision(int i)
        {
            //Get maximum X and Y Pos
            int maxXPos = _pbCanvas.Size.Width / SnakeObject.Width;
            int maxYPos = _pbCanvas.Size.Height / SnakeObject.Height;

            //with game borders.
            if (SnakeObject.Snake[i].X < 0 || SnakeObject.Snake[i].Y < 0
                || SnakeObject.Snake[i].X >= maxXPos || SnakeObject.Snake[i].Y >= maxYPos)
            {
                GameForm.EndGame();
            }


            //with body
            for (int j = 1; j < SnakeObject.Snake.Count; j++)
            {
                if (SnakeObject.Snake[i].X == SnakeObject.Snake[j].X &&
                   SnakeObject.Snake[i].Y == SnakeObject.Snake[j].Y)
                {
                    GameForm.EndGame();
                }
            }

            //with food piece
            if (SnakeObject.Snake[0].X == FoodObject.X && SnakeObject.Snake[0].Y == FoodObject.Y)
            {
                SnakeEatFood();
                FoodObject.GenerateFood(_pbCanvas, SnakeObject.SnakeShape, SnakeObject.Width, SnakeObject.Height);
            }
        }

        internal void GetCanvasFromGameForm(PictureBox pbCanvasField)
        {
            _pbCanvas = pbCanvasField;
        }
    }
}