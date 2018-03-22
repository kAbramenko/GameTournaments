using System;

namespace GameTournaments
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Judge> listJudge= new List<Judge>();
            //Judge judge1 = new Judge("Alex", "Lex", 20, "Dota");
            //Player[] Players;
            //listJudge.Add(judge1);
            //judge1.ShowInfo();
            //int count = Convert.ToInt32(Console.ReadLine());
            //Players = CreateListPlayers(count);
            //ShowListPlayers(Players);
            Team asdf = CreateTestTeam("Komanda", GameDiscipline.Dota);
            Team asdfg = CreateTestTeamNull("KomandaB", GameDiscipline.Cs);
            Tournament tour = new Tournament("Turnir", 128000);
            tour.AddTeam(asdf);
            tour.AddTeam(asdfg);
            asdf.NicknamesToString();
            Console.WriteLine(tour.TeamsToString());
            Console.WriteLine(asdf.NicknamesToString());
            Console.WriteLine(asdfg.NicknamesToString());
            Console.ReadLine();
        }

        public static Team CreateTestTeam(string teamName, GameDiscipline discipline)
        {
            var team = new Team(teamName, discipline);
            team.AddPlayer(new Player("Kirill", "Abramenko", "DecadE", new  DateTime(1998,08,12), "CS"));
            team.AddPlayer(new Player("Danil", "Ivanov", "Hook", new DateTime(1995, 12, 05), "CS"));
            return team;
        }
        public static Team CreateTestTeamNull(string teamName, GameDiscipline discipline)
        {
            var team = new Team(teamName, discipline);
            return team;
        }

        public static Player[] CreateListPlayers(int count)
        {
            Player[] players = new Player[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Заполнение информации. Игрок номер {i + 1}");
                Console.Write($"#Имя:");
                players[i] = new Player {Name = Console.ReadLine()};
                Console.Write($"#Фамилия:");
                players[i].Surname = Console.ReadLine();
                Console.Write($"#Никнейм:");
                players[i].NickName = Console.ReadLine();
            }
            return players;
        }
        public static void ShowListPlayers(Player[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                Console.Write($"Игрок номер {i + 1}");
                Console.WriteLine($"{players[i].Name}");
            }
        }
    }
}
