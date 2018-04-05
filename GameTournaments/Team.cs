using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    class Team
    {
        readonly ICollection<Player> _players = new List<Player>();
        public string Name { get; set; }
        //private GameDiscipline _gameDiscipline;
        public Tournament Tournament { get; set; }
        public Team(string name)
        {
            Name = name;
            //_gameDiscipline = gameDiscipline;
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
            string name = "(";
            foreach (Player elementPlayer in _players)
            {
                var player = elementPlayer;
                if (_players.Last() == elementPlayer)
                {
                    name += player.NickName + ")";
                }
                else name += player.NickName  + ", ";
            }

            return _players.Count == 0 ? " (В команде отсутствуют игроки)" : name;
        }
    }
}