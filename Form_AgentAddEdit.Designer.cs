
namespace Synth
{
    partial class Form_AgentAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgentAddEdit));
            this.Label_Insert = new System.Windows.Forms.Label();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Incorrect = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Insert
            // 
            this.Label_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Insert.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Insert.Location = new System.Drawing.Point(128, 43);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Size = new System.Drawing.Size(79, 17);
            this.Label_Insert.TabIndex = 41;
            this.Label_Insert.Text = "Agent Name";
            this.Label_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Name.Location = new System.Drawing.Point(244, 41);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Name.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Incorrect
            // 
            this.Label_Incorrect.AutoSize = true;
            this.Label_Incorrect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Incorrect.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Incorrect.Location = new System.Drawing.Point(128, 92);
            this.Label_Incorrect.Name = "Label_Incorrect";
            this.Label_Incorrect.Size = new System.Drawing.Size(0, 17);
            this.Label_Incorrect.TabIndex = 46;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.FlatAppearance.BorderSize = 0;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Cancel.ForeColor = System.Drawing.Color.White;
            this.Button_Cancel.Location = new System.Drawing.Point(491, 87);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 25);
            this.Button_Cancel.TabIndex = 45;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.FlatAppearance.BorderSize = 0;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Save.Location = new System.Drawing.Point(410, 87);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 25);
            this.Button_Save.TabIndex = 44;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Form_AgentAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 126);
            this.Controls.Add(this.Label_Incorrect);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Label_Insert);
            this.Controls.Add(this.Textbox_Name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AgentAddEdit";
            this.Text = "Add or Edit Agent";
            this.Load += new System.EventHandler(this.Form_AgentAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Insert;
        private System.Windows.Forms.TextBox Textbox_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Incorrect;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Save;
    }
}