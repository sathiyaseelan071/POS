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
    public partial class FrmAttendance : Form
    {
        ClsFrmAttendance clsFrmAttendance = new ClsFrmAttendance();

        public FrmAttendance()
        {
            InitializeComponent();
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            try
            {
                this.refresh();
                this.TxtRemarks.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void refresh()
        {
            this.TxtRemarks.Text = string.Empty;
            this.LblCurrentUserName.Text = Global.currentUserName;
            this.BtnLogInOut.Text = this.clsFrmAttendance.GetAction();

            this.getAttendanceData();
        }

        private void getAttendanceData()
        {
            try
            {
                // Today Data
                dgvTodayData.DataSource = clsFrmAttendance.GetTodayData();

                if (dgvTodayData.Columns.Contains("UserId"))
                    dgvTodayData.Columns["UserId"].Visible = false;

                dgvTodayData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                
                dgvTodayData.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTodayData.Columns["LoginTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTodayData.Columns["LogOutTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTodayData.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvTodayData.Columns["LoginTime"].HeaderText = "Login-Time";
                dgvTodayData.Columns["LogOutTime"].HeaderText = "Logout-Time";
                dgvTodayData.Columns["TotalHr"].HeaderText = "Total-Hr";

                // Monthly Data
                dgvMonthlyData.DataSource = clsFrmAttendance.GetMonthlyData();

                if (dgvMonthlyData.Columns.Contains("UserId"))
                    dgvMonthlyData.Columns["UserId"].Visible = false;

                if (dgvMonthlyData.Columns.Contains("TotalWorkedMinutes"))
                    dgvMonthlyData.Columns["TotalWorkedMinutes"].Visible = false;
                
                dgvMonthlyData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

                dgvMonthlyData.Columns["UserId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMonthlyData.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMonthlyData.Columns["AttendanceDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMonthlyData.Columns["TotalWorkingHr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvMonthlyData.Columns["AttendanceDate"].HeaderText = "Date";
                dgvMonthlyData.Columns["TotalWorkingHr"].HeaderText = "Total Working Hr";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vegetable Box");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(string.IsNullOrEmpty(TxtRemarks.Text.Trim()))
                {
                    MessageBox.Show("Please enter remarks.", "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtRemarks.Focus();
                    return;
                }

                this.clsFrmAttendance.Update(Global.currentUserId, this.BtnLogInOut.Text.ToUpper(), this.TxtRemarks.Text.Trim());

                MessageBox.Show($"Updated successfully...",
                                "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.refresh();
                this.TxtRemarks.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attendance failed: {ex.Message}", "Vegetable Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FrmAttendance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                BtnExit.PerformClick();
        }
    }
}
