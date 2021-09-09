using System;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    public partial class Form_AgentAddEdit : Form
    {
        readonly int agent_id_edit = 0;
        private readonly Form_AgentManagement form_AgentManagement;

        public Form_AgentAddEdit(int agent_id, Form_AgentManagement form_AgentManagement)
        {
            InitializeComponent();
            this.agent_id_edit = agent_id;
            this.form_AgentManagement = form_AgentManagement;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Textbox_Name.Text.Trim() == "")
            {
                Label_Incorrect.Text = "Name cannot be empty";
                return;
            }

            string name = Textbox_Name.Text;
            try
            {
                using var conn = DB.GetConnection();
                if (agent_id_edit == 0)
                {
                    using var cmd = new NpgsqlCommand($"INSERT INTO Agents (name) Values ('{name}')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    using var cmd = new NpgsqlCommand($"UPDATE Agents SET name = '{name}' WHERE Agent_ID = {agent_id_edit}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Label_Incorrect.Text = ex.Message;
            }
            finally
            {
                DB.Dispose();
                form_AgentManagement.RefreshDataGridView("");
                ClearTextBoxes();

                if (agent_id_edit != 0) this.Close();
            }

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AgentAddEdit_Load(object sender, EventArgs e)
        {
            if (agent_id_edit != 0)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT Name FROM Agents WHERE Agent_Id = {agent_id_edit}", conn);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Textbox_Name.Text = reader[0].ToString();
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
        }
        private void ClearTextBoxes()
        {
            static void func(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            }
            func(Controls);
        }

    }
}
