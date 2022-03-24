using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class BestPlayersForm : Form
    {
        public BestPlayersForm(FootballClub[] clubs, int goals)
        {
            InitializeComponent();
            labelGoals.Text = goals.ToString();
            foreach (FootballClub club in clubs)
            {
                listBoxClubs.Items.Add(FootballClubInfo.GetName(club));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
