using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    class Player
    {
        public string Name;
        public string Surname;
        public string NickName;
        public DateTime Age;
        public Team Team { get; set; }
        public enum GameDiscipline { Dota, CS }
        public Player(string name, string surname, string nickname, DateTime age, string gameDiscipline)
        {
            Name = name;
            Surname = surname;
            NickName = nickname;
            Age = age;
           // GameDiscipline = gameDiscipline;
        }

        public Player()
        {
            
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nНикнейм: {NickName}\nВозраст: {GetAge(Age)}Команда: {Team?.Name ?? "нет"}\n";
        }

        private int GetAge(DateTime date)
        {
            var nowDate = DateTime.Now.Year;
            var age = nowDate - date.Year;
            return age;
        }
    }
}
