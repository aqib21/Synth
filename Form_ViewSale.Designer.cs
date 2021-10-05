
namespace Synth
{
    partial class Form_ViewSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewSale));
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label_FullName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label_Agent = new System.Windows.Forms.Label();
            this.Label_IssueDate = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_AmountPaid = new System.Windows.Forms.Label();
            this.Label_DueAmount = new System.Windows.Forms.Label();
            this.Label_Installment1 = new System.Windows.Forms.Label();
            this.Label_Installment2 = new System.Windows.Forms.Label();
            this.Label_PCRPrice = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Button_Print = new System.Windows.Forms.Button();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_PNR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.Button_Close.Location = new System.Drawing.Point(803, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 11;
            this.Button_Close.TabStop = false;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Full Name:";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Title.ForeColor = System.Drawing.Color.Black;
            this.Label_Title.Location = new System.Drawing.Point(101, 333);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(49, 23);
            this.Label_Title.TabIndex = 12;
            this.Label_Title.Text = "PNR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(101, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Agent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(101, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Issue Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(100, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Due Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Amount Paid:";
            // 
            // Label_FullName
            // 
            this.Label_FullName.AutoSize = true;
            this.Label_FullName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_FullName.ForeColor = System.Drawing.Color.Black;
            this.Label_FullName.Location = new System.Drawing.Point(325, 365);
            this.Label_FullName.Name = "Label_FullName";
            this.Label_FullName.Size = new System.Drawing.Size(40, 23);
            this.Label_FullName.TabIndex = 19;
            this.Label_FullName.Text = "Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(101, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Installment #1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(101, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Installment #2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(100, 728);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "PCR Price:";
            // 
            // Label_Agent
            // 
            this.Label_Agent.AutoSize = true;
            this.Label_Agent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Agent.ForeColor = System.Drawing.Color.Black;
            this.Label_Agent.Location = new System.Drawing.Point(326, 432);
            this.Label_Agent.Name = "Label_Agent";
            this.Label_Agent.Size = new System.Drawing.Size(40, 23);
            this.Label_Agent.TabIndex = 28;
            this.Label_Agent.Text = "Text";
            // 
            // Label_IssueDate
            // 
            this.Label_IssueDate.AutoSize = true;
            this.Label_IssueDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_IssueDate.ForeColor = System.Drawing.Color.Black;
            this.Label_IssueDate.Location = new System.Drawing.Point(326, 465);
            this.Label_IssueDate.Name = "Label_IssueDate";
            this.Label_IssueDate.Size = new System.Drawing.Size(40, 23);
            this.Label_IssueDate.TabIndex = 27;
            this.Label_IssueDate.Text = "Text";
            // 
            // Label_Phone
            // 
            this.Label_Phone.AutoSize = true;
            this.Label_Phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Phone.ForeColor = System.Drawing.Color.Black;
            this.Label_Phone.Location = new System.Drawing.Point(326, 399);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(40, 23);
            this.Label_Phone.TabIndex = 26;
            this.Label_Phone.Text = "Text";
            // 
            // Label_AmountPaid
            // 
            this.Label_AmountPaid.AutoSize = true;
            this.Label_AmountPaid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_AmountPaid.ForeColor = System.Drawing.Color.Black;
            this.Label_AmountPaid.Location = new System.Drawing.Point(325, 627);
            this.Label_AmountPaid.Name = "Label_AmountPaid";
            this.Label_AmountPaid.Size = new System.Drawing.Size(40, 23);
            this.Label_AmountPaid.TabIndex = 17;
            this.Label_AmountPaid.Text = "Text";
            // 
            // Label_DueAmount
            // 
            this.Label_DueAmount.AutoSize = true;
            this.Label_DueAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_DueAmount.ForeColor = System.Drawing.Color.Black;
            this.Label_DueAmount.Location = new System.Drawing.Point(324, 662);
            this.Label_DueAmount.Name = "Label_DueAmount";
            this.Label_DueAmount.Size = new System.Drawing.Size(40, 23);
            this.Label_DueAmount.TabIndex = 18;
            this.Label_DueAmount.Text = "Text";
            // 
            // Label_Installment1
            // 
            this.Label_Installment1.AutoSize = true;
            this.Label_Installment1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Installment1.ForeColor = System.Drawing.Color.Black;
            this.Label_Installment1.Location = new System.Drawing.Point(325, 563);
            this.Label_Installment1.Name = "Label_Installment1";
            this.Label_Installment1.Size = new System.Drawing.Size(40, 23);
            this.Label_Installment1.TabIndex = 21;
            this.Label_Installment1.Text = "Text";
            // 
            // Label_Installment2
            // 
            this.Label_Installment2.AutoSize = true;
            this.Label_Installment2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Installment2.ForeColor = System.Drawing.Color.Black;
            this.Label_Installment2.Location = new System.Drawing.Point(325, 595);
            this.Label_Installment2.Name = "Label_Installment2";
            this.Label_Installment2.Size = new System.Drawing.Size(40, 23);
            this.Label_Installment2.TabIndex = 22;
            this.Label_Installment2.Text = "Text";
            // 
            // Label_PCRPrice
            // 
            this.Label_PCRPrice.AutoSize = true;
            this.Label_PCRPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_PCRPrice.ForeColor = System.Drawing.Color.Black;
            this.Label_PCRPrice.Location = new System.Drawing.Point(325, 728);
            this.Label_PCRPrice.Name = "Label_PCRPrice";
            this.Label_PCRPrice.Size = new System.Drawing.Size(40, 23);
            this.Label_PCRPrice.TabIndex = 25;
            this.Label_PCRPrice.Text = "Text";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Price.ForeColor = System.Drawing.Color.Black;
            this.Label_Price.Location = new System.Drawing.Point(326, 497);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(40, 23);
            this.Label_Price.TabIndex = 30;
            this.Label_Price.Text = "Text";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(101, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Price:";
            // 
            // Button_Print
            // 
            this.Button_Print.BackColor = System.Drawing.Color.Transparent;
            this.Button_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Print.BackgroundImage")));
            this.Button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Print.FlatAppearance.BorderSize = 0;
            this.Button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Print.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Print.ForeColor = System.Drawing.Color.White;
            this.Button_Print.Location = new System.Drawing.Point(772, 12);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(25, 25);
            this.Button_Print.TabIndex = 31;
            this.Button_Print.TabStop = false;
            this.Button_Print.UseVisualStyleBackColor = false;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(270, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 49);
            this.label12.TabIndex = 33;
            this.label12.Text = "Synth Solution";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(326, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "123, Example Street, City, 11552";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(326, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "+966 123 456 7890";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(326, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "example@test.com";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(84, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(650, 2);
            this.label17.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(101, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(101, 267);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 23);
            this.label19.TabIndex = 39;
            this.label19.Text = "Time:";
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Date.ForeColor = System.Drawing.Color.Black;
            this.Label_Date.Location = new System.Drawing.Point(326, 235);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(40, 23);
            this.Label_Date.TabIndex = 40;
            this.Label_Date.Text = "Text";
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Time.ForeColor = System.Drawing.Color.Black;
            this.Label_Time.Location = new System.Drawing.Point(326, 267);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(40, 23);
            this.Label_Time.TabIndex = 41;
            this.Label_Time.Text = "Text";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(85, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(650, 2);
            this.label8.TabIndex = 42;
            // 
            // Label_PNR
            // 
            this.Label_PNR.AutoSize = true;
            this.Label_PNR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_PNR.ForeColor = System.Drawing.Color.Black;
            this.Label_PNR.Location = new System.Drawing.Point(326, 333);
            this.Label_PNR.Name = "Label_PNR";
            this.Label_PNR.Size = new System.Drawing.Size(40, 23);
            this.Label_PNR.TabIndex = 43;
            this.Label_PNR.Text = "Text";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(85, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(650, 2);
            this.label10.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(85, 704);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(650, 2);
            this.label20.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(85, 775);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(650, 2);
            this.label21.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(102, 862);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(208, 23);
            this.label22.TabIndex = 47;
            this.label22.Text = "______________________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(145, 901);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 23);
            this.label23.TabIndex = 48;
            this.label23.Text = "Prepared By";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(562, 901);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 23);
            this.label24.TabIndex = 50;
            this.label24.Text = "Received By";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(508, 862);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 23);
            this.label25.TabIndex = 49;
            this.label25.Text = "______________________";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(281, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(281, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(281, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // Form_ViewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 1000);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Label_PNR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_Date);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Label_Agent);
            this.Controls.Add(this.Label_IssueDate);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.Label_PCRPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label_Installment2);
            this.Controls.Add(this.Label_Installment1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label_DueAmount);
            this.Controls.Add(this.Label_FullName);
            this.Controls.Add(this.Label_AmountPaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ViewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text";
            this.Load += new System.EventHandler(this.Form_ViewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_FullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Label_Agent;
        private System.Windows.Forms.Label Label_IssueDate;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_AmountPaid;
        private System.Windows.Forms.Label Label_DueAmount;
        private System.Windows.Forms.Label Label_Installment1;
        private System.Windows.Forms.Label Label_Installment2;
        private System.Windows.Forms.Label Label_PCRPrice;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Button_Print;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_PNR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}