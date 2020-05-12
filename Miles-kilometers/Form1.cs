using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miles_kilometers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Convert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Mil.Text))
            {
                String data="";
                try
                {
                    double temp = Math.Round(Double.Parse(Mil.Text)*1.609344,2);
                    data = temp + " km";
                }
                catch
                {
                    data = "Error: Enter numeric data";
                }
                Kilo.Text = data;
            }
        }
    }
}
