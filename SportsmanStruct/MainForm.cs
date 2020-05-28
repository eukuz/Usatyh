using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsmanStruct
{
    public partial class MainForm : Form
    {
        Sportsman[] sportsmen = new Sportsman[7];
        int lastId = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void winsNUD_ValueChanged(object sender, EventArgs e)
        {

            internationalWinsNUD.Maximum = winsNUD.Value;
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            if (lastId == 7)
            {
                MessageBox.Show("Система предусмотрена только на 7 спортсменов, больше ввести нельзя!");
            }
            else
            {
                sportsmen[lastId++] = new Sportsman
                {
                    name = nameTB.Text,
                    Age = (int)ageNUD.Value,
                    bestResult = bestResultNUD.Value,
                    NumberOfWins = (int)winsNUD.Value,
                    NumberOfInternationalWins = (int)internationalWinsNUD.Value
                };

                UpdateList();
            }
        }

        private void UpdateList()
        {
            sportsmenLB.Items.Clear();
            for (int i = 0; i < lastId; i++)
            {
                sportsmenLB.Items.Add($"{sportsmen[i].name} {sportsmen[i].Age} лет, лучший результат: {sportsmen[i].bestResult} сек., {sportsmen[i].GetSportsCategory()}, {sportsmen[i].GetInternationalClass()}");
            }
        }
    }
}
