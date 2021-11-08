/************************************************************************************
    PROGRAMME	:	Tic-Tac-Toe
    OUTLINE		:	This programme lets users be 2 letters, X and O, two players
                    are required for this game, and who ever gets 3 in a row wins.
    PROGRAMMER	:	Mian Rafay
    DATE		:	February 11, 2020
 ************************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
namespace RafayM_TICTACTOE_Bonus
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        PictureBox[] pics = new PictureBox[9];
        bool xo = false;
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false; lblStatus.Text = "In Game...";
            pics[0] = pic1; pics[1] = pic2; pics[2] = pic3; pics[3] = pic4; pics[4] = pic5; pics[5] = pic6; pics[6] = pic7; pics[7] = pic8; pics[8] = pic9;    
            for (int i = 0; i <= pics.Length -1; i++)
            {
                pics[i].Image = null; pics[i].BackColor = Color.White; pics[i].Enabled = true;
            }
        }
        private void XorO(PictureBox x)
        {
            x.Enabled = false; xo = !xo;
            if (xo == true)
            {
                x.Image = Properties.Resources.X;
                x.BackColor = Color.Red;
            }
            else
            {
                x.Image = Properties.Resources.O;
                x.BackColor = Color.Orange;
            }
            Win();
        }
        protected void Pic1_Click(object sender, EventArgs e)
        {  
          PictureBox x = pic1; XorO(x);
        }
        private void Pic2_Click(object sender, EventArgs e)
        {
            PictureBox x = pic2; XorO(x);
        }
        private void Pic3_Click(object sender, EventArgs e)
        {
            PictureBox x = pic3; XorO(x);
        }
        private void Pic4_Click(object sender, EventArgs e)
        {
            PictureBox x = pic4; XorO(x);
        }
        private void Pic5_Click(object sender, EventArgs e)
        {
            PictureBox x = pic5; XorO(x);
        }
        private void Pic6_Click(object sender, EventArgs e)
        {
            PictureBox x = pic6; XorO(x);
        }
        private void Pic7_Click(object sender, EventArgs e)
        {
            PictureBox x = pic7; XorO(x);
        }
        private void Pic8_Click(object sender, EventArgs e)
        {
            PictureBox x = pic8; XorO(x);
        }
        private void Pic9_Click(object sender, EventArgs e)
        {
            PictureBox x = pic9; XorO(x);
        }
        public void Win()
        {
            PictureBox[] across1 = new PictureBox[3], across2 = new PictureBox[3], across3 = new PictureBox[3], down1 = new PictureBox[3], down2 = new PictureBox[3], down3 = new PictureBox[3], diagR = new PictureBox[3], diagL = new PictureBox[3];
            across1[0] = pic1; across1[1] = pic2; across1[2] = pic3; across2[0] = pic4; across2[1] = pic5; across2[2] = pic6; across3[0] = pic7; across3[1] = pic8; across3[2] = pic9; down1[0] = pic1; down1[1] = pic4; down1[2] = pic7; down2[0] = pic2; down2[1] = pic5; down2[2] = pic8; down3[0] = pic3; down3[1] = pic6; down3[2] = pic9; diagR[0] = pic1; diagR[1] = pic5; diagR[2] = pic9; diagL[0] = pic3; diagL[1] = pic5; diagL[2] = pic7;
            int winA1x = 0, winA2x = 0, winA3x = 0, winD1x = 0, winD2x = 0, winD3x = 0, winDiagRx = 0, winDiagLx = 0, winA1o = 0, winA2o = 0, winA3o = 0, winD1o = 0, winD2o = 0, winD3o = 0, winDiagRo = 0, winDiagLo = 0;
            for (int i = 0; i <= across1.Length - 1; i++)
            {
                 if (across1[i].BackColor == Color.Red)
                    winA1x += 1;
                 else if (across1[i].BackColor == Color.Orange)
                    winA1o += 1;
                if (across2[i].BackColor == Color.Red)
                    winA2x += 1;
                else if (across2[i].BackColor == Color.Orange)
                    winA2o += 1;
                if (across3[i].BackColor == Color.Red)
                    winA3x += 1;
                else if (across3[i].BackColor == Color.Orange)
                    winA3o += 1;
                if (down1[i].BackColor == Color.Red)
                    winD1x += 1;
                else if (down1[i].BackColor == Color.Orange)
                    winD1o += 1;
                if (down2[i].BackColor == Color.Red)
                    winD2x += 1;
                else if (down2[i].BackColor == Color.Orange)
                    winD2o += 1;
                if (down3[i].BackColor == Color.Red)
                    winD3x += 1;
                else if (down3[i].BackColor == Color.Orange)
                    winD3o += 1;
                if (diagR[i].BackColor == Color.Red)
                    winDiagRx += 1;
                else if (diagR[i].BackColor == Color.Orange)
                    winDiagRo += 1;
                if (diagL[i].BackColor == Color.Red)
                    winDiagLx += 1;
                else if (diagL[i].BackColor == Color.Orange)
                    winDiagLo += 1;
            }
            int allChecked = 0;
            for (int i = 0; i <= pics.Length - 1; i++)
            {
                if (pics[i].BackColor == Color.Orange || pics[i].BackColor == Color.Red)
                    allChecked += 1;
            }
            if (winA1x == 3 || winA2x == 3 || winA3x == 3 || winD1x == 3 || winD2x == 3 || winD3x == 3 || winDiagRx == 3 || winDiagLx == 3)
            {
                MessageBox.Show("X wins!"); lblStatus.Text = "X Wins, Press Play To Play Again..."; End();
            }
            else if (winA1o == 3 || winA2o == 3 || winA3o == 3 || winD1o == 3 || winD2o == 3 || winD3o == 3 || winDiagRo == 3 || winDiagLo == 3)
            {
                MessageBox.Show("O wins!"); lblStatus.Text = "O Wins, Press Play To Play Again..."; End();
            }
            else if (allChecked == 9)
            {
                MessageBox.Show("Draw!"); lblStatus.Text = "Draw, Press Play To Play Again..."; End();
            }
        }
        public void End()
        {
            for (int i = 0; i <= pics.Length - 1; i++)
            {
              pics[i].Enabled = false;
            }
            btnPlay.Enabled = true;
        }
    }
}
