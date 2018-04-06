using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameTournaments
{
    public class Program
    {
        static List<Tournament> listTournaments = new List<Tournament>();
        static void Main()
        {
            var mainInterface = new Interface();
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
                        //listTournaments.Add(mainInterface.CreateTournament());
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
                            listTournaments[listTournaments.Count - 1] = listTournaments[listTournaments.Count - 1].AddTeam(mainInterface.AddTeam(listTournaments[listTournaments.Count - 1], countPlayers));
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
    }
}
