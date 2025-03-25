namespace Tic_Tac_Toe_Game
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblTheWinnerIs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBox9 = new System.Windows.Forms.PictureBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.lblTitle.Location = new System.Drawing.Point(287, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Hobo Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblWin.Location = new System.Drawing.Point(72, 133);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(149, 45);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "WINNER";
            // 
            // lblTheWinnerIs
            // 
            this.lblTheWinnerIs.AutoSize = true;
            this.lblTheWinnerIs.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheWinnerIs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTheWinnerIs.Location = new System.Drawing.Point(51, 178);
            this.lblTheWinnerIs.Name = "lblTheWinnerIs";
            this.lblTheWinnerIs.Size = new System.Drawing.Size(204, 34);
            this.lblTheWinnerIs.TabIndex = 2;
            this.lblTheWinnerIs.Text = "IN PROGRESS...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(87, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "TURN";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerTurn.Location = new System.Drawing.Point(63, 289);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(133, 32);
            this.lblPlayerTurn.TabIndex = 4;
            this.lblPlayerTurn.Text = "Player 1";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(69, 374);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(113, 41);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "RESART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(69, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBox9
            // 
            this.picBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox9.Location = new System.Drawing.Point(588, 328);
            this.picBox9.Name = "picBox9";
            this.picBox9.Size = new System.Drawing.Size(100, 100);
            this.picBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox9.TabIndex = 15;
            this.picBox9.TabStop = false;
            this.picBox9.Tag = "b";
            this.picBox9.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox8
            // 
            this.picBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox8.Location = new System.Drawing.Point(465, 328);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(100, 100);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox8.TabIndex = 14;
            this.picBox8.TabStop = false;
            this.picBox8.Tag = "b";
            this.picBox8.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox7
            // 
            this.picBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox7.Location = new System.Drawing.Point(341, 328);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(100, 100);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox7.TabIndex = 13;
            this.picBox7.TabStop = false;
            this.picBox7.Tag = "b";
            this.picBox7.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox6
            // 
            this.picBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox6.Location = new System.Drawing.Point(588, 211);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(100, 100);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox6.TabIndex = 12;
            this.picBox6.TabStop = false;
            this.picBox6.Tag = "b";
            this.picBox6.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox5
            // 
            this.picBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox5.Location = new System.Drawing.Point(465, 211);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(100, 100);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox5.TabIndex = 11;
            this.picBox5.TabStop = false;
            this.picBox5.Tag = "b";
            this.picBox5.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox4
            // 
            this.picBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox4.Location = new System.Drawing.Point(341, 211);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(100, 100);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox4.TabIndex = 10;
            this.picBox4.TabStop = false;
            this.picBox4.Tag = "b";
            this.picBox4.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox3
            // 
            this.picBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox3.Location = new System.Drawing.Point(588, 92);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(100, 100);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 9;
            this.picBox3.TabStop = false;
            this.picBox3.Tag = "b";
            this.picBox3.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox2
            // 
            this.picBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox2.Location = new System.Drawing.Point(465, 92);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(100, 100);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 8;
            this.picBox2.TabStop = false;
            this.picBox2.Tag = "b";
            this.picBox2.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox1
            // 
            this.picBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.blankImg;
            this.picBox1.Location = new System.Drawing.Point(341, 92);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(100, 100);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 7;
            this.picBox1.TabStop = false;
            this.picBox1.Tag = "b";
            this.picBox1.Click += new System.EventHandler(this.picBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.picBox9);
            this.Controls.Add(this.picBox8);
            this.Controls.Add(this.picBox7);
            this.Controls.Add(this.picBox6);
            this.Controls.Add(this.picBox5);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTheWinnerIs);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblTheWinnerIs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox6;
        private System.Windows.Forms.PictureBox picBox5;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox9;
        private System.Windows.Forms.PictureBox picBox8;
        private System.Windows.Forms.PictureBox picBox7;
    }
}

