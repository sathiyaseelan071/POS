using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    internal class ClsFrmAttendance
    {

        private DataTable _TodayData = new DataTable();
        internal DataTable TodayData
        {
            get { return _TodayData; }
            set { _TodayData = value; }
        }

        private DataTable _MonthlyData = new DataTable();
        internal DataTable MonthlyData
        {
            get { return _MonthlyData; }
            set { _MonthlyData = value; }
        }

        internal string GetAction()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SELECT CASE WHEN EXISTS (SELECT 1 FROM [dbo].[SalesPersonAttendance] A";
                SqlQuery += Environment.NewLine + "WHERE A.[SalesPersonId] = U.[Code] AND A.[AttendanceDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "AND A.[LogIn] IS NOT NULL AND A.[LogOut] IS NULL) THEN 'LOGOUT' ELSE 'LOGIN' END AS [Action]";
                SqlQuery += Environment.NewLine + "FROM [dbo].[User] U";
                SqlQuery += Environment.NewLine + "WHERE U.[Code] = @SalesPersonId";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@SalesPersonId", Global.currentUserId));

                string _Result = (string)_SqlIntract.ExecuteScalar(SqlQuery, CommandType.Text, _ListSqlParameter);

                return _Result;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetTodayData()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SELECT U.[Code] AS [UserId], U.[Name] AS [Name], FORMAT(S.[Login], 'dd-MMM-yyyy hh:mm tt') AS [LoginTime],";
                SqlQuery += Environment.NewLine + "FORMAT(S.[Logout], 'dd-MMM-yyyy hh:mm tt') AS [LogOutTime],";
                SqlQuery += Environment.NewLine + "CAST(S.[WorkedMinutes] / 60 AS VARCHAR(10)) + ':' + RIGHT('00' + CAST(S.[WorkedMinutes] % 60 AS VARCHAR(2)), 2) AS [TotalHr],";
                SqlQuery += Environment.NewLine + "S.[Remarks]";
                SqlQuery += Environment.NewLine + "FROM [dbo].[SalesPersonAttendance] AS S";
                SqlQuery += Environment.NewLine + "INNER JOIN [dbo].[User] AS U ON U.[Code] = S.[SalesPersonId]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";

                if (Global.currentUserId != 1)
                    SqlQuery += Environment.NewLine + "AND S.[SalesPersonId] = @SalesPersonId";

                SqlQuery += Environment.NewLine + "AND S.[AttendanceDate] = CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "ORDER BY S.[Login] DESC";

                if (Global.currentUserId != 1)
                {
                    List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                    _ListSqlParameter.Add(new SqlParameter("@SalesPersonId", Global.currentUserId));

                    _TodayData = new DataTable();
                    _TodayData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, _ListSqlParameter);
                }
                else
                {
                    _TodayData = new DataTable();
                    _TodayData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
                }

                return _TodayData;
            }
            catch
            {
                throw;
            }
        }

        internal DataTable GetMonthlyData()
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SELECT U.[Code] AS [UserId], U.[Name] AS [Name], [AttendanceDate], SUM(ISNULL([WorkedMinutes], 0)) AS TotalWorkedMinutes,";
                SqlQuery += Environment.NewLine + "CONCAT(SUM(ISNULL([WorkedMinutes], 0)) / 60, ':', RIGHT('00' + CAST(SUM(ISNULL([WorkedMinutes], 0)) % 60 AS VARCHAR(2)), 2)) AS TotalWorkingHr";
                SqlQuery += Environment.NewLine + "FROM [dbo].[SalesPersonAttendance] AS S";
                SqlQuery += Environment.NewLine + "INNER JOIN [dbo].[User] AS U ON U.[Code] = S.[SalesPersonId]";
                SqlQuery += Environment.NewLine + "WHERE 1=1";

                if (Global.currentUserId != 1)
                    SqlQuery += Environment.NewLine + "AND S.[SalesPersonId] = @SalesPersonId";

                SqlQuery += Environment.NewLine + "AND S.[AttendanceDate] >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)";
                SqlQuery += Environment.NewLine + "AND S.[AttendanceDate] <= CAST(GETDATE() AS DATE)";
                SqlQuery += Environment.NewLine + "GROUP BY U.[Code], U.[Name], [AttendanceDate]";
                SqlQuery += Environment.NewLine + "ORDER BY [AttendanceDate] DESC, U.[Code]";

                if (Global.currentUserId != 1)
                {
                    List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                    _ListSqlParameter.Add(new SqlParameter("@SalesPersonId", Global.currentUserId));

                    _MonthlyData = new DataTable();
                    _MonthlyData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, _ListSqlParameter);
                }
                else
                {
                    _MonthlyData = new DataTable();
                    _MonthlyData = _SqlIntract.ExecuteDataTable(SqlQuery, CommandType.Text, null);
                }

                return _MonthlyData;
            }
            catch
            {
                throw;
            }
        }

        internal void Update(int UserId, string Action, string Remarks)
        {
            try
            {
                SqlIntract _SqlIntract = new SqlIntract();

                String SqlQuery = "SpUpdateSalesPersonAttendance";

                List<SqlParameter>? _ListSqlParameter = new List<SqlParameter>();
                _ListSqlParameter.Add(new SqlParameter("@SalesPersonId", UserId));
                _ListSqlParameter.Add(new SqlParameter("@Action", Action));
                _ListSqlParameter.Add(new SqlParameter("@Remarks", Remarks));
                
                int Result = _SqlIntract.ExecuteNonQuery(SqlQuery, CommandType.StoredProcedure, _ListSqlParameter);
            }
            catch
            {
                throw;
            }
        }

    }
}
