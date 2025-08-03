using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmVendorPayment
    {
        #region "Master Data"

        private DataTable _VendorMaster = new DataTable();
        private DataTable _PaymentTypeMaster = new DataTable();
        private DataTable _TransTypeMaster = new DataTable();

        internal DataTable VendorMaster
        {
            get { return _VendorMaster; }
            set { _VendorMaster = value; }
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
                this._VendorMaster = _Master.GetVendorMaster();
                this._PaymentTypeMaster = _Master.GetPaymentTypeMaster();

                DataTable _DataTable = new DataTable();
                _DataTable.Columns.Add(new DataColumn("Code", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "D"; _DataRow["Name"] = "Payment Out(Debit)";
                _DataTable.Rows.Add(_DataRow);

                _DataRow = _DataTable.NewRow();
                _DataRow["Code"] = "C"; _DataRow["Name"] = "Credit";
                _DataTable.Rows.Add(_DataRow);

                this._TransTypeMaster = _DataTable;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "Private Fields and Properties"

        private int _TranNo = 0;
        private int _VendorCode = 0;
        private string _BillNo = string.Empty;
        private DateTime _BillDate;
        private decimal? _Amount;
        private string _PaymentType = string.Empty;
        private string _TransType = string.Empty;
        private string _Remarks = string.Empty;
        private int _RefTranNo = 0;
        private int _UpdatedBy = 0;

        internal int TranNo
        {
            get { return _TranNo; }
            set { _TranNo = value; }
        }

        internal int VendorCode
        {
            get { return _VendorCode; }
            set { _VendorCode = value; }
        }

        internal string BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        internal DateTime BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        internal Nullable<decimal> Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        internal string PaymentType
        {
            get { return _PaymentType; }
            set { _PaymentType = value; }
        }

        internal string TransType
        {
            get { return _TransType; }
            set { _TransType = value; }
        }

        internal string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        internal int RefTranNo
        {
            get { return _RefTranNo; }
            set { _RefTranNo = value; }
        }

        internal int UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }

        #endregion

        #region "Save, Update & View"

        internal void Save()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpSaveVendorPaymentDetails";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
            {
                new SqlParameter("@VendorCode", this.VendorCode),
                new SqlParameter("@TransType", this.TransType),
                new SqlParameter("@BillNo", this.BillNo),
                new SqlParameter("@BillDate", this.BillDate),
                new SqlParameter("@Amount", this.Amount),
                new SqlParameter("@PaymentType", this.PaymentType),
                new SqlParameter("@Remarks", this.Remarks),
                new SqlParameter("@RefTranNo", this.RefTranNo),
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
                string SqlQuery = "SpUpdateVendorPaymentDetails";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
            {
                new SqlParameter("@TranNo", this.TranNo),
                new SqlParameter("@VendorCode", this.VendorCode),
                new SqlParameter("@BillNo", this.BillNo),
                new SqlParameter("@BillDate", this.BillDate),
                new SqlParameter("@Amount", this.Amount),
                new SqlParameter("@PaymentType", this.PaymentType),
                new SqlParameter("@Remarks", this.Remarks),
                new SqlParameter("@RefTranNo", this.RefTranNo),
                new SqlParameter("@UpdatedBy", Global.currentUserId)
            };

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _VendorPaymentData = new DataTable();

        internal DataTable VendorPaymentData
        {
            get { return _VendorPaymentData; }
            set { _VendorPaymentData = value; }
        }

        internal void View()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpGetVendorPaymentDetails";

                _VendorPaymentData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _VendorBillDetailsData = new DataTable();

        internal DataTable VendorBillDetailsData
        {
            get { return _VendorBillDetailsData; }
            set { _VendorBillDetailsData = value; }
        }

        internal void GetVendorBillDetails()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SELECT TranNo, VendorCode, BillNo, BillDate, BillAmount, AmountPaid AS PaidTillNow, (BillAmount - AmountPaid) AS PendingAmount FROM [dbo].[VendorBillDetails]";
                SqlQuery += Environment.NewLine + "WHERE (BillAmount - AmountPaid) > 0.00";

                _VendorBillDetailsData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }


        #endregion
    }

}

