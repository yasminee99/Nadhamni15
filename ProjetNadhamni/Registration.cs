using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        

        private void exitReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_usernameReg_Click(object sender, EventArgs e)
        {
            txt_usernameReg.Clear();
        }

        private void txt_lastnameReg_Click(object sender, EventArgs e)
        {
            txt_lastnameReg.Clear();
        }

        private void txt_phoneReg_Click(object sender, EventArgs e)
        {
            txt_phoneReg.Clear();
        }

        private void txt_emailReg_Click(object sender, EventArgs e)
        {
            txt_emailReg.Clear();
        }

        private void txt_passwordReg_Click(object sender, EventArgs e)
        {
            txt_passwordReg.Clear();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
            
        }

        

       

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }
    }
}
