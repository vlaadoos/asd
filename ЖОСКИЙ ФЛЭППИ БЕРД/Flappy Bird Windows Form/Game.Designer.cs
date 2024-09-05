namespace Flappy_Bird_Windows_Form
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.NameRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.listRating = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цельИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRating = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Flappy Bird", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreText.Location = new System.Drawing.Point(291, 62);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(65, 75);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // NameRating
            // 
            this.NameRating.AutoSize = true;
            this.NameRating.BackColor = System.Drawing.Color.Transparent;
            this.NameRating.Enabled = false;
            this.NameRating.Font = new System.Drawing.Font("Flappy Bird", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRating.Location = new System.Drawing.Point(238, 297);
            this.NameRating.Name = "NameRating";
            this.NameRating.Size = new System.Drawing.Size(126, 14);
            this.NameRating.TabIndex = 5;
            this.NameRating.Text = "Введите никнейм";
            this.NameRating.Visible = false;
            // 
            // txtRating
            // 
            this.txtRating.Enabled = false;
            this.txtRating.Location = new System.Drawing.Point(241, 317);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(120, 20);
            this.txtRating.TabIndex = 6;
            this.txtRating.Visible = false;
            // 
            // listRating
            // 
            this.listRating.Enabled = false;
            this.listRating.Font = new System.Drawing.Font("Uni Sans-Trial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRating.FormattingEnabled = true;
            this.listRating.ItemHeight = 18;
            this.listRating.Items.AddRange(new object[] {
            "Рейтинг:"});
            this.listRating.Location = new System.Drawing.Point(540, 283);
            this.listRating.Name = "listRating";
            this.listRating.Size = new System.Drawing.Size(181, 130);
            this.listRating.TabIndex = 7;
            this.listRating.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.background_day;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструкцияToolStripMenuItem,
            this.рейтингToolStripMenuItem,
            this.выйтиИзИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.цельИгрыToolStripMenuItem});
            this.инструкцияToolStripMenuItem.Font = new System.Drawing.Font("Flappy Bird", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.инструкцияToolStripMenuItem.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.инфа;
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.инструкцияToolStripMenuItem.Text = "Info";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // цельИгрыToolStripMenuItem
            // 
            this.цельИгрыToolStripMenuItem.Name = "цельИгрыToolStripMenuItem";
            this.цельИгрыToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.цельИгрыToolStripMenuItem.Text = "Цель игры";
            this.цельИгрыToolStripMenuItem.Click += new System.EventHandler(this.цельИгрыToolStripMenuItem_Click);
            // 
            // рейтингToolStripMenuItem
            // 
            this.рейтингToolStripMenuItem.Font = new System.Drawing.Font("Flappy Bird", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.рейтингToolStripMenuItem.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pngwing_com__1_;
            this.рейтингToolStripMenuItem.Name = "рейтингToolStripMenuItem";
            this.рейтингToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.рейтингToolStripMenuItem.Text = "Rating";
            this.рейтингToolStripMenuItem.Click += new System.EventHandler(this.рейтингToolStripMenuItem_Click);
            // 
            // выйтиИзИгрыToolStripMenuItem
            // 
            this.выйтиИзИгрыToolStripMenuItem.Font = new System.Drawing.Font("Flappy Bird", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.выйтиИзИгрыToolStripMenuItem.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.vihod;
            this.выйтиИзИгрыToolStripMenuItem.Name = "выйтиИзИгрыToolStripMenuItem";
            this.выйтиИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.выйтиИзИгрыToolStripMenuItem.Text = "Exit Game";
            this.выйтиИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзИгрыToolStripMenuItem_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.Color.Transparent;
            this.buttonRating.Enabled = false;
            this.buttonRating.Font = new System.Drawing.Font("Flappy Bird", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRating.Location = new System.Drawing.Point(241, 343);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(120, 23);
            this.buttonRating.TabIndex = 9;
            this.buttonRating.Text = "Записать";
            this.buttonRating.UseVisualStyleBackColor = false;
            this.buttonRating.Visible = false;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.redbird_downflap1;
            this.Player.Location = new System.Drawing.Point(0, 297);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(96, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-16, 633);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(784, 126);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(362, 371);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(134, 333);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(362, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(126, 173);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeTop_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.background_day;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 707);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.listRating);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.NameRating);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label NameRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.ListBox listRating;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рейтингToolStripMenuItem;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цельИгрыToolStripMenuItem;
    }
}

