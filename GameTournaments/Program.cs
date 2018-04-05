using System;
using System.Collections.Generic;
using System.Linq;

namespace GameTournaments
{
    class Program
    {
        static void Main()
        {
            //List<Judge> listJudge= new List<Judge>();
            //Judge judge1 = new Judge("Alex", "Lex", 20, "Dota");
            //Player[] Players;
            //listJudge.Add(judge1);
            //judge1.ShowInfo();
            //int count = Convert.ToInt32(Console.ReadLine());
            //Players = CreateListPlayers(count);
            //ShowListPlayers(Players);
            /* Team asdf = CreateTestTeam("Komanda", GameDiscipline.Dota);
             Team asdfg = CreateTestTeamNull("KomandaB", GameDiscipline.Cs);
             Tournament tour = new Tournament("Turnir", 128000);
             tour.AddTeam(asdf);
             tour.AddTeam(asdfg);
             Console.WriteLine(tour.ToString());
             Console.WriteLine(asdf.ToString());
             Console.WriteLine(asdfg.ToString());
             Interface adminCreateTour = new Interface();
             Tournament tournamentTest = adminCreateTour.CreateTournament();
            // Console.WriteLine(tourna.ToString());*/
            var listTournaments = new List<Tournament>();
            var mainInterface = new Interface();
            //listTournaments.Add(mainInterface.CreateTournament());
            //listTournaments[0] = listTournaments[0].AddTeam(mainInterface.AddTeam(listTournaments[0], 1));
            //listTournaments[0] = listTournaments[0].AddTeam(mainInterface.AddTeam(listTournaments[0], 2));
            //Console.WriteLine(listTournaments[0].ToString());
            int caseSwitch = -1;
            while (caseSwitch != 0)
            {
                Console.WriteLine("1. Создать новый турнир");
                Console.WriteLine("2. Последний турнир");
                Console.WriteLine("3. Все турниры");
                Console.WriteLine("4. Выбрать турнир");

                caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        listTournaments.Add(mainInterface.CreateTournament());
                        Console.WriteLine("Введите количество команд: ");
                        int countPlayers = 0;
                        int countTeams = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < countTeams; i++)
                        {
                            Console.WriteLine("Введите количество игроков в команде: ");
                            countPlayers = Convert.ToInt32(Console.ReadLine());
                            listTournaments[listTournaments.Count - 1] = listTournaments[listTournaments.Count - 1].AddTeam(mainInterface.AddTeam(listTournaments[listTournaments.Count - 1], countPlayers));
                        }

                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        if (listTournaments.Count > 0)
                        {
                            Console.WriteLine(listTournaments[listTournaments.Count - 1].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Турнир не найден");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Case 3");
                        foreach (var element in listTournaments)
                        {
                            Console.WriteLine(element.ToString());
                        }

                        if (listTournaments.Count == 0)
                        {
                            Console.WriteLine("Турниры не найдены");
                        }
                        break;
                    case 4:
                        int numberTour = 0;
                        if (listTournaments.Count == 0)
                        {
                            Console.WriteLine("Турниры не найдены");
                            break;
                        }

                        Console.WriteLine("Список турниров:");
                        foreach (var element in listTournaments)
                        {
                            Console.WriteLine(++numberTour + ") " + element.Name);
                        }
                        numberTour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(listTournaments[numberTour - 1].ToString());
                        if (listTournaments.Count == 0)
                        {
                            Console.WriteLine("Турниры не найдены");
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            Console.ReadLine();
        }

        public static Team CreateTestTeam(string teamName, GameDiscipline discipline)
        {
            var team = new Team(teamName);
            team.AddPlayer(new Player("Kirill", "Abramenko", "DecadE", new DateTime(1998, 08, 12)));
            team.AddPlayer(new Player("Danil", "Ivanov", "Hook", new DateTime(1995, 12, 05)));
            return team;
        }
        public static Team CreateTestTeamNull(string teamName, GameDiscipline discipline)
        {
            var team = new Team(teamName);
            return team;
        }

        public static Player[] CreateListPlayers(int count)
        {
            Player[] players = new Player[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Заполнение информации. Игрок номер {i + 1}");
                Console.Write($"#Имя:");
                players[i] = new Player { Name = Console.ReadLine() };
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
