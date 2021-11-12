
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
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Label_Refresh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.Label_Print = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Label_Export = new System.Windows.Forms.Label();
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
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel files|*.xlsx";
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Button_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Refresh.BackgroundImage")));
            this.Button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatAppearance.BorderSize = 0;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Refresh.Location = new System.Drawing.Point(492, 68);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(25, 25);
            this.Button_Refresh.TabIndex = 23;
            this.Button_Refresh.UseVisualStyleBackColor = false;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Label_Refresh
            // 
            this.Label_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Refresh.AutoSize = true;
            this.Label_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Refresh.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Refresh.Location = new System.Drawing.Point(523, 72);
            this.Label_Refresh.Name = "Label_Refresh";
            this.Label_Refresh.Size = new System.Drawing.Size(82, 17);
            this.Label_Refresh.TabIndex = 22;
            this.Label_Refresh.Text = "Refresh Data";
            this.Label_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(611, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 25);
            this.label3.TabIndex = 29;
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
            this.Button_Insert.Location = new System.Drawing.Point(709, 68);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(25, 25);
            this.Button_Insert.TabIndex = 28;
            this.Button_Insert.UseVisualStyleBackColor = false;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // Label_Print
            // 
            this.Label_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Print.AutoSize = true;
            this.Label_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Print.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Print.Location = new System.Drawing.Point(740, 72);
            this.Label_Print.Name = "Label_Print";
            this.Label_Print.Size = new System.Drawing.Size(35, 17);
            this.Label_Print.TabIndex = 27;
            this.Label_Print.Text = "Print";
            this.Label_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(701, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 25);
            this.label4.TabIndex = 26;
            // 
            // Button_Export
            // 
            this.Button_Export.BackColor = System.Drawing.Color.Transparent;
            this.Button_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Export.BackgroundImage")));
            this.Button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Export.FlatAppearance.BorderSize = 0;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Export.Location = new System.Drawing.Point(619, 68);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(25, 25);
            this.Button_Export.TabIndex = 25;
            this.Button_Export.UseVisualStyleBackColor = false;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Label_Export
            // 
            this.Label_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Export.AutoSize = true;
            this.Label_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Export.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Export.Location = new System.Drawing.Point(650, 72);
            this.Label_Export.Name = "Label_Export";
            this.Label_Export.Size = new System.Drawing.Size(45, 17);
            this.Label_Export.TabIndex = 24;
            this.Label_Export.Text = "Export";
            this.Label_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Form_SalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.Label_Print);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Label_Export);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.Label_Refresh);
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
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Label Label_Refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Label Label_Print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Label Label_Export;
    }
}