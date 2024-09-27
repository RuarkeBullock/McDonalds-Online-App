using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds_Online_App
{
    public partial class Form1 : Form
    {
        //global variables
        double burgers;
        double fries;
        double drinks;
        double subTotal;
        double tax;
        double taxAmount;
        double total;

        public object SoundPlayer { get; private set; }

        double cashTendered;
        double change;
        double order = 1;
        private object sp;

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

        private void calculateButton_Click(object sender, EventArgs e)
        {


            burgers = (int)Convert.ToDouble(burgersOutput.Text);
            fries = (int)Convert.ToDouble(friesOutput.Text);
            drinks = (int)Convert.ToDouble(drinksOutput.Text);

            subTotal = burgers * 4.50 + fries * 2.13 + drinks * 1.45;
            taxAmount = subTotal * 0.13;
            total = subTotal + taxAmount;

            subTotalOutput.Text = $"{subTotal.ToString("C")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{total.ToString("C")}";
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
            soundPlayer.Play();
            cashTendered = Convert.ToDouble(cashTenderdOutput.Text);

            if (cashTendered >= total)
            {
                ;
            }
            change = cashTendered - total;
            changeOutput.Text = $"{change.ToString("C")}";
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text += $"\nOrderNumber #{order++}";
            receiptLabel.Text += $"\nseptember 25th, 2024";
            receiptLabel.Text += $"\nBurgersx                      {burgers}$4.50";
            receiptLabel.Text += $"\nFries                          x{fries}$2.13";
            receiptLabel.Text += $"\nDrinks                        x{drinks}$1.45";
            receiptLabel.Text += $"\n\nsubtotal         {subTotal.ToString    ("C")}";
            receiptLabel.Text += $"\ntax              {taxAmount.ToString   ("C")}";
            receiptLabel.Text += $"\ntotal            {total.ToString       ("C")}";
            receiptLabel.Text += $"\ntendered         {cashTendered.ToString("C")}";
            receiptLabel.Text += $"\nchange           {change.ToString      ("C")}";
            receiptLabel.Text += $"\n\n Thanks For Coming To McDonalds!! Have A Great Day!";
        }


    }
}