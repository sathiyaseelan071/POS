using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VegetableBox
{
    internal class ClsFrmPos
    {
        public ClsFrmPos()
        {
            try
            {
                this.GetProductRateDetails();
                this.ToMakeCart();
            }
            catch
            {
                throw;
            }
        }

        private DataTable _ProductRateData = new DataTable();
        internal DataTable ProductRateData
        {
            get { return _ProductRateData; }
            set { _ProductRateData = value; }
        }

        public void GetProductRateDetails()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpGetProductRate";

                this._ProductRateData = new DataTable();
                this._ProductRateData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
                }
            catch
            {
                throw;
            }
        }

        private DataTable _CartData = new DataTable();
        internal DataTable CartData
        {
            get { return _CartData; }
            set { _CartData = value; }
        }

        private void ToMakeCart()
        {
            try
            {                
                this._CartData = new DataTable();

                this._CartData.Columns.Add(CartDataStruct.ColumnName.SNo, typeof(int));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.ProCode, typeof(int));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.ProTamilName, typeof(string));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.MRP, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.Qty, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.Unit, typeof(string));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.Rate, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.Amount, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.DiscPer, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.DiscAmount, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.TotDiscAmtFrmMrp, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.TotalAmount, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.CalBORM, typeof(string));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.TotMRP, typeof(decimal));

                this._CartData.Columns.Add(CartDataStruct.ColumnName.PurAmount, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.ProfitAmount, typeof(decimal));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.DiscEmpCode, typeof(int));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.DiscCustCode, typeof(int));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.IsDefective, typeof(string));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.AllowRateChange, typeof(bool));
                this._CartData.Columns.Add(CartDataStruct.ColumnName.SellingRateZero, typeof(bool));
            }
            catch
            {
                throw;
            }
        }

        public int SaveData(DataTable cartData, ClsTransaction clsTransaction, List<ClsPaymentDetails> listClsPaymentDetails)
        {
            try
            {
                DataTable SalesTableData = new DataTable();
                SalesTableData.Columns.Add("ProductCode", typeof(int));
                SalesTableData.Columns.Add("Qty", typeof(decimal));
                SalesTableData.Columns.Add("Unit", typeof(string));
                SalesTableData.Columns.Add("SellRate", typeof(decimal));
                SalesTableData.Columns.Add("Amount", typeof(decimal));
                SalesTableData.Columns.Add("DiscPercent", typeof(decimal));
                SalesTableData.Columns.Add("DiscAmount", typeof(decimal));
                SalesTableData.Columns.Add("TotAmount", typeof(decimal));
                SalesTableData.Columns.Add("MRP", typeof(decimal));
                SalesTableData.Columns.Add("TotDiscAmtFromMRP", typeof(decimal));
                SalesTableData.Columns.Add("BilledBy", typeof(int));

                SalesTableData.Columns.Add("PurAmount", typeof(decimal));
                SalesTableData.Columns.Add("ProfitAmount", typeof(decimal));
                SalesTableData.Columns.Add("DiscCustCode", typeof(int));
                SalesTableData.Columns.Add("DiscEmpCode", typeof(int));
                SalesTableData.Columns.Add("IsDefective", typeof(string));

                foreach (DataRow rowCartData in cartData.Rows)
                {
                    DataRow rowSales = SalesTableData.NewRow();

                    rowSales["ProductCode"] = rowCartData[CartDataStruct.ColumnName.ProCode];
                    rowSales["Qty"] = rowCartData[CartDataStruct.ColumnName.Qty];
                    rowSales["Unit"] = rowCartData[CartDataStruct.ColumnName.Unit];
                    rowSales["SellRate"] = rowCartData[CartDataStruct.ColumnName.Rate];
                    rowSales["Amount"] = rowCartData[CartDataStruct.ColumnName.Amount];
                    rowSales["DiscPercent"] = rowCartData[CartDataStruct.ColumnName.DiscPer];
                    rowSales["DiscAmount"] = rowCartData[CartDataStruct.ColumnName.DiscAmount];
                    rowSales["TotAmount"] = rowCartData[CartDataStruct.ColumnName.TotalAmount];
                    rowSales["BilledBy"] = Global.currentUserId;
                    rowSales["MRP"] = rowCartData[CartDataStruct.ColumnName.MRP];
                    rowSales["TotDiscAmtFromMRP"] = rowCartData[CartDataStruct.ColumnName.TotDiscAmtFrmMrp];

                    rowSales["PurAmount"] = rowCartData[CartDataStruct.ColumnName.PurAmount];
                    rowSales["ProfitAmount"] = rowCartData[CartDataStruct.ColumnName.ProfitAmount];
                    rowSales["DiscCustCode"] = rowCartData[CartDataStruct.ColumnName.DiscCustCode];
                    rowSales["DiscEmpCode"] = rowCartData[CartDataStruct.ColumnName.DiscEmpCode];
                    rowSales["IsDefective"] = rowCartData[CartDataStruct.ColumnName.IsDefective];

                    SalesTableData.Rows.Add(rowSales);
                }

                //SalesTableData = SalesTableData.AsEnumerable().OrderBy(x => x.Field<int>(CartDataStruct.ColumnName.SNo)).CopyToDataTable();
                SalesTableData.AcceptChanges();

                // *************

                DataTable TransactionData = new DataTable();
                TransactionData.Columns.Add("TotAmount", typeof(decimal));
                TransactionData.Columns.Add("DiscPercent", typeof(decimal));
                TransactionData.Columns.Add("DiscAmount", typeof(decimal));
                TransactionData.Columns.Add("GrossAmount", typeof(decimal));
                TransactionData.Columns.Add("RoundOffAmount", typeof(decimal));
                TransactionData.Columns.Add("NetAmount", typeof(decimal));
                TransactionData.Columns.Add("PrintTotMRP", typeof(decimal));
                TransactionData.Columns.Add("PrintTotDiscMRP", typeof(decimal));
                TransactionData.Columns.Add("BilledBy", typeof(int));
                TransactionData.Columns.Add("TotProfitAmount", typeof(decimal));

                DataRow rowTranData = TransactionData.NewRow();
                rowTranData["TotAmount"] = clsTransaction.TotAmount;
                rowTranData["DiscPercent"] = clsTransaction.DiscPercent;
                rowTranData["DiscAmount"] = clsTransaction.DiscAmount;
                rowTranData["GrossAmount"] = clsTransaction.GrossAmount;
                rowTranData["RoundOffAmount"] = clsTransaction.RoundOffAmount;
                rowTranData["NetAmount"] = clsTransaction.NetAmount;
                rowTranData["PrintTotMRP"] = clsTransaction.PrintTotMRP;
                rowTranData["PrintTotDiscMRP"] = clsTransaction.PrintTotDiscMRP;
                rowTranData["BilledBy"] = Global.currentUserId;
                rowTranData["TotProfitAmount"] = clsTransaction.TotProfitAmount;

                TransactionData.Rows.Add(rowTranData);
                TransactionData.AcceptChanges();

                // *************

                DataTable PaymentDetData = new DataTable();
                PaymentDetData.Columns.Add("PaymentType", typeof(string));
                PaymentDetData.Columns.Add("Amount", typeof(decimal));
                PaymentDetData.Columns.Add("CustomerCode", typeof(decimal));
                PaymentDetData.Columns.Add("BilledBy", typeof(int));

                foreach (ClsPaymentDetails clsPaymentDetails in listClsPaymentDetails)
                {
                    DataRow rowPaymentDetData = PaymentDetData.NewRow();
                    rowPaymentDetData["PaymentType"] = clsPaymentDetails.PaymentType;
                    rowPaymentDetData["Amount"] = clsPaymentDetails.Amount;
                    rowPaymentDetData["CustomerCode"] = clsPaymentDetails.CustomerCode;
                    rowPaymentDetData["BilledBy"] = Global.currentUserId;
                    PaymentDetData.Rows.Add(rowPaymentDetData);
                }

                PaymentDetData.AcceptChanges();

                // *************

                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpSaveSale";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@UDT_Sales", SalesTableData));
                _ListSqlParameter.Add(new SqlParameter("@UDT_Transaction", TransactionData));
                _ListSqlParameter.Add(new SqlParameter("@UDT_PaymentDetails", PaymentDetData));

                SqlParameter sqlParameter = new SqlParameter("@BILLNO", SqlDbType.Int, 8);
                sqlParameter.Direction = ParameterDirection.Output;
                _ListSqlParameter.Add(sqlParameter);

                int Result = Convert.ToInt32(_SqlIntract.ExecuteNonQueryWithOutputParam(SqlQuery, CommandType.StoredProcedure, "@BILLNO", _ListSqlParameter));

                return Result;
            }
            catch
            {
                throw;
            }
        } 

    }

    public class ClsTransaction
    {
        public decimal TotAmount { get; set; }
        public decimal DiscPercent { get; set; }
        public decimal DiscAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal RoundOffAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal PrintTotMRP { get; set; }
        public decimal PrintTotDiscMRP { get; set; }
        public decimal TotProfitAmount { get; set; }
    }

    public class ClsPaymentDetails
    {
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public int CustomerCode { get; set; } //Credit Customer Code
    }

    #region "Struct"

    internal struct CartDataStruct
    {
        internal struct ColumnName
        {
            internal static string SNo = "SNo";
            internal static string ProCode = "PCode";
            internal static string ProTamilName = "Product-TamilName";
            internal static string Qty = "Qty";
            internal static string Unit = "Unit";
            internal static string Rate = "Rate";
            internal static string MRP = "MRP";
            internal static string TotDiscAmtFrmMrp = "TotDiscAmtFromMRP";
            internal static string Amount = "Amt";
            internal static string DiscPer = "DiscPerFromSellRate";
            internal static string DiscAmount = "DiscAmount";
            internal static string TotalAmount = "TotalAmount";
            internal static string CalBORM = "CalBORM";
            internal static string TotMRP = "TotMRP";

            internal static string PurAmount = "PurAmt";
            internal static string ProfitAmount = "ProfitAmt";
            internal static string DiscEmpCode = "DiscEmpCode";
            internal static string DiscCustCode = "DiscCustCode";

            internal static string IsDefective = "IsDefective";
            internal static string AllowRateChange = "AllowRateChange";
            internal static string SellingRateZero = "SellingRateZero";
        }
    }

    #endregion
}
