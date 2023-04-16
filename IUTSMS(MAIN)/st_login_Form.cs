using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IUTSMS_MAIN_
{
    public partial class st_login_Form : Form
    {
        public st_login_Form()
        {
            InitializeComponent();
        }

        private void st_login_Form_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void register_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Student_Form().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_pass_textBox.UseSystemPasswordChar)
            {
                login_pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                login_pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
        }

        private void st_login_button_Click(object sender, EventArgs e)
        {
            //when password matched-->
            new stdnt_club_dash().Show();
            this.Hide();
        }
    }
}
