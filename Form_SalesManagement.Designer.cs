
namespace Synth
{
    partial class Form_SalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SalesManagement));
            this.Label_Incorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.DataGridView_Sales = new System.Windows.Forms.DataGridView();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Button_Print = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Incorrect
            // 
            this.Label_Incorrect.AutoSize = true;
            this.Label_Incorrect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Incorrect.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Incorrect.Location = new System.Drawing.Point(153, 101);
            this.Label_Incorrect.Name = "Label_Incorrect";
            this.Label_Incorrect.Size = new System.Drawing.Size(0, 17);
            this.Label_Incorrect.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter PRN, Name or Phone to search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Search.Location = new System.Drawing.Point(153, 38);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(340, 24);
            this.Textbox_Search.TabIndex = 16;
            this.Textbox_Search.TextChanged += new System.EventHandler(this.Textbox_Search_TextChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Add.ForeColor = System.Drawing.Color.White;
            this.Button_Add.Location = new System.Drawing.Point(153, 68);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 25);
            this.Button_Add.TabIndex = 15;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Edit.FlatAppearance.BorderSize = 0;
            this.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Edit.ForeColor = System.Drawing.Color.White;
            this.Button_Edit.Location = new System.Drawing.Point(234, 68);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(75, 25);
            this.Button_Edit.TabIndex = 14;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = false;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.FlatAppearance.BorderSize = 0;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Delete.ForeColor = System.Drawing.Color.White;
            this.Button_Delete.Location = new System.Drawing.Point(315, 68);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 25);
            this.Button_Delete.TabIndex = 13;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // DataGridView_Sales
            // 
            this.DataGridView_Sales.AllowUserToAddRows = false;
            this.DataGridView_Sales.AllowUserToDeleteRows = false;
            this.DataGridView_Sales.AllowUserToOrderColumns = true;
            this.DataGridView_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Sales.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Sales.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView_Sales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_Sales.Location = new System.Drawing.Point(12, 124);
            this.DataGridView_Sales.Name = "DataGridView_Sales";
            this.DataGridView_Sales.RowHeadersVisible = false;
            this.DataGridView_Sales.RowTemplate.Height = 25;
            this.DataGridView_Sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Sales.Size = new System.Drawing.Size(1210, 319);
            this.DataGridView_Sales.TabIndex = 12;
            // 
            // Button_Export
            // 
            this.Button_Export.BackColor = System.Drawing.Color.Crimson;
            this.Button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Export.FlatAppearance.BorderSize = 0;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.ForeColor = System.Drawing.Color.White;
            this.Button_Export.Location = new System.Drawing.Point(494, 68);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(75, 25);
            this.Button_Export.TabIndex = 20;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = false;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.Color.Crimson;
            this.Button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Print.FlatAppearance.BorderSize = 0;
            this.Button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Print.ForeColor = System.Drawing.Color.White;
            this.Button_Print.Location = new System.Drawing.Point(575, 68);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(75, 25);
            this.Button_Print.TabIndex = 21;
            this.Button_Print.Text = "Print";
            this.Button_Print.UseVisualStyleBackColor = false;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel files|*.xlsx";
            // 
            // Form_SalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 461);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Label_Incorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.DataGridView_Sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form_SalesManagement";
            this.Text = "Sales Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SalesManagement_FormClosing);
            this.Load += new System.EventHandler(this.Form_SalesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Incorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Textbox_Search;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.DataGridView DataGridView_Sales;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Button Button_Print;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}