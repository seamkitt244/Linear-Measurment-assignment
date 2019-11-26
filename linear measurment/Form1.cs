using System;
using System.Windows.Forms;

namespace linear_measurment
{
    public partial class outputLabel : Form
    {
        public outputLabel()
        {
            InitializeComponent();
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(inputTextBox.Text);
            if (InchesToCentimeters.Checked)
            {
                double firstinput = input,cent = InToCent(input);
                upLabel.Text = firstinput + " inches  = " + cent.ToString(".##") + " cm";
            }
            else if (FeetToCentimeters.Checked)
            {
                double firstinput = input,cent2 = FtToCent(input);
                upLabel.Text = firstinput + " ' = " + cent2.ToString(".##") + " cm";
            }
            else if (YardsToMeters.Checked)
            {
                double firstinput = input,meter = YdToM(input);
                upLabel.Text = firstinput + " yd = " + meter.ToString(".##") + " m";
            }
            else 
            {
                double firstinput = input,kilo = MiToKm(input);
                upLabel.Text = firstinput + " Mi = " + kilo.ToString(".##") + " Km";
            }
        }
        private double InToCent(double cent)
        {
            return (cent * 2.54);
        }
        private double FtToCent(double cent2)
        {
            return (cent2 * 30.48);
        }
        private double YdToM(double meter)
        {
            return (meter * 0.91) ;
        }
        private double MiToKm (double kilo)
        {
            return (kilo * 1.609);
        }
    }
}
