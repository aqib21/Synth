﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    public partial class Form_AgentManagement : Form
    {
        public Form_AgentManagement()
        {
            InitializeComponent();
        }

        private void Form_AgentManagement_Load(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }

        public void RefreshDataGridView(string search)
        {
            try
            {
                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetAgents('{search}')", conn);
                using NpgsqlDataAdapter sda = new(cmd);
                DataTable dt = new();
                sda.Fill(dt);

                DataGridView_Agent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.Dispose();
                DataGridView_Agent.Columns[0].HeaderText = "Agent ID";
                DataGridView_Agent.Columns[1].HeaderText = "Agent Name";
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (!Application.OpenForms.OfType<Form_AgentAddEdit>().Any())
            {
                Form_AgentAddEdit form_AgentAddEdit = new(0, this);
                form_AgentAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_AgentAddEdit"].BringToFront();
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Agent.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to edit.";
                return;
            }

            int Agent_ID = int.Parse(DataGridView_Agent.Rows[DataGridView_Agent.CurrentRow.Index].Cells[0].Value.ToString());

            if (!Application.OpenForms.OfType<Form_AgentAddEdit>().Any())
            {
                Form_AgentAddEdit form_AgentAddEdit = new(Agent_ID, this);
                form_AgentAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_AgentAddEdit"].BringToFront();
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Agent.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to delete.";
                return;
            }

            int Agent_ID = int.Parse(DataGridView_Agent.Rows[DataGridView_Agent.CurrentRow.Index].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure to delete this agent?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_DeleteAgent({Agent_ID})", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.Dispose();
                    RefreshDataGridView("");
                }
            }
        }

        private void Textbox_Search_TextChanged(object sender, EventArgs e)
        {
            string search = Textbox_Search.Text;
            RefreshDataGridView(search);
        }

        private void Form_AgentManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<Form_AgentAddEdit>().Any())
                Application.OpenForms["Form_AgentAddEdit"].Close();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }
    }
}
