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
    public partial class stdnt_club_dash : Form
    {
        public stdnt_club_dash()
        {
            InitializeComponent();

            st_Dashboard uc = new st_Dashboard();

            addUserControl(uc);
        }

        private void hobby_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new st_login_Form().Show();
            
        }

        private void stdnt_club_dash_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
        //to move the form>
        private bool dragg = false;
        private Point StartPoint = new Point(0, 0);

        private void stdnt_club_dash_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            StartPoint = new Point(e.X, e.Y);

        }

        private void stdnt_club_dash_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void stdnt_club_dash_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);

            }
        }
        //to move the form<
        //arranging the code to jump from one uc to another dependent UC

        

        static stdnt_club_dash _obj;
        public static stdnt_club_dash Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new stdnt_club_dash();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return container_panel;
            }
            set
            {
                container_panel = value;
            }
        }

        // to traverse through user controlss>
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
           // container_panel.Controls.Clear();
            container_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            _obj = this;
            st_Dashboard uc = new st_Dashboard();

           
            uc.Dock = DockStyle.Fill;   

            container_panel.Controls.Add(uc);

            uc.BringToFront();
            
        }
        
        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {
            //first we will check for two viable options, 1) if the stdnt is already a member, or 2) he isnt yet member
            _obj = this;

            //if he isnt a member yet(option 2) >
            UC_reg_cs uc_reg_cs= new UC_reg_cs();

            uc_reg_cs.Dock = DockStyle.Fill;

            container_panel.Controls.Add(uc_reg_cs);

            uc_reg_cs.BringToFront();

            //if he isnt a member yet(option 2)<

            //else another user control, main user control will open
        }

        private void iutds_button_Click(object sender, EventArgs e)
        {
            _obj = this;
            UC_reg_ds uc_reg_ds = new UC_reg_ds();

            uc_reg_ds.Dock = DockStyle.Fill;

            container_panel.Controls.Add(uc_reg_ds);

            uc_reg_ds.BringToFront();
        }

        private void iutps_button_Click(object sender, EventArgs e)
        {
            _obj = this;
            UC_reg_ps uc_reg_ps = new UC_reg_ps();

            uc_reg_ps.Dock = DockStyle.Fill;

            container_panel.Controls.Add(uc_reg_ps);

            uc_reg_ps.BringToFront();
        }

        private void iutsiks_Button_Click(object sender, EventArgs e)
        {
            _obj = this;
            UC_reg_siks uc_reg_siks = new UC_reg_siks();

            uc_reg_siks.Dock = DockStyle.Fill;

            container_panel.Controls.Add(uc_reg_siks);

            uc_reg_siks.BringToFront();
        }

        // to traverse through user controlss<
    }
}
