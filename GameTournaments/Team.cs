using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    class Team
    {
        ICollection<Player> _players = new List<Player>();
        public string Name { get; set; }
        private GameDiscipline _gameDiscipline;
        public Tournament Tournament { get; set; }
        public Team(string name, GameDiscipline gameDiscipline)
        {
            Name = name;
            _gameDiscipline = gameDiscipline;
        }

        public Team()
        {
        }
      
        public void AddPlayer(Player player)
        {
            _players.Add(player);
            player.Team = this;
        }
        public override string ToString()
        {
            string name = "";
            foreach (Player elementPlayer in _players)
            {
                var player = elementPlayer;
                name += player.Name.ToString() + " ";
            }

            return _players.Count == 0 ? "В команде отсутствуют игроки" : name;
        }
    }
}