using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsmanView
{
    public partial class SportsmanViewForm : Form
    {
        int numberOfResults = 1;
        Sportsman[] sportsmen; 
        public SportsmanViewForm()
        {
            InitializeComponent();

            string[] input;


            if (File.Exists("спортсмены.txt"))
            {
                input = File.ReadAllLines("спортсмены.txt");
                sportsmen = new Sportsman[input.Length];
            }
            else
            {
                MessageBox.Show("Файл не найден");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                string[] sportsmanData = input[i].Split(';');
                try
                {
                    sportsmen[i].name = sportsmanData[0];
                    sportsmen[i].Age = Convert.ToInt32(sportsmanData[1]);
                    sportsmen[i].bestResult = Convert.ToDecimal(sportsmanData[2]);
                    sportsmen[i].NumberOfWins = Convert.ToInt32(sportsmanData[3]);
                    sportsmen[i].NumberOfInternationalWins = Convert.ToInt32(sportsmanData[4]);
                }
                catch (Exception)
                {

                    MessageBox.Show($"В {i}-й строке файла ввода данных ошибка записи числа");
                }
                PrintToDGV();

            }
        }

        private void PrintToDGV()
        {
            sportsmenDGV.Rows.Clear();
            foreach (Sportsman s in sportsmen)
            {
                sportsmenDGV.Rows.Add(s.name, s.Age, s.bestResult, s.NumberOfWins, s.NumberOfInternationalWins);
            }
        }

        private void printToFileBtn_Click(object sender, EventArgs e)
        {
            string result = string.Format("{0,-10}{1,-10}{2,-20}{3,-20}{4,-25}", "Имя", "Возраст", "Лучший результат", "Кол-во побед", "Кол-во побед на международ. соревнованиях");
            using (StreamWriter sw = new StreamWriter($@"Результат {numberOfResults++}.txt"))
            {

                for (int i = 0; i < sportsmenDGV.Rows.Count-1; i++)
                {
                    result+="\r\n"+ string.Format("{0,-10}{1,-10}{2,-20}{3,-20}{4,-25}", 
                        sportsmenDGV.Rows[i].Cells[0].Value,
                        sportsmenDGV.Rows[i].Cells[1].Value,
                        sportsmenDGV.Rows[i].Cells[2].Value,
                        sportsmenDGV.Rows[i].Cells[3].Value,
                        sportsmenDGV.Rows[i].Cells[4].Value);
                }
                sw.WriteLine(result);

            }
        }

        private void showEverybodyBtn_Click(object sender, EventArgs e)
        {
            PrintToDGV();
        }

        private void sortByNameBtn_Click(object sender, EventArgs e)
        {
            Sportsman s;
            for (int i = 0; i < sportsmen.Length; i++)
                for (int j = 0; j < sportsmen.Length-1; j++)
                    if(sportsmen[j].name.CompareTo(sportsmen[j+1].name) == 1)
                    {
                        s = sportsmen[j];
                        sportsmen[j] = sportsmen[j + 1];
                        sportsmen[j + 1] = s;
                    }
            PrintToDGV();
        }

        private void selectByNumberOfWinsBtn_Click(object sender, EventArgs e)
        {
            sportsmenDGV.Rows.Clear();
            foreach (Sportsman s in sportsmen)
                if (s.NumberOfWins == (int)winsNUD.Value)
                    sportsmenDGV.Rows.Add(s.name, s.Age, s.bestResult, s.NumberOfWins, s.NumberOfInternationalWins);

        }
    }
}
    

