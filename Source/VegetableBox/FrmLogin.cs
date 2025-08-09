using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VegetableBox
{
    public partial class FrmLogin : Form
    {
        Master clsMaster = new Master();
        DataTable _UserData = new DataTable();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void RefreshUI()
        {
            try
            {
                _UserData = clsMaster.GetUserMaster();
                this.CmbUserName.DataSource = null;
                FillControls.ComboBoxFill(this.CmbUserName, _UserData, "Code", "Name", false, "");
                this.CmbUserName.SelectedIndex = -1;
            }
            catch
            {
                throw;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CmbUserName.SelectedIndex < 0)
                {
                    this.CmbUserName.Focus();
                    throw new Exception("Please select a user name.");
                }
                else if (this.TxtPassword.Text.Trim() == string.Empty)
                {
                    this.TxtPassword.Focus();
                    throw new Exception("Please enter the password.");
                }
                else
                {
                    int selectedUserId = Convert.ToInt32(CmbUserName.SelectedValue.ToString());
                    string enteredPassword = TxtPassword.Text;

                    DataRow[] foundRows = _UserData.Select($"Code = '{selectedUserId}'");

                    if (foundRows.Length > 0)
                    {
                        string storedPassword = foundRows[0]["Password"].ToString();

                        if (storedPassword == enteredPassword)
                        {
                            Global.currentUserId = Convert.ToInt32(this.CmbUserName.SelectedValue);
                            Global.currentUserName = foundRows[0]["Name"].ToString();

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Invalid password");
                        }
                    }
                    else
                    {
                        throw new Exception("User ID not found");
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
                if (MessageBox.Show("Are you want to close the application ?", "Vegetable Box", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                    Application.ExitThread();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPosCreditCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                this.KeyPreview = true;
                this.RefreshUI();
                this.CmbUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void FrmPosCreditCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.CmbUserName.Focused)
                    {
                        this.TxtPassword.Focus();
                    }
                    else if (this.TxtPassword.Focused)
                    {
                        this.BtnLogin.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.BtnExit.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }
    }
}
