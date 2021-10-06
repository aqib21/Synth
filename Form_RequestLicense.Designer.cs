
namespace Synth
{
    partial class Form_RequestLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RequestLicense));
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Textbox_Company = new System.Windows.Forms.TextBox();
            this.Button_Request = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Username.Location = new System.Drawing.Point(29, 41);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Username.TabIndex = 7;
            // 
            // Textbox_Company
            // 
            this.Textbox_Company.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Company.Location = new System.Drawing.Point(29, 111);
            this.Textbox_Company.Name = "Textbox_Company";
            this.Textbox_Company.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Company.TabIndex = 8;
            // 
            // Button_Request
            // 
            this.Button_Request.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Request.FlatAppearance.BorderSize = 0;
            this.Button_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Request.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Request.ForeColor = System.Drawing.Color.White;
            this.Button_Request.Location = new System.Drawing.Point(251, 157);
            this.Button_Request.Name = "Button_Request";
            this.Button_Request.Size = new System.Drawing.Size(100, 25);
            this.Button_Request.TabIndex = 9;
            this.Button_Request.Text = "Send Request";
            this.Button_Request.UseVisualStyleBackColor = false;
            this.Button_Request.Click += new System.EventHandler(this.Button_Request_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // Label_Incorrect
            // 
            this.Label_Incorrect.AutoSize = true;
            this.Label_Incorrect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Incorrect.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Incorrect.Location = new System.Drawing.Point(29, 162);
            this.Label_Incorrect.Name = "Label_Incorrect";
            this.Label_Incorrect.Size = new System.Drawing.Size(0, 17);
            this.Label_Incorrect.TabIndex = 12;
            // 
            // Form_RequestLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.Label_Incorrect);
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.Textbox_Company);
            this.Controls.Add(this.Button_Request);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RequestLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Activation Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.TextBox Textbox_Company;
        private System.Windows.Forms.Button Button_Request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Incorrect;
    }
}