    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace GameTournaments
    {
        class Interface
        {
            public Interface()
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

             public Team AddTeam(Tournament tour, int count)
            {
                Console.Write("Введите название команды: ");
                string teamName = Console.ReadLine();
                var team = new Team
                {
                    Name = teamName,
                    Tournament = tour
                };
                for (var i = 0; i < count; i++)
                {
                    Console.WriteLine($"Заполнение информации. Игрок номер {i + 1}");
                    Console.Write($"#Имя:");
                    var player = new Player { Name = Console.ReadLine() };
                    Console.Write($"#Фамилия:");
                    player.Surname = Console.ReadLine();
                    Console.Write($"#Никнейм:");
                    player.NickName = Console.ReadLine();
                    Console.Write($"#Дата рождения:");
                    player.Age = Convert.ToDateTime(Console.ReadLine());
                    team.AddPlayer(player);
                }
                return team;
            }
        }
    }
