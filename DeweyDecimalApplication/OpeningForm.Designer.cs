namespace DeweyDecimalApplication
{
    partial class OpeningScreen
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.BorderTab = new System.Windows.Forms.Panel();
            this.BackroundPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(219, 129);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(700, 76);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Dewey Decimal Place";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(344, 402);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(443, 179);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BorderTab
            // 
            this.BorderTab.BackColor = System.Drawing.Color.Chartreuse;
            this.BorderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTab.Location = new System.Drawing.Point(0, 0);
            this.BorderTab.Name = "BorderTab";
            this.BorderTab.Size = new System.Drawing.Size(1206, 43);
            this.BorderTab.TabIndex = 2;
            // 
            // BackroundPicture
            // 
            this.BackroundPicture.BackgroundImage = global::DeweyDecimalApplication.Properties.Resources._30231;
            this.BackroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackroundPicture.Name = "BackroundPicture";
            this.BackroundPicture.Size = new System.Drawing.Size(1206, 626);
            this.BackroundPicture.TabIndex = 3;
            this.BackroundPicture.TabStop = false;
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 626);
            this.Controls.Add(this.BorderTab);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.BackroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpeningScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BackroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel BorderTab;
        private System.Windows.Forms.PictureBox BackroundPicture;
    }
}

