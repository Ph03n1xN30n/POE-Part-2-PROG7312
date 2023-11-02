namespace Game_2_Dictionary
{
    partial class MatchingGame
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WinBoard = new System.Windows.Forms.Label();
            this.LossBoard = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ButtonEndGame = new System.Windows.Forms.Button();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.PanelD = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AnswerD = new System.Windows.Forms.NumericUpDown();
            this.PanelC = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerC = new System.Windows.Forms.NumericUpDown();
            this.PanelB = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerB = new System.Windows.Forms.NumericUpDown();
            this.PanelA = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.AnswerA = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonRetry = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            this.PanelD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerD)).BeginInit();
            this.PanelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerC)).BeginInit();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerB)).BeginInit();
            this.PanelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerA)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(47, 598);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(219, 91);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 46);
            this.label12.TabIndex = 2;
            this.label12.Text = "Win";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(193, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 46);
            this.label13.TabIndex = 2;
            this.label13.Text = "Loss";
            // 
            // WinBoard
            // 
            this.WinBoard.AutoSize = true;
            this.WinBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinBoard.Location = new System.Drawing.Point(38, 86);
            this.WinBoard.Name = "WinBoard";
            this.WinBoard.Size = new System.Drawing.Size(42, 46);
            this.WinBoard.TabIndex = 2;
            this.WinBoard.Text = "0";
            // 
            // LossBoard
            // 
            this.LossBoard.AutoSize = true;
            this.LossBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossBoard.Location = new System.Drawing.Point(217, 86);
            this.LossBoard.Name = "LossBoard";
            this.LossBoard.Size = new System.Drawing.Size(42, 46);
            this.LossBoard.TabIndex = 2;
            this.LossBoard.Text = "0";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.PaleGreen;
            this.panel12.Controls.Add(this.ButtonEndGame);
            this.panel12.Controls.Add(this.ButtonRetry);
            this.panel12.Controls.Add(this.ButtonComplete);
            this.panel12.Controls.Add(this.PanelD);
            this.panel12.Controls.Add(this.PanelC);
            this.panel12.Controls.Add(this.PanelB);
            this.panel12.Controls.Add(this.PanelA);
            this.panel12.Location = new System.Drawing.Point(1087, 172);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(301, 497);
            this.panel12.TabIndex = 0;
            // 
            // ButtonEndGame
            // 
            this.ButtonEndGame.Enabled = false;
            this.ButtonEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEndGame.Location = new System.Drawing.Point(35, 331);
            this.ButtonEndGame.Name = "ButtonEndGame";
            this.ButtonEndGame.Size = new System.Drawing.Size(236, 56);
            this.ButtonEndGame.TabIndex = 4;
            this.ButtonEndGame.Text = "Quit";
            this.ButtonEndGame.UseVisualStyleBackColor = true;
            this.ButtonEndGame.Click += new System.EventHandler(this.ButtonEndGame_Click);
            // 
            // ButtonComplete
            // 
            this.ButtonComplete.Enabled = false;
            this.ButtonComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonComplete.Location = new System.Drawing.Point(35, 247);
            this.ButtonComplete.Name = "ButtonComplete";
            this.ButtonComplete.Size = new System.Drawing.Size(236, 56);
            this.ButtonComplete.TabIndex = 4;
            this.ButtonComplete.Text = "Complete";
            this.ButtonComplete.UseVisualStyleBackColor = true;
            this.ButtonComplete.Click += new System.EventHandler(this.ButtonComplete_Click);
            // 
            // PanelD
            // 
            this.PanelD.BackColor = System.Drawing.Color.Yellow;
            this.PanelD.Controls.Add(this.label3);
            this.PanelD.Controls.Add(this.AnswerD);
            this.PanelD.Location = new System.Drawing.Point(49, 174);
            this.PanelD.Name = "PanelD";
            this.PanelD.Size = new System.Drawing.Size(200, 43);
            this.PanelD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "D";
            // 
            // AnswerD
            // 
            this.AnswerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerD.Location = new System.Drawing.Point(156, 12);
            this.AnswerD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.AnswerD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(41, 26);
            this.AnswerD.TabIndex = 1;
            this.AnswerD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PanelC
            // 
            this.PanelC.BackColor = System.Drawing.Color.Yellow;
            this.PanelC.Controls.Add(this.label2);
            this.PanelC.Controls.Add(this.AnswerC);
            this.PanelC.Location = new System.Drawing.Point(49, 125);
            this.PanelC.Name = "PanelC";
            this.PanelC.Size = new System.Drawing.Size(200, 43);
            this.PanelC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "C";
            // 
            // AnswerC
            // 
            this.AnswerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerC.Location = new System.Drawing.Point(156, 12);
            this.AnswerC.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.AnswerC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(41, 26);
            this.AnswerC.TabIndex = 1;
            this.AnswerC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PanelB
            // 
            this.PanelB.BackColor = System.Drawing.Color.Yellow;
            this.PanelB.Controls.Add(this.label1);
            this.PanelB.Controls.Add(this.AnswerB);
            this.PanelB.Location = new System.Drawing.Point(49, 76);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(200, 43);
            this.PanelB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "B";
            // 
            // AnswerB
            // 
            this.AnswerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerB.Location = new System.Drawing.Point(156, 12);
            this.AnswerB.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.AnswerB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(41, 26);
            this.AnswerB.TabIndex = 1;
            this.AnswerB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PanelA
            // 
            this.PanelA.BackColor = System.Drawing.Color.Yellow;
            this.PanelA.Controls.Add(this.label15);
            this.PanelA.Controls.Add(this.AnswerA);
            this.PanelA.Location = new System.Drawing.Point(49, 27);
            this.PanelA.Name = "PanelA";
            this.PanelA.Size = new System.Drawing.Size(200, 43);
            this.PanelA.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "A";
            // 
            // AnswerA
            // 
            this.AnswerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerA.Location = new System.Drawing.Point(156, 12);
            this.AnswerA.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.AnswerA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(41, 26);
            this.AnswerA.TabIndex = 1;
            this.AnswerA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.LossBoard);
            this.panel5.Controls.Add(this.WinBoard);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(1087, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(301, 154);
            this.panel5.TabIndex = 3;
            // 
            // ButtonRetry
            // 
            this.ButtonRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRetry.Location = new System.Drawing.Point(35, 414);
            this.ButtonRetry.Name = "ButtonRetry";
            this.ButtonRetry.Size = new System.Drawing.Size(236, 53);
            this.ButtonRetry.TabIndex = 1;
            this.ButtonRetry.Text = "Retry?";
            this.ButtonRetry.UseVisualStyleBackColor = true;
            this.ButtonRetry.Visible = false;
            this.ButtonRetry.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // MatchingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 761);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel12.ResumeLayout(false);
            this.PanelD.ResumeLayout(false);
            this.PanelD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerD)).EndInit();
            this.PanelC.ResumeLayout(false);
            this.PanelC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerC)).EndInit();
            this.PanelB.ResumeLayout(false);
            this.PanelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerB)).EndInit();
            this.PanelA.ResumeLayout(false);
            this.PanelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerA)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label WinBoard;
        private System.Windows.Forms.Label LossBoard;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown AnswerA;
        private System.Windows.Forms.Panel PanelD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AnswerD;
        private System.Windows.Forms.Panel PanelC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AnswerC;
        private System.Windows.Forms.Panel PanelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AnswerB;
        private System.Windows.Forms.Panel PanelA;
        private System.Windows.Forms.Button ButtonEndGame;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ButtonRetry;
    }
}

