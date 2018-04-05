using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    class ListTournaments
    {
        private List<Tournament> listTournaments = new List<Tournament>();

        public void AddTournament(string tourName, int prizePool, int idDiscipline)
        {
            var tournament = new Tournament(tourName, prizePool);
            tournament.GameDiscipline = (GameDiscipline)idDiscipline;
            listTournaments.Add(tournament);
        }

        public Tournament Get(int id)
        {
            return listTournaments[id];
        }

        public int Count()
        {
            return listTournaments.Count();
        }
    }
}
