using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmVendorInvoiceEntry
    {
        #region "Master"

        private DataTable _VendorMaster = new DataTable();
        private DataTable _UserMaster = new DataTable();
        private DataTable _YesNoMaster = new DataTable();
        private DataTable _ProgressStatusMaster = new DataTable();

        internal DataTable VendorMaster
        {
            get { return _VendorMaster; }
            set { _VendorMaster = value; }
        }

        internal DataTable UserMaster
        {
            get { return _UserMaster; }
            set { _UserMaster = value; }
        }

        internal DataTable YesNoMaster
        {
            get { return _YesNoMaster; }
            set { _YesNoMaster = value; }
        }

        internal DataTable ProgressStatusMaster
        {
            get { return _ProgressStatusMaster; }
            set { _ProgressStatusMaster = value; }
        }

        internal void GetMasterData()
        {
            try
            {
                Master _Master = new Master();
                this._VendorMaster = _Master.GetVendorMaster();
                this._UserMaster = _Master.GetUserMaster();
                this._ProgressStatusMaster = _Master.GetProgressStatusMaster();
                this._YesNoMaster = _Master.GetYesNoMaster();
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region "Save, View & Update"

        private int _TranNo = 0;
        private int _VendorCode = 0;
        private string _BillNo = string.Empty;
        private DateTime _BillDate;
        private decimal _BillAmount = 0;
        private string _BillChecked = string.Empty;
        private int? _BillCheckedBy = 0;
        private int? _ItemsCount = 0;
        private string? _IsItemMissing = string.Empty;
        private string? _MissingItemDetails = string.Empty;
        private string? _IsMissingItemReceived = string.Empty;
        private int? _MissingItemReceivedBy = 0;
        private string? _PurchaseEntryStatus = string.Empty;
        private int? _PurchaseEntryBy = 0;
        private string _Remarks = string.Empty;
        private decimal _AmountPaid = 0;
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

        internal decimal BillAmount
        {
            get { return _BillAmount; }
            set { _BillAmount = value; }
        }

        internal string BillChecked
        {
            get { return _BillChecked; }
            set { _BillChecked = value; }
        }

        internal Nullable<int> BillCheckedBy
        {
            get { return _BillCheckedBy; }
            set { _BillCheckedBy = value; }
        }

        internal Nullable<int> ItemsCount
        {
            get { return _ItemsCount; }
            set { _ItemsCount = value; }
        }

        internal string? IsItemMissing
        {
            get { return _IsItemMissing; }
            set { _IsItemMissing = value; }
        }

        internal string? MissingItemDetails
        {
            get { return _MissingItemDetails; }
            set { _MissingItemDetails = value; }
        }

        internal string? PurchaseEntryStatus
        {
            get { return _PurchaseEntryStatus; }
            set { _PurchaseEntryStatus = value; }
        }

        internal Nullable<int> PurchaseEntryBy
        {
            get { return _PurchaseEntryBy; }
            set { _PurchaseEntryBy = value; }
        }

        internal string? IsMissingItemReceived
        {
            get { return _IsMissingItemReceived; }
            set { _IsMissingItemReceived = value; }
        }

        internal Nullable<int> MissingItemReceivedBy
        {
            get { return _MissingItemReceivedBy; }
            set { _MissingItemReceivedBy = value; }
        }

        internal string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        internal decimal AmountPaid
        {
            get { return _AmountPaid; }
            set { _AmountPaid = value; }
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
                string SqlQuery = "SpSaveVendorBillDetails";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@VendorCode", this.VendorCode),
                    new SqlParameter("@BillNo", this.BillNo),
                    new SqlParameter("@BillDate", this.BillDate),
                    new SqlParameter("@BillAmount", this.BillAmount),
                    new SqlParameter("@BillChecked", this.BillChecked),
                    new SqlParameter("@BillCheckedBy", this.BillCheckedBy.HasValue ? this.BillCheckedBy.Value : DBNull.Value),

                    new SqlParameter("@ItemsCount", this.ItemsCount.HasValue ?  this.ItemsCount : DBNull.Value),
                    new SqlParameter("@IsItemMissing", this.IsItemMissing != null ? this.IsItemMissing : DBNull.Value),
                    new SqlParameter("@MissingItemDetails", this.MissingItemDetails != null ? this.MissingItemDetails : DBNull.Value),
                    new SqlParameter("@IsMissingItemReceived", this.IsMissingItemReceived != null ? this.IsMissingItemReceived : DBNull.Value),
                    new SqlParameter("@MissingItemReceivedBy", this.MissingItemReceivedBy.HasValue ? this.MissingItemReceivedBy.Value : DBNull.Value),
                    new SqlParameter("@PurchaseEntryStatus", this.PurchaseEntryStatus != null ? this.PurchaseEntryStatus : DBNull.Value),
                    new SqlParameter("@PurchaseEntryBy", this.PurchaseEntryBy.HasValue ? this.PurchaseEntryBy.Value : DBNull.Value),

                    new SqlParameter("@Remarks", this.Remarks),
                    new SqlParameter("@AmountPaid", this.AmountPaid),
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
                string SqlQuery = "SpUpdateVendorBillDetails";

                List<SqlParameter> _ListSqlParameter = new List<SqlParameter>
                {
                    new SqlParameter("@TranNo", this.TranNo),
                    new SqlParameter("@VendorCode", this.VendorCode),
                    new SqlParameter("@BillNo", this.BillNo),
                    new SqlParameter("@BillDate", this.BillDate),
                    new SqlParameter("@BillAmount", this.BillAmount),
                    new SqlParameter("@BillChecked", this.BillChecked),
                    new SqlParameter("@BillCheckedBy", this.BillCheckedBy.HasValue ? this.BillCheckedBy.Value : DBNull.Value),

                    new SqlParameter("@ItemsCount", this.ItemsCount.HasValue ?  this.ItemsCount : DBNull.Value),
                    new SqlParameter("@IsItemMissing", this.IsItemMissing != null ? this.IsItemMissing : DBNull.Value),
                    new SqlParameter("@MissingItemDetails", this.MissingItemDetails != null ? this.MissingItemDetails : DBNull.Value),
                    new SqlParameter("@IsMissingItemReceived", this.IsMissingItemReceived != null ? this.IsMissingItemReceived : DBNull.Value),
                    new SqlParameter("@MissingItemReceivedBy", this.MissingItemReceivedBy.HasValue ? this.MissingItemReceivedBy.Value : DBNull.Value),
                    new SqlParameter("@PurchaseEntryStatus", this.PurchaseEntryStatus != null ? this.PurchaseEntryStatus : DBNull.Value),
                    new SqlParameter("@PurchaseEntryBy", this.PurchaseEntryBy.HasValue ? this.PurchaseEntryBy.Value : DBNull.Value),

                    new SqlParameter("@Remarks", this.Remarks),
                    new SqlParameter("@AmountPaid", this.AmountPaid),
                    new SqlParameter("@UpdatedBy", Global.currentUserId)
                };

                _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

        private DataTable _VendorBillData = new DataTable();

        internal DataTable VendorBillData
        {
            get { return _VendorBillData; }
            set { _VendorBillData = value; }
        }

        internal void View()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();
                string SqlQuery = "SpGetVendorBillDetails";

                _VendorBillData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }

}

