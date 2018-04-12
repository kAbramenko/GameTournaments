using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameTournaments
{
    public class Program
    {
        public static int countTeams;
        public static int countPlayers;
        public static List<Tournament> listTournaments = new List<Tournament>();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            /*
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
                        Console.Write("Введите название турнира: ");
                        string tourName = Console.ReadLine();
                        Console.Write("Введите призовой фонд (валюта $): ");
                        int prizePool = Convert.ToInt32(Console.ReadLine());
                        var tournament = new Tournament(tourName, prizePool);
                        Console.WriteLine("Выберите дисциплину из списка:");
                        Console.WriteLine("0 - Dota 2");
                        Console.WriteLine("1 - CS:GO");
                        var idDiscipline = Convert.ToInt32(Console.ReadLine());
                        AddTournament(tourName, prizePool, idDiscipline);
                        Console.WriteLine("Введите количество команд: ");
                        int countPlayers = 0;
                        int countTeams = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < countTeams; i++)
                        {
                            Console.WriteLine("Введите количество игроков в команде: ");
                            countPlayers = Convert.ToInt32(Console.ReadLine());
                            InterfaceAddTeam(listTournaments[listTournaments.Count - 1], countPlayers);
                        }
                        break;
                    case 2:
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

        public static void AddTournament(string tourName, int prizePool, int idDiscipline)
        {
            var tournament = new Tournament(tourName, prizePool);
            tournament.GameDiscipline = (GameDiscipline)idDiscipline;
            listTournaments.Add(tournament);
        }
        public static void InterfaceAddTeam(Tournament tour, int count)
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
            listTournaments.Add(tour);*/
        }
    }
}
