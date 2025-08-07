using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace VegetableBox
{
    internal class ClsFrmDailyAccountClosing
    {
        #region "Save, View & Update"

        #region "Properties"

        private decimal _OpeningBalance = 0;
        private decimal _CashSales = 0;
        private decimal _CustomerDueReceivedCash = 0;
        private decimal _UndiyalCashWithdraw = 0;
        private decimal _VendorPaymentCash = 0;
        private decimal _ExpenseCash = 0;
        private decimal _UndiyalCashDeposit = 0;
        private decimal _CashOnHand = 0;
        private decimal _CoinOnHand = 0;
        private decimal _TallyAmount = 0;
        private decimal _ClosingBalance = 0;
        private string _Remarks = string.Empty;
        private int _UpdatedBy = 0;

        internal decimal OpeningBalance
        {
            get { return _OpeningBalance; }
            set { _OpeningBalance = value; }
        }

        internal decimal CashSales
        {
            get { return _CashSales; }
            set { _CashSales = value; }
        }

        internal decimal CustomerDueReceivedCash
        {
            get { return _CustomerDueReceivedCash; }
            set { _CustomerDueReceivedCash = value; }
        }

        internal decimal UndiyalCashWithdraw
        {
            get { return _UndiyalCashWithdraw; }
            set { _UndiyalCashWithdraw = value; }
        }

        internal decimal VendorPaymentCash
        {
            get { return _VendorPaymentCash; }
            set { _VendorPaymentCash = value; }
        }

        internal decimal ExpenseCash
        {
            get { return _ExpenseCash; }
            set { _ExpenseCash = value; }
        }

        internal decimal UndiyalCashDeposit
        {
            get { return _UndiyalCashDeposit; }
            set { _UndiyalCashDeposit = value; }
        }

        internal decimal CashOnHand
        {
            get { return _CashOnHand; }
            set { _CashOnHand = value; }
        }

        internal decimal CoinOnHand
        {
            get { return _CoinOnHand; }
            set { _CoinOnHand = value; }
        }

        internal decimal TallyAmount
        {
            get { return _TallyAmount; }
            set { _TallyAmount = value; }
        }

        internal decimal ClosingBalance
        {
            get { return _ClosingBalance; }
            set { _ClosingBalance = value; }
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

        #endregion

        internal void Save()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpSaveCashDailySummary";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
            {
                new SqlParameter("@OpeningBalance", this.OpeningBalance),
                new SqlParameter("@CashSales", this.CashSales),
                new SqlParameter("@CustomerDueReceivedCash", this.CustomerDueReceivedCash),
                new SqlParameter("@UndiyalCashWithdraw", this.UndiyalCashWithdraw),
                new SqlParameter("@VendorPaymentCash", this.VendorPaymentCash),
                new SqlParameter("@ExpenseCash", this.ExpenseCash),
                new SqlParameter("@UndiyalCashDeposit", this.UndiyalCashDeposit),
                new SqlParameter("@CashOnHand", this.CashOnHand),
                new SqlParameter("@CoinOnHand", this.CoinOnHand),
                new SqlParameter("@TallyAmount", this.TallyAmount),
                new SqlParameter("@ClosingBalance", this.ClosingBalance),
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

        internal void InsertZeroCashDailySummary()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpInsertZeroCashDailySummary";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@UpdatedBy", Global.currentUserId)
                };

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _CashDailySummaryByTodayData = new DataTable();
        internal DataTable CashDailySummaryByTodayData
        {
            get { return _CashDailySummaryByTodayData; }
            set { _CashDailySummaryByTodayData = value; }
        }

        internal void GetCashDailySummaryByToday()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpGetCashDailySummaryByToday";

                this._CashDailySummaryByTodayData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.StoredProcedure, null);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _CashDailyAllClosingDetailsByTodayData = new DataTable();
        internal DataTable CashDailyAllClosingDetailsByTodayData
        {
            get { return _CashDailyAllClosingDetailsByTodayData; }
            set { _CashDailyAllClosingDetailsByTodayData = value; }
        }

        internal void GetCashDailyAllClosingDetailsByToday()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpGetCashDailyAllClosingDetailsByToday";

                this._CashDailyAllClosingDetailsByTodayData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.StoredProcedure, null);
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

