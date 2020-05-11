using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();
        }

        private void Action_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name2.Text))
            {
                Output.Text = "Hello, world!";
            }
            else
            {
                Output.Text = "Hello, " + Name2.Text+"!";
            }
        }
    }
}
