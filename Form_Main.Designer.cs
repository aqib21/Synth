
namespace Synth
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Label_Logout = new System.Windows.Forms.Label();
            this.Button_Logout = new System.Windows.Forms.Button();
            this.Button_Profile = new System.Windows.Forms.Button();
            this.Label_Profile = new System.Windows.Forms.Label();
            this.Panel_Admin = new System.Windows.Forms.Panel();
            this.Button_Customer = new System.Windows.Forms.Button();
            this.Label_Customer = new System.Windows.Forms.Label();
            this.Button_Staff = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_Staff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Retrieve = new System.Windows.Forms.Button();
            this.Label_Retrieve = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.Label_Insert = new System.Windows.Forms.Label();
            this.Panel_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Logout
            // 
            this.Label_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Logout.AutoSize = true;
            this.Label_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Logout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Logout.Location = new System.Drawing.Point(728, 28);
            this.Label_Logout.Name = "Label_Logout";
            this.Label_Logout.Size = new System.Drawing.Size(47, 17);
            this.Label_Logout.TabIndex = 0;
            this.Label_Logout.Text = "Logout";
            this.Label_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Button_Logout
            // 
            this.Button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.Button_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Logout.BackgroundImage")));
            this.Button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Logout.FlatAppearance.BorderSize = 0;
            this.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Logout.Location = new System.Drawing.Point(697, 24);
            this.Button_Logout.Name = "Button_Logout";
            this.Button_Logout.Size = new System.Drawing.Size(25, 25);
            this.Button_Logout.TabIndex = 1;
            this.Button_Logout.UseVisualStyleBackColor = false;
            this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            // 
            // Button_Profile
            // 
            this.Button_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Button_Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Profile.BackgroundImage")));
            this.Button_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Profile.FlatAppearance.BorderSize = 0;
            this.Button_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Profile.Location = new System.Drawing.Point(608, 24);
            this.Button_Profile.Name = "Button_Profile";
            this.Button_Profile.Size = new System.Drawing.Size(25, 25);
            this.Button_Profile.TabIndex = 4;
            this.Button_Profile.UseVisualStyleBackColor = false;
            this.Button_Profile.Click += new System.EventHandler(this.Button_Profile_Click);
            // 
            // Label_Profile
            // 
            this.Label_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Profile.AutoSize = true;
            this.Label_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Profile.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Profile.Location = new System.Drawing.Point(639, 28);
            this.Label_Profile.Name = "Label_Profile";
            this.Label_Profile.Size = new System.Drawing.Size(44, 17);
            this.Label_Profile.TabIndex = 3;
            this.Label_Profile.Text = "Profile";
            this.Label_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Profile.Click += new System.EventHandler(this.Button_Profile_Click);
            // 
            // Panel_Admin
            // 
            this.Panel_Admin.Controls.Add(this.Button_Customer);
            this.Panel_Admin.Controls.Add(this.Label_Customer);
            this.Panel_Admin.Controls.Add(this.Button_Staff);
            this.Panel_Admin.Controls.Add(this.label8);
            this.Panel_Admin.Controls.Add(this.Label_Staff);
            this.Panel_Admin.Controls.Add(this.label7);
            this.Panel_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Admin.Location = new System.Drawing.Point(0, 207);
            this.Panel_Admin.Name = "Panel_Admin";
            this.Panel_Admin.Size = new System.Drawing.Size(784, 254);
            this.Panel_Admin.TabIndex = 5;
            this.Panel_Admin.Visible = false;
            // 
            // Button_Customer
            // 
            this.Button_Customer.BackColor = System.Drawing.Color.Transparent;
            this.Button_Customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Customer.BackgroundImage")));
            this.Button_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Customer.FlatAppearance.BorderSize = 0;
            this.Button_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Customer.Location = new System.Drawing.Point(303, 74);
            this.Button_Customer.Name = "Button_Customer";
            this.Button_Customer.Size = new System.Drawing.Size(100, 100);
            this.Button_Customer.TabIndex = 18;
            this.Button_Customer.UseVisualStyleBackColor = false;
            this.Button_Customer.Click += new System.EventHandler(this.Button_Customer_Click);
            // 
            // Label_Customer
            // 
            this.Label_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Customer.AutoSize = true;
            this.Label_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Customer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Customer.Location = new System.Drawing.Point(303, 177);
            this.Label_Customer.MaximumSize = new System.Drawing.Size(100, 0);
            this.Label_Customer.MinimumSize = new System.Drawing.Size(100, 0);
            this.Label_Customer.Name = "Label_Customer";
            this.Label_Customer.Size = new System.Drawing.Size(100, 34);
            this.Label_Customer.TabIndex = 17;
            this.Label_Customer.Text = "Customer Management";
            this.Label_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Customer.Click += new System.EventHandler(this.Button_Customer_Click);
            // 
            // Button_Staff
            // 
            this.Button_Staff.BackColor = System.Drawing.Color.Transparent;
            this.Button_Staff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Staff.BackgroundImage")));
            this.Button_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Staff.FlatAppearance.BorderSize = 0;
            this.Button_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Staff.Location = new System.Drawing.Point(123, 74);
            this.Button_Staff.Name = "Button_Staff";
            this.Button_Staff.Size = new System.Drawing.Size(100, 100);
            this.Button_Staff.TabIndex = 16;
            this.Button_Staff.UseVisualStyleBackColor = false;
            this.Button_Staff.Click += new System.EventHandler(this.Button_Staff_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, -8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(778, 2);
            this.label8.TabIndex = 15;
            // 
            // Label_Staff
            // 
            this.Label_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Staff.AutoSize = true;
            this.Label_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Staff.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Staff.Location = new System.Drawing.Point(123, 177);
            this.Label_Staff.MaximumSize = new System.Drawing.Size(100, 0);
            this.Label_Staff.MinimumSize = new System.Drawing.Size(100, 0);
            this.Label_Staff.Name = "Label_Staff";
            this.Label_Staff.Size = new System.Drawing.Size(100, 34);
            this.Label_Staff.TabIndex = 15;
            this.Label_Staff.Text = "Staff Management";
            this.Label_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Staff.Click += new System.EventHandler(this.Button_Staff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "Admin Module";
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Login.ForeColor = System.Drawing.Color.Black;
            this.Label_Login.Location = new System.Drawing.Point(13, 28);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(209, 41);
            this.Label_Login.TabIndex = 6;
            this.Label_Login.Text = "User Module";
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Search.Location = new System.Drawing.Point(123, 127);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(280, 24);
            this.Textbox_Search.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter PNR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Retrieve
            // 
            this.Button_Retrieve.BackColor = System.Drawing.Color.Transparent;
            this.Button_Retrieve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Retrieve.BackgroundImage")));
            this.Button_Retrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Retrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Retrieve.FlatAppearance.BorderSize = 0;
            this.Button_Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Retrieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Retrieve.Location = new System.Drawing.Point(418, 125);
            this.Button_Retrieve.Name = "Button_Retrieve";
            this.Button_Retrieve.Size = new System.Drawing.Size(25, 25);
            this.Button_Retrieve.TabIndex = 10;
            this.Button_Retrieve.UseVisualStyleBackColor = false;
            this.Button_Retrieve.Click += new System.EventHandler(this.Button_Retrieve_Click);
            // 
            // Label_Retrieve
            // 
            this.Label_Retrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Retrieve.AutoSize = true;
            this.Label_Retrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Retrieve.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Retrieve.Location = new System.Drawing.Point(449, 129);
            this.Label_Retrieve.Name = "Label_Retrieve";
            this.Label_Retrieve.Size = new System.Drawing.Size(87, 17);
            this.Label_Retrieve.TabIndex = 9;
            this.Label_Retrieve.Text = "Retrieve Data";
            this.Label_Retrieve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Retrieve.Click += new System.EventHandler(this.Button_Retrieve_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(542, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 25);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(689, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 25);
            this.label5.TabIndex = 12;
            // 
            // Button_Insert
            // 
            this.Button_Insert.BackColor = System.Drawing.Color.Transparent;
            this.Button_Insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Insert.BackgroundImage")));
            this.Button_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Insert.FlatAppearance.BorderSize = 0;
            this.Button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Insert.Location = new System.Drawing.Point(550, 125);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(25, 25);
            this.Button_Insert.TabIndex = 14;
            this.Button_Insert.UseVisualStyleBackColor = false;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // Label_Insert
            // 
            this.Label_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Insert.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Insert.Location = new System.Drawing.Point(581, 129);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Size = new System.Drawing.Size(72, 17);
            this.Label_Insert.TabIndex = 13;
            this.Label_Insert.Text = "Insert Data";
            this.Label_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.Label_Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Retrieve);
            this.Controls.Add(this.Label_Retrieve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.Panel_Admin);
            this.Controls.Add(this.Button_Profile);
            this.Controls.Add(this.Label_Profile);
            this.Controls.Add(this.Button_Logout);
            this.Controls.Add(this.Label_Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synth - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Panel_Admin.ResumeLayout(false);
            this.Panel_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Logout;
        private System.Windows.Forms.Button Button_Logout;
        private System.Windows.Forms.Button Button_Profile;
        private System.Windows.Forms.Label Label_Profile;
        private System.Windows.Forms.Panel Panel_Admin;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Retrieve;
        private System.Windows.Forms.Label Label_Retrieve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Label Label_Insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_Customer;
        private System.Windows.Forms.Label Label_Customer;
        private System.Windows.Forms.Button Button_Staff;
        private System.Windows.Forms.Label Label_Staff;
    }
}