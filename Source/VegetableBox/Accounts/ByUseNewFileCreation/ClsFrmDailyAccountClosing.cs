using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmDailyAccountClosing
    {
        #region "Save, View & Update"

        private int _TranNo = 0;
        private string _TransType = string.Empty; // 'C' or 'D'
        private decimal _Amount = 0;
        private string _PaymentType = string.Empty;
        private string _Remarks = string.Empty;
        private int _UpdatedBy = 0;

        internal int TranNo
        {
            get { return _TranNo; }
            set { _TranNo = value; }
        }

        internal string TransType
        {
            get { return _TransType; }
            set { _TransType = value; }
        }

        internal decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        internal string PaymentType
        {
            get { return _PaymentType; }
            set { _PaymentType = value; }
        }

        internal string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        internal int UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }

        internal void Save()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpSaveUndiyalCreditDebitNote";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@TransType", this.TransType),
                    new SqlParameter("@TranDate", DateTime.Now.Date),
                    new SqlParameter("@Amount", this.Amount),
                    new SqlParameter("@PaymentType", this.PaymentType),
                    new SqlParameter("@Remarks", this.Remarks),
                    new SqlParameter("@UpdatedBy", Global.currentUserId)
                };

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        internal void Update()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpUpdateUndiyalCreditDebitNote";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@TranNo", this.TranNo),
                    new SqlParameter("@TransType", this.TransType),
                    new SqlParameter("@Amount", this.Amount),
                    new SqlParameter("@PaymentType", this.PaymentType),
                    new SqlParameter("@Remarks", this.Remarks),
                    new SqlParameter("@UpdatedBy", Global.currentUserId)
                };

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "Get UI Data"

        private DataTable _SalesPaymentData = new DataTable();
        internal DataTable SalesPaymentData
        {
            get { return _SalesPaymentData; }
            set { _SalesPaymentData = value; }
        }

        private DataTable _VendorPaymentData = new DataTable();
        internal DataTable VendorPaymentData
        {
            get { return _VendorPaymentData; }
            set { _VendorPaymentData = value; }
        }

        private DataTable _ExpensesData = new DataTable();
        internal DataTable ExpensesData
        {
            get { return _ExpensesData; }
            set { _ExpensesData = value; }
        }

        private DataTable _CustomerDebitsData = new DataTable();
        internal DataTable CustomerDebitsData
        {
            get { return _CustomerDebitsData; }
            set { _CustomerDebitsData = value; }
        }

        private DataTable _CustomerCreditData = new DataTable();
        internal DataTable CustomerCreditData
        {
            get { return _CustomerCreditData; }
            set { _CustomerCreditData = value; }
        }

        private DataTable _UndiyalData = new DataTable();
        internal DataTable UndiyalData
        {
            get { return _UndiyalData; }
            set { _UndiyalData = value; }
        }

        internal void GetUIData()
        {
            try
            {
                //Sales
                SqlIntract _SqlIntract = new SqlIntract();

                string SqlQuery = "SELECT [PaymentType], SUM([Amount]) AS Amount";
                SqlQuery += Environment.NewLine + "FROM [PaymentDetails]";
                SqlQuery += Environment.NewLine + "WHERE [BilledDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "GROUP BY [PaymentType]";

                this._SalesPaymentData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);


                //Vendor Payments
                _SqlIntract = new SqlIntract();

                SqlQuery = "SELECT [PaymentType], SUM([Amount]) AS Amount";
                SqlQuery += Environment.NewLine + "FROM [VendorPaymentDetails]";
                SqlQuery += Environment.NewLine + "WHERE [TranDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "GROUP BY [PaymentType]";

                this._VendorPaymentData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);


                //Expenses 
                _SqlIntract = new SqlIntract();

                SqlQuery = "SELECT [PaymentType], SUM([Amount]) AS Amount";
                SqlQuery += Environment.NewLine + "FROM [Expenses]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";
                SqlQuery += Environment.NewLine + "AND [TranDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "GROUP BY [PaymentType]";

                this._ExpensesData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);


                //Customer Debits
                _SqlIntract = new SqlIntract();

                SqlQuery = "SELECT [PaymentType], SUM([Amount]) AS Amount";
                SqlQuery += Environment.NewLine + "FROM [CustomerCreditDebitNote]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";
                SqlQuery += Environment.NewLine + "AND [TranDate] = CAST(GETDATE() AS DATE) ";
                SqlQuery += Environment.NewLine + "AND [TransType] = 'C'";
                SqlQuery += Environment.NewLine + "GROUP BY [PaymentType]";

                this._CustomerDebitsData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);


                //Customer Credit
                _SqlIntract = new SqlIntract();

                SqlQuery = "SELECT [PaymentType], ISNULL(SUM([Amount]), 0.00) AS Amount";
                SqlQuery += Environment.NewLine + "FROM [CustomerCreditDebitNote]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";
                SqlQuery += Environment.NewLine + "AND [TranDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "AND [TransType] = 'D'";
                SqlQuery += Environment.NewLine + "GROUP BY [PaymentType]";

                this._CustomerCreditData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);


                //Undiyal
                _SqlIntract = new SqlIntract();

                SqlQuery = "SELECT [OpeningBalance], [Deposit], [Withdraw], [ClosingBalance]";
                SqlQuery += Environment.NewLine + "FROM [UndiyalDailyTransaction]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";
                SqlQuery += Environment.NewLine + "AND [TranDate] = CAST(GETDATE() AS DATE)";

                this._UndiyalData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);

            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}

