using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTournaments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tourName = textBox1.Text;
            int prizePool = Convert.ToInt32(textBox2.Text);
            var tournament = new Tournament(tourName, prizePool);
            var idDiscipline = Convert.ToInt32(textBox3.Text);
            Program.AddTournament(tourName, prizePool, idDiscipline);
/*
            Button b = (Button)sender;
            Button temp = new Button();
            temp.Text = "Добавить команды";
            temp.Width = 150;
            temp.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
            //temp.Click += new EventHandler(...);
            this.Controls.Add(temp);
            */
            //Form2 form2 = new Form2();
            //form2.Show();
        }

    }
}
