using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPricing
{
    public partial class CalculateForm : Form
    {
        private decimal FinalPrice;
        private decimal mealPrice = 1200;
        private decimal swimPrice = 1000;
        private decimal unlimitedDrinksPrice = 2000;

        List<RoomType> roomTypes;


        public CalculateForm()
        {
            InitializeComponent();

            roomTypes = new List<RoomType>
            {
                new RoomType(0, "Одиночный", 2000,  2000+ mealPrice * 3 + unlimitedDrinksPrice),
                new RoomType(1, "Двойной", 4000,  4000 + mealPrice * 3 + unlimitedDrinksPrice),
                new RoomType(2, "Королевский", 5000, 5000 +mealPrice * 3 + unlimitedDrinksPrice)
            };

            roomTypesLB.DataSource = roomTypes;
            roomTypesLB.DisplayMember = "Text";
            roomTypesLB.ValueMember = "Id";



        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int days = (int)residenceWeeksNUD.Value * 7;
            RoomType selectedType = roomTypes[(int)roomTypesLB.SelectedValue];
            if (allInclusiveCB.Checked)
            {
                FinalPrice = days * selectedType.AllInclusivePrice + swimPrice;
            }
            else
            {
                FinalPrice = days * selectedType.RoomPrice;

                if (swimmingPoolCB.Checked)
                    FinalPrice += swimPrice;
                if (twoTimesRB.Checked)
                    FinalPrice += mealPrice * days;
                if (threeTimesRB.Checked)
                    FinalPrice += mealPrice * 2 * days;
            }

            finalPriceLbl.Text = $"Итоговая стоимость: {FinalPrice} руб.";
        }

        private void allInclusiveCB_CheckedChanged(object sender, EventArgs e)
        {
            if (allInclusiveCB.Checked)
            {
                threeTimesRB.Checked = true;
                swimmingPoolCB.Checked = true;
                complementaryFoodCB.Checked = true;
                complementaryFoodCB.Enabled = false;
                foodGB.Enabled = false;
                swimmingPoolCB.Enabled = false;
            }
            else
            {
                threeTimesRB.Checked = false;
                swimmingPoolCB.Checked = false;
                complementaryFoodCB.Checked = false;
                complementaryFoodCB.Enabled = true;
                swimmingPoolCB.Enabled = true;
            }
        }

        private void complementaryFoodCB_CheckedChanged(object sender, EventArgs e)
        {
            if (complementaryFoodCB.Checked)
            {
                foodGB.Enabled = true;
            }
            else
            {
                twoTimesRB.Checked = false;
                threeTimesRB.Checked = false;
                foodGB.Enabled = false;
            }
        }
    }
}
