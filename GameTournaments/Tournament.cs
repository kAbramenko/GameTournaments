using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    public partial class Tournament
    {
        private readonly ICollection<Team> _teams = new List<Team>();
        public string Name { get; set; }
        public int PrizePool { get; set; }
        public GameDiscipline GameDiscipline { get; set; }
        public Tournament(string name, int prizepool)
        {
            Name = name;
            PrizePool = prizepool;
        }
        public Tournament(string name, int prizepool, int id)
        {
            Name = name;
            PrizePool = prizepool;
            GameDiscipline = (GameDiscipline)id;
        }
        public Tournament AddTeam(Team team)
        {
            _teams.Add(team);
            return team.Tournament = this;
        }

        public bool Contains(Team team)
        {
            foreach (var element in _teams)
            {
                if (element == team) return true;
            }
            return false;
        }

        public override string ToString()
        {
            var teamName = $"Tournament name: {Name}\nPrize pool:{PrizePool}$\nGame discipline:{GameDiscipline}\nTeams list: ";
            foreach (var elementTeam in _teams)
            {
                var team = elementTeam;
                if (_teams.Last() == elementTeam)
                {
                    teamName += team.Name + team.ToString() + ".";
                }
                else teamName += team.Name + team.ToString() + ", ";
            }
            return teamName;
        }
        public string TeamsToString()
        {
            var teamName = "Teams list: ";
            int numberTeam = 1;
            foreach (var elementTeam in _teams)
            {
                var team = elementTeam;
                teamName += Convert.ToString(numberTeam) + team.Name + "\n";
                numberTeam++;
            }
            return teamName;
        }
    }
}
