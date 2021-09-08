using System;
using System.Windows.Forms;

namespace Synth
{
    public partial class Form_Profile : Form
    {
        public Form_Profile()
        {
            InitializeComponent();
        }

        private void Form_Profile_Load(object sender, EventArgs e)
        {
            Label_Username.Text = User.Username;
            Textbox_Name.Text = User.Name;
            Textbox_Phone.Text = User.Phone;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Yes.Checked)
            {
                GroupBox_Password.Enabled = true;
            }
            else
            {
                GroupBox_Password.Enabled = false;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (Textbox_Name.Text.Trim() == "")
            {
                Label_Incorrect.Text = "Name cannot be empty";
            }
            else
            {
                User.Name = Textbox_Name.Text;
                User.Phone = Textbox_Phone.Text;
            }

            if (RadioButton_Yes.Checked)
            {
                if (User.Password != Textbox_Old.Text || Textbox_New.Text.Trim() == "" || Textbox_New.Text != Textbox_Confirm.Text)
                {
                    Label_Incorrect.Text = "Passwords are incorrect";
                }
                else
                {
                    User.Password = Textbox_New.Text;
                }
            }

            if (Label_Incorrect.Text == "")
            {
                User.UpdateProfile();
                this.Close();
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
