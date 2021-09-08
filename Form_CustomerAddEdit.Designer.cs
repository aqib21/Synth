
namespace Synth
{
    partial class Form_CustomerAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CustomerAddEdit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Insert = new System.Windows.Forms.Label();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Insert
            // 
            this.Label_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Insert.AutoSize = true;
            this.Label_Insert.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Insert.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Insert.Location = new System.Drawing.Point(154, 25);
            this.Label_Insert.Name = "Label_Insert";
            this.Label_Insert.Size = new System.Drawing.Size(42, 17);
            this.Label_Insert.TabIndex = 20;
            this.Label_Insert.Text = "Name";
            this.Label_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Name.Location = new System.Drawing.Point(253, 23);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(322, 24);
            this.Textbox_Name.TabIndex = 19;
            // 
            // Form_CustomerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Insert);
            this.Controls.Add(this.Textbox_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_CustomerAddEdit";
            this.Text = "Add Customers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Insert;
        private System.Windows.Forms.TextBox Textbox_Name;
    }
}