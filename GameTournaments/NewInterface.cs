    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace GameTournaments
    {
        class NewInterface
        {
            public NewInterface()
            {
            }
            public Tournament CreateTournament()
            {
                Console.Write("Введите название турнира: ");
                string tourName = Console.ReadLine();
                Console.Write("Введите призовой фонд (валюта $): ");
                int prizePool = Convert.ToInt32(Console.ReadLine());
                var tournament = new Tournament(tourName, prizePool);
                Console.WriteLine("Выберите дисциплину из списка:");
                Console.WriteLine("0 - Dota 2");
                Console.WriteLine("1 - CS:GO");
                var idDiscipline = Convert.ToInt32(Console.ReadLine());
                tournament.GameDiscipline = (GameDiscipline)idDiscipline;
                return tournament;
            }

             public void InterfaceAddTeam(Tournament tour, int count)
            {
                Console.Write("Введите название команды: ");
                string teamName = Console.ReadLine();
                var team = new Team
                {
                    Name = teamName,
                    Tournament = tour
                };
                 string surName = "";
                 string nickName = "";
                 string name = "";
                 DateTime age;
                for (var i = 0; i < count; i++)
                {
                    Console.WriteLine($"Заполнение информации. Игрок номер {i + 1}");
                    Console.Write($"#Имя:");
                    name = Console.ReadLine();
                    Console.Write($"#Фамилия:");
                    surName = Console.ReadLine();
                    Console.Write($"#Никнейм:");
                    nickName = Console.ReadLine();
                    Console.Write($"#Дата рождения:");
                    age = Convert.ToDateTime(Console.ReadLine());
                    var player = new Player(name, surName, nickName, age);
                    team.AddPlayer(player);
                }
               tour.AddTeam(team);
               Program.listTournaments.Add(tour);
            }
        }
    }
