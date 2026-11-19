using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YEKE
{
    public partial class Form1 : Form
    {

        double totalD = 0;
        double totalE = 0;
        double totalF = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string name = "";

            if (salesInitial == "D")
            {
                totalD += salesAmount;
                name = "Danielle";
            }
            else if (salesInitial == "E")
            {
                totalE += salesAmount;
                name = "Edward";
            }
            else if (salesInitial == "F")
            {
                totalF += salesAmount;
                name = "Fatima";
            }
            else
            {
                lblDisplay.Text = "Invalid code. Use D, E, or F.";
                return;
            }
            lblDisplay.Text = "Sale recorded for " + name + "." + Environment.NewLine +
                "Amount: " + salesAmount + Environment.NewLine +
                "Danielle (D): " + totalD + Environment.NewLine +
                "Edward (E): " + totalE + Environment.NewLine +
                "Fatima (F): " + totalF;


        }

        private void clearEntry()
        {
            txtSalesInitial.Text = "";
            txtSalesAmount.Text = "";
            lblDisplay.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(txtSalesAmount.Text, out amount))
            {
                getSalesPerson_Amount(txtSalesInitial.Text.ToUpper(), amount);
            }
            else
            {
                MessageBox.Show("Please enter a number for the amount.");

            }
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "Danielle (D): " + totalD + Environment.NewLine +
             "Edward (E): " + totalE + Environment.NewLine +
             "Fatima (F): " + totalF,
             "Summary Report");
        }
    }
}
