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
            tournamentNameText.Validated += ValidatedTournament;
            tournamentPrizepoolText.Validated += ValidatedTournament;
            tournamentGameDisciplineText.Validated += ValidatedTournament;

            teamNameText.Validating += teamNameText_Validating;
            teamNameText.Validated += ValidatedTeam;

            playerNameText.Validating += playerNameText_Validating;
            playerSurnameText.Validating += playerSurnameText_Validating;
            playerNicknameText.Validating += playerNicknameText_Validating;
            playerDateText.Validating += playerDateText_Validating;
            playerNameText.Validated += ValidatedPlayer;
            playerSurnameText.Validated+= ValidatedPlayer;
            playerNicknameText.Validated += ValidatedPlayer;
            playerDateText.Validated += ValidatedPlayer;

            Init();

            addTournamentButton.Enabled = false;
            addTeamButton.Enabled = false;
            addPlayerButton.Enabled = false;
        }

        private  void ValidatedTournament(object sender, EventArgs e)
        {
            bool checkTournament = false;
            if ((String.IsNullOrEmpty(errorProvider1.GetError(tournamentNameText))) &&
                (String.IsNullOrEmpty(errorProvider1.GetError(tournamentGameDisciplineText))) &&
                (String.IsNullOrEmpty(errorProvider1.GetError(tournamentPrizepoolText))))
            {
                if (!String.IsNullOrWhiteSpace(tournamentNameText.Text))
                {
                    if (!String.IsNullOrWhiteSpace(tournamentGameDisciplineText.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(tournamentPrizepoolText.Text))
                        {
                            checkTournament = true;
                        }
                    }
                }
            }
            addTournamentButton.Enabled = checkTournament;
        }

        private void ValidatedTeam(object sender, EventArgs e)
        {
            bool checkTeam = false;
            if (String.IsNullOrEmpty(errorProvider1.GetError(tournamentNameText)))
            {
                if (!String.IsNullOrWhiteSpace(teamNameText.Text))
                {
                    checkTeam = true;
                }

            }
            addTeamButton.Enabled = checkTeam;
        }

        private void ValidatedPlayer(object sender, EventArgs e)
        {
            bool checkPlayer = false;
            if ((String.IsNullOrEmpty(errorProvider1.GetError(playerNameText))) &&
                (String.IsNullOrEmpty(errorProvider1.GetError(playerSurnameText))) &&
                (String.IsNullOrEmpty(errorProvider1.GetError(playerNicknameText))) &&
                (String.IsNullOrEmpty(errorProvider1.GetError(playerDateText))))
            {
                if (!String.IsNullOrWhiteSpace(playerNameText.Text))
                {
                    if (!String.IsNullOrWhiteSpace(playerSurnameText.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(playerNicknameText.Text))
                        {
                            if (!String.IsNullOrWhiteSpace(playerDateText.Text))
                            {
                                checkPlayer = true;
                            }
                        }
                    }
                }
            }
            addPlayerButton.Enabled = checkPlayer;
        }

        private void tournamentNameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tournamentNameText.Text))
            {
                errorProvider1.SetError(tournamentNameText, "Не указано имя!");
            }
            else
            {
                errorProvider1.SetError(tournamentNameText, string.Empty);
            }
        }

        private void tournamentPrizepoolText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tournamentPrizepoolText.Text) || IsNumberContains(tournamentPrizepoolText.Text) == false)
            {
                errorProvider1.SetError(tournamentPrizepoolText, "Область может содержать только цифры");
            }
            else
            {
                errorProvider1.SetError(tournamentPrizepoolText, string.Empty);
            }
        }
        private void tournamentGameDisciplineText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tournamentGameDisciplineText.Text) || IsNumberContains(tournamentGameDisciplineText.Text) == false)
            {
                errorProvider1.SetError(tournamentGameDisciplineText, "Укажите номер игровой дисциплины");
            } 
            else
            {
                errorProvider1.SetError(tournamentGameDisciplineText, string.Empty);
            }
        }
        private void teamNameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(teamNameText.Text))
            {
                errorProvider1.SetError(teamNameText, "Название команды не может быть пустым!");
            }
            else
            {
                errorProvider1.SetError(teamNameText, string.Empty);
            }
        }
        private void playerNameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(playerNameText.Text))
            {
                errorProvider1.SetError(playerNameText, "Имя игрока не может быть пустым!");
            }
            else
            {
                errorProvider1.SetError(playerNameText, string.Empty);
            }
        }
        private void playerSurnameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(playerSurnameText.Text))
            {
                errorProvider1.SetError(playerSurnameText, "Фамилия игрока не может быть пустым!");
            }
            else
            {
                errorProvider1.SetError(playerSurnameText, string.Empty);
            }
        }
        private void playerNicknameText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(playerNicknameText.Text))
            {
                errorProvider1.SetError(playerNicknameText, "Никнейм игрока не может быть пустым!");
            }
            else
            {
                errorProvider1.SetError(playerNicknameText, string.Empty);
            }
        }
        private void playerDateText_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(playerDateText.Text) || IsDateContains(playerDateText.Text) == false)
            {
                errorProvider1.SetError(playerDateText, "Введите дату рождения в формате ДД.ММ.ГГГГ!");
            }
            else
            {
                errorProvider1.SetError(playerDateText, string.Empty);
            }
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

        private void removeTournamentButton_Click(object sender, EventArgs e)
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

        private void addTeamButton_Click(object sender, EventArgs e)
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
            if (listBoxTeams.SelectedItem != null)
            {
                MessageBox.Show(((Team)listBoxTeams.SelectedItem).Info());

            }
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

        private void removeTeamButton_Click(object sender, EventArgs e)
        {
            if((Team)listBoxTeams.SelectedItem != null) _currentTournament.RemoveTeam((Team)listBoxTeams.SelectedItem);
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            _currentTournament = (Tournament)listBoxTournaments.SelectedItem;
            Init();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            if ((Player)listBoxPlayers.SelectedItem != null) _currentTeam.RemovePlayer((Player)listBoxPlayers.SelectedItem);
        }

        private void listBoxPlayers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem != null)
            {
                MessageBox.Show(((Player)listBoxPlayers.SelectedItem).Info());
            }
        }

        private void listBoxTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTournament = (Tournament)listBoxTournaments.SelectedItem;
            listBoxTeams.SelectedItem = _currentTournament?.GetTeams();
            _currentTeam = (Team)listBoxTeams.SelectedItem;
            Init();
        }

        private void tournamentNameText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void teamNameText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void playerNameText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }
        private void tournamentPrizepoolText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void tournamentGameDisciplineText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void playerSurnameText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void playerNicknameText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void playerDateText_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private bool IsNumberContains(string input)
        {
            foreach (char c in input)
            {
                if (Char.IsNumber(c) == false) return false;
            }
            return true;
        }
        private bool IsDateContains(string input)
        {
            Regex regex = new Regex(@"^(((0[1-9]|[12]\d|3[01])\.(0[13578]|1[02])\.((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\.(0[13456789]|1[012])\.((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\.02\.((19|[2-9]\d)\d{2}))|(29\.02\.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$");
            Match match = regex.Match(input);
            if (match.Success)
            {
                return true;
            }
            else return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
