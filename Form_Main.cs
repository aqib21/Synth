using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Synth
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (User.Is_Admin)
            {
                Panel_Admin.Visible = true;
            }
            else
            {
                Panel_Admin.Visible = false;
                this.Size = new Size(800, 300);
            }
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            User.User_ID = 0;
            User.Name = null;
            User.Username = null;
            User.Is_Admin = false;

            Application.OpenForms["Form_Login"].Show();

            List<Form> openForms = new();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Form_Login")
                    f.Close();
            }
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Form_Profile>().Any())
            {
                Form_Profile form_Profile = new();
                form_Profile.Show();
            }
            else
            {
                Application.OpenForms["Form_Profile"].BringToFront();
            }
        }

        private void Button_Retrieve_Click(object sender, EventArgs e)
        {

        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
            {
                Form_SalesAddEdit form_SalesAddEdit = new(0, null);
                form_SalesAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_SalesAddEdit"].BringToFront();
            }
        }

        private void Button_Staff_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Form_StaffManagement>().Any())
            {
                Form_StaffManagement form_StaffManagement = new();
                form_StaffManagement.Show();
            }
            else
            {
                Application.OpenForms["Form_StaffManagement"].BringToFront();
            }
        }

        private void Button_Sales_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Form_SalesManagement>().Any())
            {
                Form_SalesManagement form_SalesManagement = new();
                form_SalesManagement.Show();
            }
            else
            {
                Application.OpenForms["Form_SalesManagement"].BringToFront();
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Agent_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Form_AgentManagement>().Any())
            {
                Form_AgentManagement form_AgentManagement = new();
                form_AgentManagement.Show();
            }
            else
            {
                Application.OpenForms["Form_AgentManagement"].BringToFront();
            }
        }
    }
}
