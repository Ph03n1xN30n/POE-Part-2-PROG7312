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
    public partial class OpeningScreen : Form
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu();

            //gameMenu.Activate();
            gameMenu.Show();
            Task.Delay(2000).Wait();
            this.Hide();

            
        }
    }
}
