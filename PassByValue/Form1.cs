/*
 * Created by: Jadon Fournier
 * Created on: 8-May-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Temperature Converter
 * This program converts °C to °F
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConvertToF(double degreesC)
        {
            //local variables
            double degreesF;
            string StringF;

            //convert
            degreesF = (double)(9) / (double)(5) * degreesC + 32;

            StringF = Convert.ToString(degreesF);

            //message
            MessageBox.Show(txtInput.Text + "°C converted into Fahrenheit is " + StringF + "°F", "Conversion");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            double userDegrees;

            //convert to double
            userDegrees = Convert.ToDouble(txtInput.Text);

            //call function
            ConvertToF(userDegrees);
        }
    }
}
