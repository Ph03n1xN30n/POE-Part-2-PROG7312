
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalApplication
{
    
    public partial class BookSortGame : Form
    {
        //Iterate through each CardHolder and allow enter function
          private List<Panel> BookHolder = new List<Panel>();
          private Book Book = new Book();
          

          private bool isDragging = false;
          private bool isEntered = false;

        //Never Used Cases of Class BookManager
        //private Panel bookPanel;
        //private BookManager bookManager;    

        private Point offset;
        private int maxTimeSet = 30;
        private Panel currentPanel = null;
//============================================================================
        public BookSortGame()
        {
            InitializeComponent();
        }
//================================================================================
        private void PlayGame_Click(object sender, EventArgs e)
        {
            //Game Play Hide Button start game and set time/ stop watch to true make stop watch
            this.PlayGame.Hide();
            this.gameTimer.Enabled = true;
            this.gameTimer.Start();

            GeneratePanels();

        }

        #region
//==================================================================================================================================
        private void GeneratePanels()
        {
            int screenWidth = this.Width;
            int initialPosition = screenWidth / 10;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    //Rename it for the sake of proper programming ethics
                    Panel panel = new Panel();
                    panel.Visible = true;
                    panel.BackColor = Color.DarkGray;
                    panel.Width = 120;
                    panel.Height = 200;


                    panel.Location = new Point((initialPosition * i), 150);
                    panel.Name = i.ToString();

                    panel.BorderStyle = BorderStyle.FixedSingle;
                    Label label = new Label();


                    //Generate CallNumber Here
                    label.Text = Book.GenerateRadomCallNumber();
                    label.Size = new Size(90, 20);
                    label.Location = new Point(30, panel.Height / 2);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(label);

                    panel.DragDrop += Panel_DragDrop;
                    panel.MouseEnter += Panel_MouseEnter;
                    panel.MouseDown += Panel_MouseDown;
                    panel.MouseMove += Panel_MouseMove;
                    panel.MouseUp += Panel_MouseUp;


                    
                    this.Controls.Add(panel);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
        #region
        //==================================================================================================================================
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            if (!e.Equals(null))
            {
                isEntered = true;
            }
            else
            {
                isEntered = false;
            }
            //throw new NotImplementedException();
        }
//==================================================================================================================================
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                currentPanel = null;
            }
        }
//==================================================================================================================================
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && isEntered.Equals(true))
            {
                Point newLocation = this.PointToClient(MousePosition);
                newLocation.Offset(-offset.X, -offset.Y);
                currentPanel.Location = newLocation;
            }
        }
//==================================================================================================================================
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPanel = (Panel)sender;
                offset = new Point(e.X, e.Y);
                isDragging = true;
            }
        }
//==================================================================================================================================
        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion
//=============================================================================
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            maxTimeSet--;
            StopClock.Text = string.Format( "{0}:{1:D2}","0", maxTimeSet.ToString());
            if (maxTimeSet == 0)
            {
                this.gameTimer.Stop();
                maxTimeSet = 30;
                EndGame();
                

            }
        }
//========================================================================================================================
       private void RestartGame()
        {
                
            this.PlayGame.Show();   
        }
//==========================================================================================================================
        private void EndGame()
        {
            this.Invalidate();
            DialogResult result = MessageBox.Show("Time Has Gone Want to Start Again!", "Heading", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartGame();
            }else if(result == DialogResult.No)
            {
                GameMenu gameMenu = new GameMenu();
                this.Dispose();
                gameMenu.Show();
            } 
        }
//===========================================================================================================================
        private void ExitGame_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu();
            this.Dispose();
            gameMenu.Show();
        }
    }
}
