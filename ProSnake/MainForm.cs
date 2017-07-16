using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProSnake
{
    public partial class mainForm : Form
    {
        List<Bitmap> Snakes = new List<Bitmap> { Properties.Resources.snake0, Properties.Resources.snake1, Properties.Resources.snake2 };
        int snakesCount = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

        }

        #region Gallary of Snakes
        private void btnForward_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;

            if (pbSnakes.BackgroundImage == Snakes[1])
                btnForward.Visible = false;

            pbSnakes.BackgroundImage = Snakes[++snakesCount];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnForward.Visible = true;

            if (pbSnakes.BackgroundImage == Snakes[1])
                btnBack.Visible = false;

            pbSnakes.BackgroundImage = Snakes[--snakesCount];
        }


        #endregion

        #region SpeedCheckLogic
        private void btnSpeed1_Click(object sender, EventArgs e)
        {
            rb1.Checked = true;
        }

        private void btnSpeed2_Click(object sender, EventArgs e)
        {
            rb2.Checked = true;
        }

        private void btnSpeed3_Click(object sender, EventArgs e)
        {
            rb3.Checked = true;
        }
        #endregion


    }
}
