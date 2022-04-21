using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudDriveWinForms
{
    public partial class Register : Form
    {
        private Login login;
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
