using Snake;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProSnake
{
    public partial class GameForm : Form
    {
        private GameField _gameField;

        public GameForm(GameField gameField)
        {
            InitializeComponent();

            _gameField = gameField;
            gameField.GetCanvasFromGameForm(pbCanvas);

            gameTimer.Interval = 1000 / gameField.SnakeSpeed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            StartGame();
        }

        public void StartGame()
        {
            lblGameOver.Visible = false;

            //Create new player object
            _gameField.SnakeObject.Snake.Clear();

            //Set settings to default
            //new Settings();
            IShape head = _gameField.SnakeObject.SnakeShape;
            head.X = 10;
            head.Y = 5;

            _gameField.SnakeObject.Snake.Add(head);


            //lblScore.Text = Settings.Score.ToString();
            _gameField.FoodObject.GenerateFood(pbCanvas, _gameField.SnakeObject.SnakeShape,
                _gameField.SnakeObject.Width, _gameField.SnakeObject.Height);

        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (_gameField.GameOver)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && _gameField.SnakeObject.Direction != Direction.Left)
                    _gameField.SnakeObject.Direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && _gameField.SnakeObject.Direction != Direction.Right)
                    _gameField.SnakeObject.Direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && _gameField.SnakeObject.Direction != Direction.Down)
                    _gameField.SnakeObject.Direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && _gameField.SnakeObject.Direction != Direction.Up)
                    _gameField.SnakeObject.Direction = Direction.Down;

                _gameField.MoveSnake();
            }

            //use method pbCanvas_Paint()
            pbCanvas.Invalidate();
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!_gameField.GameOver)
            {
                //Set colour of snake
                Brush snakeColour;

                for (int i = 0; i < _gameField.SnakeObject.Snake.Count; i++)
                {

                    if (i == 0)
                        snakeColour = Brushes.Purple;     //Draw head
                    else
                        snakeColour = Brushes.Yellow;    //Rest of body

                    //Draw snake
                    IShape IShapeObject = ShapeFactory.GetSnakeShape(_gameField.SnakeShape);
                    IShapeObject.DrawObjectOnCanvas(ref canvas, _gameField.FoodObject, _gameField.SnakeObject, snakeColour, i);

                    //Draw Food
                    IShapeObject.DrawObjectOnCanvas(ref canvas, _gameField.FoodObject, _gameField.SnakeObject, snakeColour, i);
                }
            }
            else
            {


                string gameOver = "Game over !!! \nFinal Score: " + GameField.Score + "\nPress Enter For New Game";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }  

        public void EndGame()
        {
            _gameField.GameOver = true;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}