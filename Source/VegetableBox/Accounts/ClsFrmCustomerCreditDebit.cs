using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmCustomerCreditDebitNote
    {
        #region "Master"

        private DataTable _CustomerMaster = new DataTable();
        private DataTable _PaymentTypeMaster = new DataTable();
        private DataTable _TransTypeMaster = new DataTable();

        internal DataTable CustomerMaster
        {
            get { return _CustomerMaster; }
            set { _CustomerMaster = value; }
        }

        internal DataTable PaymentTypeMaster
        {
            get { return _PaymentTypeMaster; }
            set { _PaymentTypeMaster = value; }
        }

        internal DataTable TransTypeMaster
        {
            get { return _TransTypeMaster; }
            set { _TransTypeMaster = value; }
        }

        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._CustomerMaster = _Master.GetCustomerMaster();
                this._PaymentTypeMaster = _Master.GetPaymentTypeMaster();

                DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add(new DataColumn("Code", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "C"; _DataRow["Name"] = "CREDIT";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "D"; _DataRow["Name"] = "DEBIT";
                _DataTable.Rows.Add(_DataRow);

                this._TransTypeMaster = _DataTable;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "Save, View & Update"

        private int _TranNo = 0;
        private int _CustomerCode = 0;
        private string _TransType = string.Empty; // 'C' or 'D'
        private int _BillNo = 0;
        private DateTime _BillDate;
        private decimal _Amount = 0;
        private string _PaymentType = string.Empty;
        private string _Remarks = string.Empty;
        private int _UpdatedBy = 0;

        internal int TranNo
        {
            get { return _TranNo; }
            set { _TranNo = value; }
        }

        internal int CustomerCode
        {
            get { return _CustomerCode; }
            set { _CustomerCode = value; }
        }

        internal string TransType
        {
            get { return _TransType; }
            set { _TransType = value; }
        }

        internal int BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        internal DateTime BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
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
                string SqlQuery = "SpSaveCustomerCreditDebitNote";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@CustomerCode", this.CustomerCode),
                    new SqlParameter("@TransType", this.TransType),
                    new SqlParameter("@BillNo", this.BillNo),
                    new SqlParameter("@BillDate", this.BillDate),
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
                string SqlQuery = "SpUpdateCustomerCreditDebitNote";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@TranNo", this.TranNo),
                    new SqlParameter("@CustomerCode", this.CustomerCode),
                    new SqlParameter("@TransType", this.TransType),
                    new SqlParameter("@BillNo", this.BillNo),
                    new SqlParameter("@BillDate", this.BillDate),
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

        private DataTable _CreditDebitNoteData = new DataTable();

        internal DataTable CreditDebitNoteData
        {
            get { return _CreditDebitNoteData; }
            set { _CreditDebitNoteData = value; }
        }

        internal void View()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpGetCustomerCreditDebitNote";

                _CreditDebitNoteData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}

