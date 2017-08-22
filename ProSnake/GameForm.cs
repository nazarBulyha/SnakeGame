using Snake;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProSnake
{
    public partial class GameForm : Form
    {
        private GameField _gameField { get; set; }
        private MainForm _mainForm { get; set; }
        private MySnake SnakeObject;
        private Food FoodObject;

        public GameForm(GameField gameField, MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _gameField = gameField;
            SnakeObject = _gameField.SnakeObject;
            FoodObject = _gameField.FoodObject;

            gameField.GetCanvasFromGameForm(pbCanvas);

            gameTimer.Interval = 1000 / _gameField.SnakeSpeed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            StartGame();
        }

        public void StartGame()
        {
            _gameField.GameOver = false;
            lblGameOver.Visible = false;
            _gameField.Score = 0;

            //Create new player object
            SnakeObject.Snake.Clear();

            IShape shapeSnakeHead = SnakeObject.SnakeShape;
            shapeSnakeHead.X = 10;
            shapeSnakeHead.Y = 5;
            SnakeObject.Snake.Add(shapeSnakeHead);
            
            FoodObject.FoodShape = FoodObject.GenerateFood(pbCanvas,
                SnakeObject.Width, SnakeObject.Height);

            lblScore.Text = _gameField.Score.ToString();

        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            if (!_gameField.GameOver)
            {
                if (Input.KeyPressed(Keys.Right) && SnakeObject.Direction != Direction.Left)
                    SnakeObject.Direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && SnakeObject.Direction != Direction.Right)
                    SnakeObject.Direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && SnakeObject.Direction != Direction.Down)
                    SnakeObject.Direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && SnakeObject.Direction != Direction.Up)
                    SnakeObject.Direction = Direction.Down;

                _gameField.MoveSnake();
            }
            else
            {
                //TODO: Make lblGameOver bigger to show all text
                lblGameOver.Text = "Game over !!! \nFinal Score: " +
                        _gameField.Score + "\nPress Enter For New Game \nPress Esc to choose new Snake";
                lblGameOver.Visible = true;

                if (Input.KeyPressed(Keys.Enter))
                    StartGame();
                if (Input.KeyPressed(Keys.Escape))
                    SetSpeedToolStripMenuItem_Click(sender, e);
            }

            //use method pbCanvas_Paint()
            pbCanvas.Invalidate();
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            //Set colour of snake
            Brush snakeColour;

            for (int i = 0; i < SnakeObject.Snake.Count; i++)
            {
                if (i == 0)
                    snakeColour = Brushes.Purple;       //Draw head
                else
                    snakeColour = Brushes.Green;        //Rest of body

                //Draw snake
                SnakeObject.SnakeShape.DrawSnakeOnCanvas(ref canvas, SnakeObject, snakeColour, i);

                //Draw Food
                FoodObject.FoodShape.DrawFoodOnCanvas(ref canvas, FoodObject.FoodShape, 
                    SnakeObject.Width, SnakeObject.Height);
            }

            lblScore.Text = _gameField.Score.ToString();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        #region ToolStrip Menu
        private void NewGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void SetSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            _mainForm.Show();
        }
        #endregion
    }
}