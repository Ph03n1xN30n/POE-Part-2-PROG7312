using Game_2_Dictionary;
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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void GameOne_Click(object sender, EventArgs e)
        {
            BookSortGame bookSortGame = new BookSortGame();
            bookSortGame.Show();
            Task.Delay(2000).Wait();
            this.Hide();
        }

        private void LeaderboardGameOne_Click(object sender, EventArgs e)
        {
            LeaderBoardScreen leaderBoardScreen = new LeaderBoardScreen();
            leaderBoardScreen.Show();
            Task.Delay(2000).Wait();
            this.Hide();
            //Create form to open The Leader Board 
        }

        private void PlayGameTwo_Click(object sender, EventArgs e)
        {
            MatchingGame matchingGame = new Game_2_Dictionary.MatchingGame(); 
            matchingGame.Show();
            Task.Delay(2000).Wait();
            this.Hide();
        }
    }
}
