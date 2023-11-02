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
    public partial class LeaderBoardScreen : Form
    {
        public LeaderBoardScreen()
        {
            InitializeComponent();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu();
            this.Dispose();
            gameMenu.Show();
        }
    }
}
