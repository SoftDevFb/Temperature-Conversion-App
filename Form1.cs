using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       04/16/2018
/// Assignment: Proj8TempConversation
/// Purpose:    Converts Fahrenheit to Celcius
/// </summary>
namespace Proj8TempConversation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double C;
            double F;

            //Take string from F and convert to double for calculation
            F = double.Parse(txtFahrenheit.Text);
            //Conversion Calculation
            C = 5.0 / 9.0 * (F - 32);
            //Convert C back to a string
            lblCelcius.Text = C.ToString();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears Celcius
            lblCelcius.Text = "";
            //Clears Fahrenheit
            txtFahrenheit.Text = "";
            //Takes focus back to fahrenheit textbox
            txtFahrenheit.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes app
            Close();
        }
    }
}
