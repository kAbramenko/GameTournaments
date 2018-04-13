using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GameTournaments
{
    public partial class MainForm : Form
    {
        BindingList<Tournament> _tournaments = new BindingList<Tournament>();
        Tournament _currentTournament = null;
        Team _currentTeam = null;

        public MainForm()
        {
            InitializeComponent();
           
            tournamentNameText.Validating += tournamentNameText_Validating;
            tournamentPrizepoolText.Validating += tournamentPrizepoolText_Validating;
            tournamentGameDisciplineText.Validating += tournamentGameDisciplineText_Validating;

            teamNameText.Validating += textBox6_TextChanged;

            Init();

            addTournamentButton.Enabled = false;
            addTeamButton.Enabled = false;
            AddPlayerButton.Enabled = false;
        }
        private bool IsNumberContains(string input)
        {
            foreach (char c in input)
            {
                if (Char.IsNumber(c) == false) return false;
            }
            return true;
        }

        private void tournamentNameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tournamentNameText.Text))
            {
                errorProvider1.SetError(tournamentNameText, "Не указано имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
            addTournamentButton.Enabled = string.IsNullOrEmpty(errorProvider1.GetError(tournamentNameText));
        }

        private void tournamentPrizepoolText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tournamentPrizepoolText.Text))
            {
                errorProvider1.SetError(tournamentPrizepoolText, "Не указан призовой фонд!");
            } else if (IsNumberContains(tournamentPrizepoolText.Text) == false)
            {
                errorProvider1.SetError(tournamentPrizepoolText, "Данная строка может содержать только цифры!");

            }
            else
            {
                errorProvider1.Clear();
            }
            addTournamentButton.Enabled = string.IsNullOrEmpty(errorProvider1.GetError(tournamentPrizepoolText));
        }
        private void tournamentGameDisciplineText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tournamentGameDisciplineText.Text))
            {
                errorProvider1.SetError(tournamentGameDisciplineText, "Укажите игровую дисциплину!");
            } else if (IsNumberContains(tournamentGameDisciplineText.Text) == false)
            {
                errorProvider1.SetError(tournamentGameDisciplineText, "Данная строка может содержать только цифры!");
            }
            else
            {
                errorProvider1.Clear();
            }
            addTournamentButton.Enabled = string.IsNullOrEmpty(errorProvider1.GetError(tournamentGameDisciplineText));
        }


        private void Init()
        {
            listBoxTournaments.DataSource = _tournaments;
            listBoxTeams.DataSource = _currentTournament?.GetTeams();
            listBoxPlayers.DataSource = _currentTeam?.GetPlayers();
        }

        private void Check()
        {
            if (listBoxTournaments.SelectedIndex < 0)
            {
                listBoxTeams.Enabled = false;
                listBoxPlayers.Enabled = false;
            }
        }

        private void addTournamentButton_Click(object sender, EventArgs e)
        {
                string tourName = tournamentNameText.Text;
                int prizePool = Convert.ToInt32(tournamentPrizepoolText.Text);
                var tournament = new Tournament(tourName, prizePool);
                var idDiscipline = Convert.ToInt32(tournamentGameDisciplineText.Text);
                AddTournament(tourName, prizePool, idDiscipline);
                Check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tournaments.Remove((Tournament)listBoxTournaments.SelectedItem);
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            _currentTournament = (Tournament) listBoxTournaments.SelectedItem;
            Init();
        }
        private void AddTournament(string tourName, int prizePool, int idDiscipline)
        {
            var tournament = new Tournament(tourName, prizePool);
            tournament.GameDiscipline = (GameDiscipline)idDiscipline;
            _tournaments.Add(tournament);
            listBoxTournaments.SelectedItem = _tournaments.FirstOrDefault();
            _currentTournament = (Tournament) listBoxTournaments.SelectedItem;
        }
        
        private void AddTeam(Tournament tour)
        {
            var team = new Team
            {
                Name = teamNameText.Text,
                Tournament = tour
            };
            _currentTournament.AddTeam(team);
        }

        private void AddPlayer()
        {
            var player = new Player(playerNameText.Text, playerSurnameText.Text, playerNicknameText.Text, Convert.ToDateTime(playerDateText.Text));
            var team = (Team)listBoxTeams.SelectedItem;
            listBoxTeams.SelectedItem = team;
            _currentTeam.AddPlayer(player);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxTournaments.SelectedIndex < 0)
            {
                MessageBox.Show(@"Сначала создайте или выберите турнир!");
            }
            else
            {
                AddTeam((Tournament)listBoxTournaments.SelectedItem);
                _currentTeam = (Team)listBoxTeams.SelectedItem;
                Init();
            }
        }

        private void listBoxTeams_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(((Team)listBoxTeams.SelectedItem).Info());
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            Init();
        }


        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if((Team)listBoxTeams.SelectedItem != null) _currentTournament.RemoveTeam((Team)listBoxTeams.SelectedItem);
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            _currentTournament = (Tournament)listBoxTournaments.SelectedItem;
            Init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (playerNameText.Text.Length < 1 || playerSurnameText.Text.Length < 1) MessageBox.Show(@"!!!");
            AddPlayer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((Player)listBoxPlayers.SelectedItem != null) _currentTeam.RemovePlayer((Player)listBoxPlayers.SelectedItem);
        }

        private void listBoxPlayers_DoubleClick_1(object sender, EventArgs e)
        {
            MessageBox.Show(((Player)listBoxPlayers.SelectedItem).Info());
        }

        private void listBoxTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTournament = (Tournament)listBoxTournaments.SelectedItem;
            listBoxTeams.SelectedItem = _currentTournament?.GetTeams().FirstOrDefault();
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(teamNameText.Text))
            {
                errorProvider1.SetError(teamNameText, "Не указано имя команды!");
            }
            else
            {
                errorProvider1.Clear();
            }
            addTeamButton.Enabled = string.IsNullOrEmpty(errorProvider1.GetError(teamNameText));
        }

        private void playerNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tournamentNameText_Leave(object sender, EventArgs e)
        {

        }

    }
}
