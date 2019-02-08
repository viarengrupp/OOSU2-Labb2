using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSU2___Presentationslager
{
    public partial class LoggaIn : Form
    {
        public LoggaIn()
        {
            InitializeComponent();
        }

        private void loggaInButton_Click(object sender, EventArgs e)
        {
            Alumni alumni = new Alumni();
            alumni.Show();
            this.Hide();
        }


        private void anvandareNamnTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Make it possible to press enter when sign in
            if (e.KeyCode == Keys.Enter)
            {
                loggaInButton.PerformClick();
            }
        }

        private void anvandareLosenordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Make it possible to press enter when sign in
            if (e.KeyCode == Keys.Enter)
            {
                loggaInButton.PerformClick();
            }
        }
    }
}
