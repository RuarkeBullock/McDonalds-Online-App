using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
        private object refresh;

        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //inputing sounds
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
                soundPlayer.Play();

                // inputs
                burgers = (int)Convert.ToDouble(burgersOutput.Text);
                fries = (int)Convert.ToDouble(friesOutput.Text);
                drinks = (int)Convert.ToDouble(drinksOutput.Text);
                //calculating totals
                subTotal = burgers * 4.50 + fries * 2.13 + drinks * 1.45;
                taxAmount = subTotal * 0.13;
                total = subTotal + taxAmount;

                subTotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                subTotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
            }
        }


        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //inputing sounds
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
                soundPlayer.Play();
                cashTendered = Convert.ToDouble(cashTenderdOutput.Text);

                change = cashTendered - total;
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                change = cashTendered - total;
                changeOutput.Text = $"ERROR";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //inputing sounds
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Sharp_Punch_SoundBible_com_1947392621__1_);
            soundPlayer.Play();

                        
                //inputing my data
                receiptLabel.Text += $"\nOrderNumber #{order++}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nseptember 25th, 2024";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nBurgers  x{burgers}                    $4.50";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nFries   x{fries}                       $2.13";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nDrinks  x{drinks}                      $1.45";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\n\nsubtotal         {subTotal.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\ntax              {taxAmount.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\ntotal            {total.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\ntendered         {cashTendered.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\nchange           {change.ToString("C")}";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.Text += $"\n\n Thanks For Coming To McDonalds!! Have A Great Day!";
           

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Sharp_Punch_SoundBible_com_1947392621__1_);
            soundPlayer.Play();

            //clearing my outputs
            burgersOutput.Text = $"";
            friesOutput.Text = $"";
            drinksOutput.Text = $"";
            receiptLabel.Text = $"";
            subTotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            cashTenderdOutput.Text = $"";
            changeOutput.Text = $"";
            
        }
    }
}