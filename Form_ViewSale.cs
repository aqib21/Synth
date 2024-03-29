﻿using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Synth
{
    public partial class Form_ViewSale : Form
    {
        readonly int sale_id = 0;
        Bitmap memoryImage;
        public Form_ViewSale(int sale_id)
        {
            InitializeComponent();
            this.sale_id = sale_id;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ViewSale_Load(object sender, EventArgs e)
        {
            try
            {
                PictureBox_Logo.Image = Properties.Resources.Logo;
                PictureBox_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
                Label_CompanyName.Text = ConfigurationManager.AppSettings["CompanyName"];
                Label_CompanyPhone.Text = ConfigurationManager.AppSettings["CompanyPhone"];
                Label_CompanyAddress.Text = ConfigurationManager.AppSettings["CompanyAddress"];
                Label_CompanyEmail.Text = ConfigurationManager.AppSettings["CompanyEmail"];

                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetSale({sale_id})", conn);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Label_Date.Text = DateTime.Now.ToShortDateString();
                    Label_Time.Text = DateTime.Now.ToShortTimeString();
                    Label_PNR.Text = reader[3].ToString();
                    Label_FullName.Text = $"{reader[1]} {reader[0]}";
                    Label_Phone.Text = reader[2].ToString();
                    Label_IssueDate.Text = DateTime.Parse(reader[4].ToString()).ToShortDateString();
                    Label_Agent.Text = reader[5].ToString();
                    Label_Price.Text = $"SAR {reader[6]}";
                    Label_Installment1.Text = reader[10].ToString() == "0" ? "N/A" : $"SAR {reader[10]} on {DateTime.Parse(reader[11].ToString()).ToShortDateString()}";
                    Label_Installment2.Text = reader[12].ToString() == "0" ? "N/A" : $"SAR {reader[12]} on {DateTime.Parse(reader[13].ToString()).ToShortDateString()}";
                    Label_AmountPaid.Text = reader[9].ToString() == "0" ? "N/A" : $"SAR {reader[9]}";
                    Label_DueAmount.Text = reader[14].ToString() == "0" ? "Fully Paid" : $"SAR {reader[14]}";
                    Label_PCRPrice.Text = reader[15].ToString() == "0" ? "N/A" : $"SAR {reader[15]}";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.Dispose();
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            Button_Close.Visible = false;
            Button_Print.Visible = false;

            CaptureScreen();
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.PrintPreviewControl.Zoom = 1;
            PrintPreviewDialog.ShowDialog();

            Button_Close.Visible = true;
            Button_Print.Visible = true;
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}
