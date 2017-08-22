namespace ProSnake
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSelectSnake = new System.Windows.Forms.Label();
            this.lblSelectSpeed = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbSnakes = new System.Windows.Forms.PictureBox();
            this.btnSpeed3 = new System.Windows.Forms.Button();
            this.btnSpeed2 = new System.Windows.Forms.Button();
            this.btnSpeed1 = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnakes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectSnake
            // 
            this.lblSelectSnake.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.lblSelectSnake.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectSnake.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectSnake.ForeColor = System.Drawing.Color.Navy;
            this.lblSelectSnake.Location = new System.Drawing.Point(0, 0);
            this.lblSelectSnake.Name = "lblSelectSnake";
            this.lblSelectSnake.Size = new System.Drawing.Size(484, 100);
            this.lblSelectSnake.TabIndex = 1;
            this.lblSelectSnake.Text = "--Select Snake--";
            this.lblSelectSnake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectSpeed
            // 
            this.lblSelectSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSelectSpeed.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectSpeed.ForeColor = System.Drawing.Color.Red;
            this.lblSelectSpeed.Location = new System.Drawing.Point(0, 361);
            this.lblSelectSpeed.Name = "lblSelectSpeed";
            this.lblSelectSpeed.Size = new System.Drawing.Size(484, 100);
            this.lblSelectSpeed.TabIndex = 2;
            this.lblSelectSpeed.Text = "--Select Speed--";
            this.lblSelectSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.PeachPuff;
            this.btnForward.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(433, 103);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(41, 79);
            this.btnForward.TabIndex = 7;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBack.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(12, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 79);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pbSnakes
            // 
            this.pbSnakes.BackgroundImage = global::ProSnake.Properties.Resources.snake0;
            this.pbSnakes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSnakes.Location = new System.Drawing.Point(59, 103);
            this.pbSnakes.Name = "pbSnakes";
            this.pbSnakes.Size = new System.Drawing.Size(368, 79);
            this.pbSnakes.TabIndex = 5;
            this.pbSnakes.TabStop = false;
            // 
            // btnSpeed3
            // 
            this.btnSpeed3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSpeed3.Location = new System.Drawing.Point(287, 40);
            this.btnSpeed3.Name = "btnSpeed3";
            this.btnSpeed3.Size = new System.Drawing.Size(75, 36);
            this.btnSpeed3.TabIndex = 10;
            this.btnSpeed3.Text = "3";
            this.btnSpeed3.UseVisualStyleBackColor = false;
            this.btnSpeed3.Click += new System.EventHandler(this.BtnSpeed3_Click);
            // 
            // btnSpeed2
            // 
            this.btnSpeed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSpeed2.Location = new System.Drawing.Point(152, 40);
            this.btnSpeed2.Name = "btnSpeed2";
            this.btnSpeed2.Size = new System.Drawing.Size(75, 36);
            this.btnSpeed2.TabIndex = 9;
            this.btnSpeed2.Text = "2";
            this.btnSpeed2.UseVisualStyleBackColor = false;
            this.btnSpeed2.Click += new System.EventHandler(this.BtnSpeed2_Click);
            // 
            // btnSpeed1
            // 
            this.btnSpeed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSpeed1.Location = new System.Drawing.Point(6, 40);
            this.btnSpeed1.Name = "btnSpeed1";
            this.btnSpeed1.Size = new System.Drawing.Size(75, 36);
            this.btnSpeed1.TabIndex = 8;
            this.btnSpeed1.Text = "1";
            this.btnSpeed1.UseVisualStyleBackColor = false;
            this.btnSpeed1.Click += new System.EventHandler(this.BtnSpeed1_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.PeachPuff;
            this.btnStartGame.FlatAppearance.BorderSize = 3;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStartGame.Location = new System.Drawing.Point(132, 223);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(221, 47);
            this.btnStartGame.TabIndex = 11;
            this.btnStartGame.Text = "StartGame";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.btnSpeed1);
            this.groupBox1.Controls.Add(this.btnSpeed2);
            this.groupBox1.Controls.Add(this.btnSpeed3);
            this.groupBox1.Location = new System.Drawing.Point(59, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Checked = true;
            this.rb3.Location = new System.Drawing.Point(297, 52);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 13;
            this.rb3.TabStop = true;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(161, 52);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 12;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 52);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 11;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbSnakes);
            this.Controls.Add(this.lblSelectSpeed);
            this.Controls.Add(this.lblSelectSnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proffecional Snake Game";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbSnakes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSnake;
        private System.Windows.Forms.Label lblSelectSpeed;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbSnakes;
        private System.Windows.Forms.Button btnSpeed3;
        private System.Windows.Forms.Button btnSpeed2;
        private System.Windows.Forms.Button btnSpeed1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
    }
}

