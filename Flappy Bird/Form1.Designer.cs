namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Pipe_Down = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Flappy_Bird = new System.Windows.Forms.PictureBox();
            this.labelNewGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy_Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.pictureBox6.Location = new System.Drawing.Point(-8, 583);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(809, 139);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // Pipe_Down
            // 
            this.Pipe_Down.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe_down;
            this.Pipe_Down.Image = global::Flappy_Bird.Properties.Resources.pipe_down;
            this.Pipe_Down.Location = new System.Drawing.Point(607, -138);
            this.Pipe_Down.Name = "Pipe_Down";
            this.Pipe_Down.Size = new System.Drawing.Size(168, 303);
            this.Pipe_Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe_Down.TabIndex = 2;
            this.Pipe_Down.TabStop = false;
            this.Pipe_Down.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pictureBox2.Location = new System.Drawing.Point(344, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Flappy_Bird
            // 
            this.Flappy_Bird.BackgroundImage = global::Flappy_Bird.Properties.Resources.flappybird;
            this.Flappy_Bird.Image = global::Flappy_Bird.Properties.Resources.flappybird;
            this.Flappy_Bird.Location = new System.Drawing.Point(33, 89);
            this.Flappy_Bird.Name = "Flappy_Bird";
            this.Flappy_Bird.Size = new System.Drawing.Size(127, 111);
            this.Flappy_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy_Bird.TabIndex = 0;
            this.Flappy_Bird.TabStop = false;
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.BackColor = System.Drawing.Color.Coral;
            this.labelNewGame.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.labelNewGame.Location = new System.Drawing.Point(543, 617);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(222, 48);
            this.labelNewGame.TabIndex = 5;
            this.labelNewGame.Text = "New Game";
            this.labelNewGame.Visible = false;
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(802, 682);
            this.Controls.Add(this.labelNewGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Pipe_Down);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Flappy_Bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy_Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Flappy_Bird;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Pipe_Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelNewGame;
    }
}

