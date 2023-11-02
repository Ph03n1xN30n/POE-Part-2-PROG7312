namespace DeweyDecimalApplication
{
    partial class BookSortGame
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
            this.BarTab = new System.Windows.Forms.Panel();
            this.ExitGame = new System.Windows.Forms.Button();
            this.PlayGame = new System.Windows.Forms.Button();
            this.StopClock = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BarTab
            // 
            this.BarTab.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BarTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarTab.Location = new System.Drawing.Point(0, 0);
            this.BarTab.Name = "BarTab";
            this.BarTab.Size = new System.Drawing.Size(1800, 49);
            this.BarTab.TabIndex = 0;
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(12, 55);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(191, 87);
            this.ExitGame.TabIndex = 1;
            this.ExitGame.Text = "Back";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.Lime;
            this.PlayGame.Image = global::DeweyDecimalApplication.Properties.Resources.play1;
            this.PlayGame.Location = new System.Drawing.Point(618, 627);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(434, 161);
            this.PlayGame.TabIndex = 2;
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // StopClock
            // 
            this.StopClock.AutoSize = true;
            this.StopClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopClock.Location = new System.Drawing.Point(791, 52);
            this.StopClock.Name = "StopClock";
            this.StopClock.Size = new System.Drawing.Size(146, 69);
            this.StopClock.TabIndex = 3;
            this.StopClock.Text = "0:00";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // BookSortGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1800, 800);
            this.Controls.Add(this.StopClock);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.BarTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookSortGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSortGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarTab;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Label StopClock;
        private System.Windows.Forms.Timer gameTimer;
    }
}