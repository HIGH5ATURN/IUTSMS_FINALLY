using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    public partial class UC_reg_cs : UserControl
    {
        public UC_reg_cs()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void UC_reg_cs_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;

            if (pbar.Value == 100)
            {
                //now will add the student in the student list of IUTCS 
                timer1.Stop();
                MessageBox.Show("Congrats! You're now a member of IUTCS");
                
                
                UC_iutcs_st_page uc_st_page = new UC_iutcs_st_page();

                uc_st_page.Dock = DockStyle.Fill;

                stdnt_club_dash.Instance.PnlContainer.Controls.Add(uc_st_page);

                stdnt_club_dash.Instance.PnlContainer.Controls["UC_iutcs_st_page"].BringToFront();


            }
        }
        private void Join_Button_Click(object sender, EventArgs e)
        {
            
            this.timer1.Start();
        }
    }
}
