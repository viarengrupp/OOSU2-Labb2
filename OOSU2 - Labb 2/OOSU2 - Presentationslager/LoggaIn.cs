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
            anvandareNamnTextBox.Focus();
            
        }
    }
}
