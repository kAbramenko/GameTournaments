using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    partial class Tournament
    {
        private readonly ICollection<Team> _teams = new List<Team>();
        public string Name { get; set; }
        public int PrizePool;
        public Tournament(string name, int prizepool)
        {
            Name = name;
            PrizePool = prizepool;
        }
        public void AddTeam(Team team)
        {
            _teams.Add(team);
            team.Tournament = this;
        }
        public override string ToString()
        {
            var teamName = $"Tournament name: {Name}\nTeams list:";
            foreach (var elementTeam in _teams)
            {
                var team = elementTeam;
                if (_teams.Last() == elementTeam)
                {
                    teamName += team.Name + ".";
                }
                else teamName += team.Name + ", ";
            }
            return teamName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ PrizePool.GetHashCode();
        }

        public void TestFunction()
        {
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if(obj is Tournament t)
            {
                return t.Name == Name &&
                       t.PrizePool == PrizePool;
            }

            return false;
        }
    }
}
