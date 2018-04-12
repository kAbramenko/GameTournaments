using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    public class Team
    {
        private readonly ICollection<Player> _players = new List<Player>();
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

        public bool Contains(Player player)
        {
            foreach (var element in _players)
            {
                if (element == player) return true;
            }
            return false;
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
            player.Team = this;
        }
        public string ToStringInfo()
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

            return _players.Count == 0 ? $"(В команде {Name} отсутствуют игроки)" : name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    
        public string Info()
        {
            string playersNames = ToStringInfo();
            return $"Команда {Name} учавствует в турнире {Tournament.Name}\nСписок игроков: {playersNames}";
        }
    }
}