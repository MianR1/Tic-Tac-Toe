namespace RafayM_ASSN03_TicTacToe
{
    partial class frmGame
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grpstatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grpstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Permanent Marker", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(489, 91);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "TIC-TAC-TOE";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Orbitron", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(354, 484);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(103, 48);
            this.btnPlay.TabIndex = 22;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grpstatus
            // 
            this.grpstatus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.grpstatus.Controls.Add(this.lblStatus);
            this.grpstatus.Cursor = System.Windows.Forms.Cursors.No;
            this.grpstatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpstatus.ForeColor = System.Drawing.Color.White;
            this.grpstatus.Location = new System.Drawing.Point(63, 473);
            this.grpstatus.Name = "grpstatus";
            this.grpstatus.Size = new System.Drawing.Size(285, 113);
            this.grpstatus.TabIndex = 21;
            this.grpstatus.TabStop = false;
            this.grpstatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblStatus.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(4, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(279, 92);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Scoreboard";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.White;
            this.pic7.Enabled = false;
            this.pic7.Location = new System.Drawing.Point(63, 361);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(103, 95);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic7.TabIndex = 20;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.White;
            this.pic8.Enabled = false;
            this.pic8.Location = new System.Drawing.Point(207, 361);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(103, 95);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic8.TabIndex = 19;
            this.pic8.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic5.Enabled = false;
            this.pic5.Location = new System.Drawing.Point(207, 238);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(103, 95);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 18;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.White;
            this.pic6.Enabled = false;
            this.pic6.Location = new System.Drawing.Point(353, 238);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(103, 95);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic6.TabIndex = 17;
            this.pic6.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.BackColor = System.Drawing.Color.White;
            this.pic9.Enabled = false;
            this.pic9.Location = new System.Drawing.Point(353, 361);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(103, 95);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic9.TabIndex = 16;
            this.pic9.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic4.Enabled = false;
            this.pic4.Location = new System.Drawing.Point(63, 238);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(103, 95);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 15;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic3.Enabled = false;
            this.pic3.Location = new System.Drawing.Point(353, 115);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(103, 95);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic2.Enabled = false;
            this.pic2.Location = new System.Drawing.Point(207, 115);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(103, 95);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 13;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic1.Enabled = false;
            this.pic1.Location = new System.Drawing.Point(63, 115);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(103, 95);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Orbitron", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(354, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 48);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblWinner.Font = new System.Drawing.Font("Orbitron", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(62, 589);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(394, 68);
            this.lblWinner.TabIndex = 1;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(531, 658);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpstatus);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "frmGame";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.grpstatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grpstatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWinner;
    }
}

