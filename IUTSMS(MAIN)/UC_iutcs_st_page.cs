using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    public partial class UC_iutcs_st_page : UserControl
    {
        public UC_iutcs_st_page()
        {
            InitializeComponent();
        }


        //adding databse-->
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source = dbst.accdb");

        OleDbCommand cmd = new OleDbCommand();

        // OleDbDataAdapter da = new OleDbDataAdapter();


        private void btn_course_enroll_Click(object sender, EventArgs e)
        {
            string f;
            if(cmb_enroll.Text== "JAVA lang. Course")
            {
                f = "java";
                gunaGradientTileButton1.Enabled = true;
            }
            else if(cmb_enroll.Text== "Competitive Programming Course")
            {
                f = "cp";
                btn_rcs_cp.Enabled = true;

            }
            else
            {
                f = "WebDev";
                btn_rcs_web.Enabled = true;
            }
            try
            {


                conn.Open();

                string g = "-1";
                string t = "UPDATE cs_table set "+f+"="+g+"";

                cmd = new OleDbCommand(t, conn);
              
                cmd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Enrolled into"+cmb_enroll.Text+" !");

              
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_iutcs_st_page_Load(object sender, EventArgs e)
        {
            try
            {


                conn.Open();

                
                string t = "SELECT * FROM cs_table where st_id="+st_login_Form.id+"";

                cmd = new OleDbCommand(t, conn);

                OleDbDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {

                    MessageBox.Show($"{dr["java"].ToString()}\t{dr["cp"].ToString()}\t{dr["WebDev"].ToString()}");
                    
                    
                    
                    if(dr["java"].ToString()=="True")
                    {
                        gunaGradientTileButton1.Enabled= true;

                    }
                    if(dr["cp"].ToString()=="True")
                    {
                        btn_rcs_cp.Enabled= true;
                    }
                    if(dr["WebDev"].ToString()=="True")
                    {
                        btn_rcs_web.Enabled= true;
                    }
                   
                }

                conn.Close();


                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=java+language+tutorial+for+beginners+");
        }

        private void btn_rcs_cp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=OMcxQ3IY-qc&list=PLauivoElc3ggagradg8MfOZreCMmXMmJ-");
        }

        private void btn_rcs_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=l1EssrLxt7E&list=PLfqMhTWNBTe3H6c9OGXb5_6wcc1Mca52n");
        }

        private void fb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/IUTCS");
        }
    }
}
