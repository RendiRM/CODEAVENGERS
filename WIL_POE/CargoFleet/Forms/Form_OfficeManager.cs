using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFleet
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Form1()
        {
            InitializeComponent();
            panelWidth = panel_left_sidebar.Width;
            isCollapsed = false;
        }

        /*Nigel Mthombeni*/


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_left_sidebar.Width = panel_left_sidebar.Width + 10;
                if (panel_left_sidebar.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            } else
            {
                panel_left_sidebar.Width = panel_left_sidebar.Width - 10;
                if (panel_left_sidebar.Width <= 61)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }

            }
            }

            private void picClose_Click(object sender, EventArgs e)
            { 
                this.Close();
            }

        private void btnMenu_Click(object sender, EventArgs e)
        {//start the timer1 action execution....
            timer1.Start();

        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            this.picClose.BackColor = Color.IndianRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            this.picClose.BackColor = Color.White;
        }

        private void picMaximise_Click(object sender, EventArgs e)
        {   //When the window is maximized
            if(this.WindowState == FormWindowState.Maximized)
            {//return the windw to normal size under these parameters......
                this.WindowState = FormWindowState.Normal;



            }
        }

        private void panelSlide_Move(Control btn)
        {//slide panel moves
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_Home);
            if (!panel_main_floor.Controls.Add(uc_Dashboard1.Instance))
            {
                panel_main_floor.Controls.Add(uc_Dashboard1.Instance);
                uc_Dashboard1.Instance.Dock = DockStyle.Fill;
                uc_Dashboard1.Instance.BringToFront();
            }
            
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_Report);
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_Users);
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_Delivery);
        }

        private void btn_ViewClient_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_ViewClient);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_TripUsage fm = new Form_TripUsage();
            fm.Show();
            fm.BringToFront();
            this.Hide();
        }

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_main_subtop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            panelSlide_Move(btn_Schedule);
        }

        private void panel_left_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_userType_Click(object sender, EventArgs e)
        {

        }

        private void roofPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notificationsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cloPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MaxPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MinPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void lblReportBugs_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_userName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_userId_Click(object sender, EventArgs e)
        {

        }

        private void panel_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void notificaion_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel_main_floor_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
