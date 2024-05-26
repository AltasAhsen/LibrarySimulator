using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulator2
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void no_account_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); 
            Form2 register = new Form2();
            register.Show();

        }
    }



}
