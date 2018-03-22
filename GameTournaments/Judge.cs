using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    class Judge
    {
        private string Name;
        private string Surname;
        private string GameDiscipline;
        private int Age;
        public Judge(string name, string surname, int age, string gameDiscipline)
        {
            Name = name;
            Surname = surname;
            Age = age;
            GameDiscipline = gameDiscipline;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nИгровая дисциплина: {GameDiscipline}\nВозраст: {Age}\n");
        }
    }
}
