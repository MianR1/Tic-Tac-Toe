/************************************************************************************
    PROGRAMME	:	Tic-Tac-Toe
    OUTLINE		:	This programme lets users be 2 letters, X and O, two players
                    are required for this game, and who ever gets 3 in a row wins.
    PROGRAMMER	:	Mian Rafay
    DATE		:	May 30, 2020
 ************************************************************************************/
using RafayM_ASSN03_TicTacToe.Properties;
using System;
using System.Windows.Forms;
namespace RafayM_ASSN03_TicTacToe
{
    public partial class frmGame : Form
    {
        private PictureBox[,] picCol = new PictureBox[3, 3];
        private Player X = new Player(Resources.X, "x");
        private Player O = new Player(Resources.O, "o");
        private Player currentPlayer;
        public frmGame()
        {
            InitializeComponent();
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            int counter = 1;
            for (int i = 0; i < 3; ++i)
            {
                for (int x = 0; x < 3; ++x)
                {
                    picCol[i, x] = (PictureBox)Controls["pic" + counter.ToString()];
                    counter += 1;
                }
            }
            for (int i = 0; i < 3; ++i)
            {
                for (int x = 0; x < 3; ++x)
                {
                    picCol[i, x].Click += new EventHandler(PicClicked);
                }
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameOver("RESET--");
            btnPlay.Enabled = false; 
            currentPlayer = X;
            lblWinner.Text = "Player " + currentPlayer.ToString() + "'s Turn";
        }
        private void PicClicked(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = currentPlayer.playerImage; 
            pictureBox.Enabled = false;
            currentPlayer.slots.Add(int.Parse(pictureBox.Name[3].ToString()));
            currentPlayer.slots.Sort();
            if (currentPlayer.IsWinner())
            {
                ++currentPlayer.NumOfWins;
                GameOver("Game Over.\nPlayer " + currentPlayer.ToString() + " is the Winner!");
            }
            else if (X.slots.ToArray().Length + O.slots.ToArray().Length == 9)
            {
                GameOver("Game Over.\nThere was no Winner.");
            }
            else
            {
                if (currentPlayer == X)
                    currentPlayer = O;
                else
                currentPlayer = X;
                lblWinner.Text = "Player " + currentPlayer.ToString() + "'s Turn";
            }
        }
        private void GameOver(string strOut)
        {
            if (strOut == "RESET--")
            {
                for (int i = 0; i < 3; ++i)
                {
                    for (int x = 0; x < 3; ++x)
                    {
                        picCol[i, x].Image = Resources.Blank;
                        picCol[i, x].Enabled = true;
                    }
                }
            }
            else
            {
                lblWinner.Text = strOut;
                for (int i = 0; i < 3; ++i)
                {
                    for (int x = 0; x < 3; ++x)
                        picCol[i, x].Enabled = false;
                }
                X.Reset(); O.Reset();
                btnPlay.Enabled = true;
                lblStatus.Text = "Player X: " + X.NumOfWins.ToString() + "\n Player O: " + O.NumOfWins.ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
