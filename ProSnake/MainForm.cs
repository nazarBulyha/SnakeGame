using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProSnake
{
    public partial class MainForm : Form
    {
        //Choose which snake to play
        int snakesCount = 0;
        public List<Bitmap> SnakeImages = new List<Bitmap> {
            Properties.Resources.snake0,
            Properties.Resources.snake1,
            Properties.Resources.snake2
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            var slctdSnake = pbSnakes.BackgroundImage;
            var speed = (rb1.Checked) ? 8 : (rb2.Checked ? 12 : 16);
            var shape = (slctdSnake == SnakeImages[0]) ? Shape.Circle :
                         (slctdSnake == SnakeImages[1] ? Shape.Square : Shape.Diamond);

            GameField gameField = new GameField(shape, speed);
            GameForm gameForm = new GameForm(gameField);
            gameForm.Show();
            Hide();
        }

        #region Gallary of Snakes
        private void BtnForward_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;

            if (pbSnakes.BackgroundImage == SnakeImages[1])
                btnForward.Visible = false;

            pbSnakes.BackgroundImage = SnakeImages[++snakesCount];

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            btnForward.Visible = true;

            if (pbSnakes.BackgroundImage == SnakeImages[1])
                btnBack.Visible = false;

            pbSnakes.BackgroundImage = SnakeImages[--snakesCount];
        }


        #endregion

        #region SpeedCheckLogic
        private void BtnSpeed1_Click(object sender, EventArgs e)
        {
            rb1.Checked = true;
        }

        private void BtnSpeed2_Click(object sender, EventArgs e)
        {
            rb2.Checked = true;
        }

        private void BtnSpeed3_Click(object sender, EventArgs e)
        {
            rb3.Checked = true;
        }
        #endregion
    }
}
