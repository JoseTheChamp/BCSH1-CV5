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
    public partial class PlayerForm : Form
    {
        public String PlayerName => textBoxJmeno.Text;
        public FootballClub Club => (FootballClub)comboBoxKlub.SelectedItem;
        public int Goals => int.Parse(textBoxGoals.Text);

        public PlayerForm() { 
        InitializeComponent();
            foreach (var item in FootballClubInfo.Items)
            {
                comboBoxKlub.Items.Add(item);
            }
        }

        public PlayerForm(string name,FootballClub club, int goals) {
            InitializeComponent();
            foreach (var item in FootballClubInfo.Items)
            {
                comboBoxKlub.Items.Add(item);
            }
            textBoxJmeno.Text = name;
            comboBoxKlub.SelectedItem = club;
            textBoxGoals.Text = goals.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxGoals.Text,out int goals))
            {
                MessageBox.Show("Góly musí být v oboru přirozených čísel.");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonStorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
