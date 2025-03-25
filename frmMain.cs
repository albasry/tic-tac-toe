using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        enum enPlayer
        {
            Player1,
            Player2,
            GameInProgress,
            Draw
        }

        enPlayer PlayerChoice;

        struct stGameStatus
        {
            public bool GameOver;
            public byte GameCount;
        }

        stGameStatus GameStatus;

        void EndGame()
        {
            switch (PlayerChoice)
            {
                case enPlayer.Player1:
                    lblTheWinnerIs.Text = "    PLAYER 1";
                    MessageBox.Show("The winner is:\n Player 1", "Tic-Tac-Toe Game", MessageBoxButtons.OK);
                    break;

                case enPlayer.Player2:
                    lblTheWinnerIs.Text = "    PLAYER 2";
                    MessageBox.Show("The winner is:\n Player 2", "Tic-Tac-Toe Game", MessageBoxButtons.OK);
                    break;

                case enPlayer.Draw:
                    lblTheWinnerIs.Text = "       DRAW";
                    MessageBox.Show("The winner is:\n Draw!", "Tic-Tac-Toe Game", MessageBoxButtons.OK);
                    break;

                default:
                    break;
            }
        }

        bool CheckValues(PictureBox Pic1, PictureBox Pic2, PictureBox Pic3)
        {
            if (Pic1.Tag.ToString() != "b" && Pic1.Tag.ToString() == Pic2.Tag.ToString() && Pic1.Tag.ToString() == Pic3.Tag.ToString())
            {
                Pic1.BackColor = Color.DarkOrange;
                Pic2.BackColor = Color.DarkOrange;
                Pic3.BackColor = Color.DarkOrange;

                if (Pic1.Tag.ToString() == "x")
                {
                    PlayerChoice = enPlayer.Player1;
                    GameStatus.GameOver = true;
                    EndGame();

                    return true;
                }
                else
                {
                    PlayerChoice = enPlayer.Player2;
                    GameStatus.GameOver = true;
                    EndGame();

                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        void CheckWhoWins()
        {
            /*
             * Check Rows, Columns and Diagonals
             * [ 1 , 2 , 3 ]
             * [ 4 , 5 , 6 ]
             * [ 7 , 8 , 9 ]
             * 
             * Rows     : [ 1 , 2 , 3 ], [ 4 , 5 , 6 ], [ 7 , 8 , 9 ]
             * Columns  : [ 1 , 4 , 7 ], [ 2 , 5 , 8 ], [ 3 , 6 , 9 ]
             * Diagonals: [ 1 , 5 , 9 ], [ 3 , 5 , 7 ]
             */

            // Check Row 1 ============================
            if (CheckValues(picBox1, picBox2, picBox3))
                return;
            // Check Row 2
            if (CheckValues(picBox4, picBox5, picBox6))
                return;
            // Check Row 3
            if (CheckValues(picBox7, picBox8, picBox9))
                return;

            // Check Column 1 =========================
            if (CheckValues(picBox1, picBox4, picBox7))
                return;
            // Check Column 2
            if (CheckValues(picBox2, picBox5, picBox8))
                return;
            // Check Column 3
            if (CheckValues(picBox3, picBox6, picBox9))
                return;

            // Check Diagonal 1 =======================
            if (CheckValues(picBox1, picBox5, picBox9))
                return;
            // Check Diagonal 2
            if (CheckValues(picBox3, picBox5, picBox7))
                return;
        }

        void ChangeImage(PictureBox xoImage)
        {
            if (xoImage.Tag.ToString() == "b" && GameStatus.GameOver == false)
            {
                switch (PlayerChoice)
                {
                    case enPlayer.Player1:
                        xoImage.Image = Resources.xSign;
                        xoImage.Tag = "x";

                        PlayerChoice = enPlayer.Player2;
                        lblPlayerTurn.Text = "Player 2";

                        GameStatus.GameCount++;

                        CheckWhoWins();
                        break;

                    case enPlayer.Player2:
                        xoImage.Image = Resources.oSign;
                        xoImage.Tag = "o";

                        PlayerChoice = enPlayer.Player1;
                        lblPlayerTurn.Text = "Player 1";

                        GameStatus.GameCount++;

                        CheckWhoWins();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong choice", "Tic-Tac-Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (GameStatus.GameCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;

                PlayerChoice = enPlayer.Draw;

                EndGame();
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 8;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Horizontal Lines
            e.Graphics.DrawLine(pen, 695, 200, 335, 200);
            e.Graphics.DrawLine(pen, 695, 320, 335, 320);

            // Vertical Lines
            e.Graphics.DrawLine(pen, 450, 90, 450, 430);
            e.Graphics.DrawLine(pen, 580, 90, 580, 430);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void RestImages(PictureBox Pic)
        {
            Pic.Image = Resources.blankImg;
            Pic.Tag = "b";
            Pic.BackColor = Color.Transparent;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestImages(picBox1);
            RestImages(picBox2);
            RestImages(picBox3);
            RestImages(picBox4);
            RestImages(picBox5);
            RestImages(picBox6);
            RestImages(picBox7);
            RestImages(picBox8);
            RestImages(picBox9);

            GameStatus.GameCount = 0;
            GameStatus.GameOver = false;

            PlayerChoice = enPlayer.Player1;
            lblPlayerTurn.Text = "Player 1";
            lblTheWinnerIs.Text = "IN PROGRESS...";
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }

    }
}
