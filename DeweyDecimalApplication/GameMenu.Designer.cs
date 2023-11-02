namespace DeweyDecimalApplication
{
    partial class GameMenu
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
            this.GameOneBorder = new System.Windows.Forms.Panel();
            this.GameOneHeader = new System.Windows.Forms.Label();
            this.LeaderboardGameOne = new System.Windows.Forms.Button();
            this.GameOne = new System.Windows.Forms.Button();
            this.GameTwoBorder = new System.Windows.Forms.Panel();
            this.GameThreeBorder = new System.Windows.Forms.Panel();
            this.BarTab = new System.Windows.Forms.Panel();
            this.BackgroundMenu = new System.Windows.Forms.PictureBox();
            this.PlayGame2 = new System.Windows.Forms.Button();
            this.LeaderboardGame2 = new System.Windows.Forms.Button();
            this.labelGame2 = new System.Windows.Forms.Label();
            this.GameOneBorder.SuspendLayout();
            this.GameTwoBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // GameOneBorder
            // 
            this.GameOneBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameOneBorder.Controls.Add(this.GameOneHeader);
            this.GameOneBorder.Controls.Add(this.LeaderboardGameOne);
            this.GameOneBorder.Controls.Add(this.GameOne);
            this.GameOneBorder.Location = new System.Drawing.Point(76, 88);
            this.GameOneBorder.Name = "GameOneBorder";
            this.GameOneBorder.Size = new System.Drawing.Size(367, 565);
            this.GameOneBorder.TabIndex = 1;
            // 
            // GameOneHeader
            // 
            this.GameOneHeader.AutoSize = true;
            this.GameOneHeader.Font = new System.Drawing.Font("Papyrus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOneHeader.Location = new System.Drawing.Point(75, 36);
            this.GameOneHeader.Name = "GameOneHeader";
            this.GameOneHeader.Size = new System.Drawing.Size(209, 58);
            this.GameOneHeader.TabIndex = 1;
            this.GameOneHeader.Text = "Book Sort";
            // 
            // LeaderboardGameOne
            // 
            this.LeaderboardGameOne.Location = new System.Drawing.Point(49, 315);
            this.LeaderboardGameOne.Name = "LeaderboardGameOne";
            this.LeaderboardGameOne.Size = new System.Drawing.Size(266, 132);
            this.LeaderboardGameOne.TabIndex = 0;
            this.LeaderboardGameOne.Text = "Leaderboard";
            this.LeaderboardGameOne.UseVisualStyleBackColor = true;
            this.LeaderboardGameOne.Click += new System.EventHandler(this.LeaderboardGameOne_Click);
            // 
            // GameOne
            // 
            this.GameOne.Location = new System.Drawing.Point(49, 145);
            this.GameOne.Name = "GameOne";
            this.GameOne.Size = new System.Drawing.Size(266, 132);
            this.GameOne.TabIndex = 0;
            this.GameOne.Text = "Play";
            this.GameOne.UseVisualStyleBackColor = true;
            this.GameOne.Click += new System.EventHandler(this.GameOne_Click);
            // 
            // GameTwoBorder
            // 
            this.GameTwoBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameTwoBorder.Controls.Add(this.labelGame2);
            this.GameTwoBorder.Controls.Add(this.LeaderboardGame2);
            this.GameTwoBorder.Controls.Add(this.PlayGame2);
            this.GameTwoBorder.Location = new System.Drawing.Point(528, 88);
            this.GameTwoBorder.Name = "GameTwoBorder";
            this.GameTwoBorder.Size = new System.Drawing.Size(367, 565);
            this.GameTwoBorder.TabIndex = 1;
            // 
            // GameThreeBorder
            // 
            this.GameThreeBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameThreeBorder.Location = new System.Drawing.Point(969, 88);
            this.GameThreeBorder.Name = "GameThreeBorder";
            this.GameThreeBorder.Size = new System.Drawing.Size(367, 565);
            this.GameThreeBorder.TabIndex = 1;
            // 
            // BarTab
            // 
            this.BarTab.BackColor = System.Drawing.Color.Gold;
            this.BarTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarTab.Location = new System.Drawing.Point(0, 0);
            this.BarTab.Name = "BarTab";
            this.BarTab.Size = new System.Drawing.Size(1400, 55);
            this.BarTab.TabIndex = 2;
            // 
            // BackgroundMenu
            // 
            this.BackgroundMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundMenu.Image = global::DeweyDecimalApplication.Properties.Resources.w0554_1s_Small_Print_Teal_and_Green_Watercolor_Wallpaper_with_Vintage_Gold_Moroccan_Design_Quilted_Gems_Repeating_Pattern_Sample_1;
            this.BackgroundMenu.Location = new System.Drawing.Point(0, 0);
            this.BackgroundMenu.Name = "BackgroundMenu";
            this.BackgroundMenu.Size = new System.Drawing.Size(1400, 700);
            this.BackgroundMenu.TabIndex = 0;
            this.BackgroundMenu.TabStop = false;
            // 
            // PlayGame2
            // 
            this.PlayGame2.Location = new System.Drawing.Point(57, 145);
            this.PlayGame2.Name = "PlayGame2";
            this.PlayGame2.Size = new System.Drawing.Size(266, 132);
            this.PlayGame2.TabIndex = 0;
            this.PlayGame2.Text = "Play";
            this.PlayGame2.UseVisualStyleBackColor = true;
            this.PlayGame2.Click += new System.EventHandler(this.PlayGameTwo_Click);
            // 
            // LeaderboardGame2
            // 
            this.LeaderboardGame2.Location = new System.Drawing.Point(57, 315);
            this.LeaderboardGame2.Name = "LeaderboardGame2";
            this.LeaderboardGame2.Size = new System.Drawing.Size(266, 132);
            this.LeaderboardGame2.TabIndex = 0;
            this.LeaderboardGame2.Text = "Leaderboard";
            this.LeaderboardGame2.UseVisualStyleBackColor = true;
            this.LeaderboardGame2.Click += new System.EventHandler(this.LeaderboardGameOne_Click);
            // 
            // labelGame2
            // 
            this.labelGame2.AutoSize = true;
            this.labelGame2.Font = new System.Drawing.Font("Papyrus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame2.Location = new System.Drawing.Point(38, 36);
            this.labelGame2.Name = "labelGame2";
            this.labelGame2.Size = new System.Drawing.Size(285, 58);
            this.labelGame2.TabIndex = 1;
            this.labelGame2.Text = "Matching Game";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.BarTab);
            this.Controls.Add(this.GameThreeBorder);
            this.Controls.Add(this.GameTwoBorder);
            this.Controls.Add(this.GameOneBorder);
            this.Controls.Add(this.BackgroundMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.GameOneBorder.ResumeLayout(false);
            this.GameOneBorder.PerformLayout();
            this.GameTwoBorder.ResumeLayout(false);
            this.GameTwoBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundMenu;
        private System.Windows.Forms.Panel GameOneBorder;
        private System.Windows.Forms.Label GameOneHeader;
        private System.Windows.Forms.Button LeaderboardGameOne;
        private System.Windows.Forms.Button GameOne;
        private System.Windows.Forms.Panel GameTwoBorder;
        private System.Windows.Forms.Panel GameThreeBorder;
        private System.Windows.Forms.Panel BarTab;
        private System.Windows.Forms.Label labelGame2;
        private System.Windows.Forms.Button LeaderboardGame2;
        private System.Windows.Forms.Button PlayGame2;
    }
}