using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTournaments
{
    public partial class MainForm : Form
    {
        BindingList<Tournament> _tournaments = new BindingList<Tournament>();
        BindingList<Team> _teams = new BindingList<Team>();
        BindingList<Player> _players = new BindingList<Player>();

        public MainForm()
        {
            InitializeComponent();
            listBox1.DataSource = _tournaments;
            listBox2.DataSource = _teams;
            listBox3.DataSource = _players;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tourName = textBox1.Text;
            int prizePool = Convert.ToInt32(textBox2.Text);
            var tournament = new Tournament(tourName, prizePool);
            var idDiscipline = Convert.ToInt32(textBox3.Text);
            AddTournament(tourName, prizePool, idDiscipline);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tournaments.Remove((Tournament)listBox1.SelectedItem);
        }
        private void AddTournament(string tourName, int prizePool, int idDiscipline)
        {
            var tournament = new Tournament(tourName, prizePool);
            tournament.GameDiscipline = (GameDiscipline)idDiscipline;
            _tournaments.Add(tournament);
        }
        
        private void AddTeam(Tournament tour)
        {
            var team = new Team
            {
                Name = textBox6.Text,
                Tournament = tour
            };
            tour.AddTeam(team);
            _teams.Add(team);
        }

        private void AddPlayer()
        {
            var player = new Player(textBoxName.Text, textBoxSurname.Text, textBoxNickname.Text, Convert.ToDateTime(textBoxDate.Text));
            var team = (Team)listBox2.SelectedItem;
            team.AddPlayer(player);
            listBox2.SelectedItem = team;
            _players.Add(player);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Сначала создайте или выберете турнир!");
            }
            else  AddTeam((Tournament)listBox1.SelectedItem);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((Team)listBox2.SelectedItem).Info());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _teams.Remove((Team)listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPlayer();
            listBox2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _players.Remove((Player)listBox3.SelectedItem);
        }

        private void listBox3_DoubleClick_1(object sender, EventArgs e)
        {
            MessageBox.Show(((Player)listBox3.SelectedItem).Info());
        }
    }
}
