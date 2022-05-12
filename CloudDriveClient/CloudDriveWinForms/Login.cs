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
    public partial class Login : Form
    {
        private Register register;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GoRegister_click(object sender, EventArgs e)
        {
            register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.LoginEmail.Text);
            Console.WriteLine(this.LoginPassword.Text);
            this.InfoLabel.Text = this.LoginEmail.Text + this.LoginPassword.Text;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*var window = MessageBox.Show(
        "Close the window?",
        "Are you sure?",
        MessageBoxButtons.YesNo);*/
            e.Cancel=true; 
        }
    }
}
