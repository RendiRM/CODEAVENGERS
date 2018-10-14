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
    public partial class Form_TripUsage : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Form_TripUsage()
        {
            InitializeComponent();
            panelWidth = panel_left_sidebar.Width;
            isCollapsed = false;
        }

        public void PanelSlide_Move(Control btn)
        {//formular for slide panel 
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {//slide panel value
            PanelSlide_Move(btn_Home);
        }

        private void btn_ViewClient_Click(object sender, EventArgs e)
        {//slide panel value
            PanelSlide_Move(btn_ViewClient);
        }

        private void btn_Vehicles_Click(object sender, EventArgs e)
        {//slide panel value
            PanelSlide_Move(btn_Vehicles);

        }

        private void btn_AllocateTrips_Click(object sender, EventArgs e)
        {//slide panel value
            PanelSlide_Move(btn_AllocateTrips);

        }

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
            }
            else
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
            this.Dispose();
        }

        private void picMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.IndianRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.White;
        }

        private void picMinimise_MouseHover(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.LightGray;
        }

        private void picMinimise_MouseLeave(object sender, EventArgs e)
        {
            picMinimise.BackColor = Color.White;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            PanelSlide_Move(btn_Report);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
