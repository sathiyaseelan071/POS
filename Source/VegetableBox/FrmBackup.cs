using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegetableBox
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            try
            {
                TxtBackupPath.Text = string.Empty;
                BtnBrowse.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = TxtBackupPath.Text.Trim();
                if (string.IsNullOrEmpty(folderPath))
                {
                    MessageBox.Show("Please select a folder first.", "Vegtable Box");
                    return;
                }

                string databaseName = Global.sqlDatabaseName;

                string datePart = DateTime.Now.ToString("ddMMMyyyy_hhmmtt").ToUpper() + Global.currentUserId;
                string backupFileName = $"{databaseName}_{datePart}.bak";
                string fullBackupPath = System.IO.Path.Combine(folderPath, backupFileName);

                string connectionString = Global.sqlMasterConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = $@"BACKUP DATABASE [{databaseName}] 
                            TO DISK = '{fullBackupPath}' 
                            WITH FORMAT, INIT, 
                            NAME = 'Full Backup of {databaseName}';";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show($"Backup completed successfully!\nSaved to: {fullBackupPath}",
                                "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Backup failed: {ex.Message}", "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select folder to save SQL backup";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        TxtBackupPath.Text = fbd.SelectedPath; // TextBox to show selected folder
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to exit ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Global.mdiVegetableBox != null)
                        Global.mdiVegetableBox.CloseForm(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

    }
}
