using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTournaments
{
    public class Player
    {
        public string Name { get; }
        public string Surname { get; }
        public string NickName { get; }
        public DateTime BirthDay { get; }
        public int Age => DateTime.Now.Year - BirthDay.Year - (IsFullYear ? 0 : 1);
        private bool IsFullYear => DateTime.Now.Month > BirthDay.Month || 
            DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day >= BirthDay.Day;
        public Team Team { get; set; }
        public GameDiscipline GameDiscipline { get; set; }
        public Player(string name, string surname, string nickname, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            NickName = nickname;
            BirthDay = birthDay;
        }

        public Player()
        {
            
        }

        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nНикнейм: {NickName}\nВозраст: {Age}\nКоманда: {Team?.Name ?? "нет"}\n";
        }

    }
}
