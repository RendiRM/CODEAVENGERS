using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFleet.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            lbl_required1.Hide();
            lbl_required2.Hide();
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {// Submit Login
            string username = "Nigel@admin";
            string password = "Mthombeni";


            if (txt_Username.Text.Trim().Equals(username) && txt_Password.Text.Trim().Equals(password))
            {//Business Rule usertype depicted by username e.g. Tyson@trip_manager 
                
                

                
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {// Cancel
            this.Dispose();
        }

        private void picMinimise_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void picMinimise_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }
        private void picClose_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }



    }
}
