
namespace Synth
{
    partial class Form_AgentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgentManagement));
            this.Label_Incorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Textbox_Search = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.DataGridView_Agent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Agent)).BeginInit();
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
            this.Label_Incorrect.TabIndex = 27;
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
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter Name or Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Textbox_Search
            // 
            this.Textbox_Search.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Textbox_Search.Location = new System.Drawing.Point(153, 38);
            this.Textbox_Search.Name = "Textbox_Search";
            this.Textbox_Search.Size = new System.Drawing.Size(340, 24);
            this.Textbox_Search.TabIndex = 24;
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
            this.Button_Add.TabIndex = 23;
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
            this.Button_Edit.TabIndex = 22;
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
            this.Button_Delete.TabIndex = 21;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // DataGridView_Agent
            // 
            this.DataGridView_Agent.AllowUserToAddRows = false;
            this.DataGridView_Agent.AllowUserToDeleteRows = false;
            this.DataGridView_Agent.AllowUserToOrderColumns = true;
            this.DataGridView_Agent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Agent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Agent.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView_Agent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_Agent.Location = new System.Drawing.Point(12, 124);
            this.DataGridView_Agent.Name = "DataGridView_Agent";
            this.DataGridView_Agent.RowHeadersVisible = false;
            this.DataGridView_Agent.RowTemplate.Height = 25;
            this.DataGridView_Agent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Agent.Size = new System.Drawing.Size(481, 319);
            this.DataGridView_Agent.TabIndex = 20;
            // 
            // Form_AgentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.Label_Incorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Textbox_Search);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.DataGridView_Agent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AgentManagement";
            this.Text = "Agent Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AgentManagement_FormClosing);
            this.Load += new System.EventHandler(this.Form_AgentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Agent)).EndInit();
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
        private System.Windows.Forms.DataGridView DataGridView_Agent;
    }
}