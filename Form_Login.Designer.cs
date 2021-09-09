
namespace Synth
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Panel_login = new System.Windows.Forms.Panel();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Label_Incorrect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_login
            // 
            this.Panel_login.BackColor = System.Drawing.Color.Transparent;
            this.Panel_login.Controls.Add(this.Textbox_Username);
            this.Panel_login.Controls.Add(this.Textbox_Password);
            this.Panel_login.Controls.Add(this.Button_Login);
            this.Panel_login.Controls.Add(this.Label_Version);
            this.Panel_login.Controls.Add(this.Label_Incorrect);
            this.Panel_login.Controls.Add(this.pictureBox1);
            this.Panel_login.Controls.Add(this.label2);
            this.Panel_login.Controls.Add(this.label1);
            this.Panel_login.Controls.Add(this.Label_Login);
            this.Panel_login.Controls.Add(this.Button_Close);
            this.Panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_login.Location = new System.Drawing.Point(0, 0);
            this.Panel_login.Name = "Panel_login";
            this.Panel_login.Size = new System.Drawing.Size(800, 500);
            this.Panel_login.TabIndex = 0;
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Username.Location = new System.Drawing.Point(420, 176);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Username.TabIndex = 1;
            this.Textbox_Username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyUp);
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Password.Location = new System.Drawing.Point(420, 246);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '●';
            this.Textbox_Password.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Password.TabIndex = 2;
            this.Textbox_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyUp);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(420, 300);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(75, 25);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Version.ForeColor = System.Drawing.Color.Black;
            this.Label_Version.Location = new System.Drawing.Point(690, 474);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(52, 17);
            this.Label_Version.TabIndex = 9;
            this.Label_Version.Text = "Version ";
            // 
            // Label_Incorrect
            // 
            this.Label_Incorrect.AutoSize = true;
            this.Label_Incorrect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Incorrect.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Incorrect.Location = new System.Drawing.Point(510, 305);
            this.Label_Incorrect.Name = "Label_Incorrect";
            this.Label_Incorrect.Size = new System.Drawing.Size(194, 17);
            this.Label_Incorrect.TabIndex = 8;
            this.Label_Incorrect.Text = "Incorrect username or password.";
            this.Label_Incorrect.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 500);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(420, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(420, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Login.ForeColor = System.Drawing.Color.Black;
            this.Label_Login.Location = new System.Drawing.Point(411, 81);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(347, 41);
            this.Label_Login.TabIndex = 4;
            this.Label_Login.Text = "Log in to your account";
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Close.BackgroundImage")));
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Close.Location = new System.Drawing.Point(772, 3);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 10;
            this.Button_Close.TabStop = false;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synth";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.Panel_login.ResumeLayout(false);
            this.Panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_login;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox Textbox_Password;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_Incorrect;
        private System.Windows.Forms.Button Button_Close;
    }
}

