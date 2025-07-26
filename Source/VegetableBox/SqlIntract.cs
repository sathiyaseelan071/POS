using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace VegetableBox
{
    internal class SqlIntract
    {
        public DataTable ExecuteDataTable(string SqlQuery, CommandType SqlCommandType, List<SqlParameter>? SqlParameterList = null)
        {
            try
            {
                SqlCommand _SqlCommand = new SqlCommand();
                SqlDataAdapter _SqlDataAdapter = new SqlDataAdapter();
                DataSet _DataSet = new DataSet();
                DataTable _DataTable = new DataTable();

                using (SqlConnection _SqlConnection = new SqlConnection(Global.sqlConnectionString))
                {
                    _SqlConnection.Open();
                    _SqlCommand.Connection = _SqlConnection;
                    _SqlCommand.CommandTimeout = 0;
                    _SqlCommand.CommandType = SqlCommandType;
                    _SqlCommand.CommandText = SqlQuery;

                    if (SqlParameterList != null)
                    {
                        _SqlCommand.Parameters.Clear();
                        foreach (SqlParameter oSqlParameter in SqlParameterList)
                        {
                            _SqlCommand.Parameters.Add(oSqlParameter);
                        }
                    }

                    _SqlDataAdapter.SelectCommand = _SqlCommand;
                    _SqlDataAdapter.Fill(_DataSet);

                    if (_DataSet != null && _DataSet.Tables.Count > 0) _DataTable = _DataSet.Tables[0];
                }

                return _DataTable;
            }
            catch
            {
                throw;
            }
        }

        public int ExecuteNonQuery(string SqlQuery, CommandType SqlCommandType, List<SqlParameter>? SqlParameterList = null)
        {
            try
            {
                int _RowsAffectedCount = 0;
                SqlCommand _SqlCommand = new SqlCommand();

                using (SqlConnection _SqlConnection = new SqlConnection(Global.sqlConnectionString))
                {
                    _SqlConnection.Open();
                    _SqlCommand.Connection = _SqlConnection;
                    _SqlCommand.CommandTimeout = 0;
                    _SqlCommand.CommandType = SqlCommandType;
                    _SqlCommand.CommandText = SqlQuery;

                    if (SqlParameterList != null)
                    {
                        _SqlCommand.Parameters.Clear();
                        foreach (SqlParameter oSqlParameter in SqlParameterList)
                        {
                            _SqlCommand.Parameters.Add(oSqlParameter);
                        }
                    }

                    _RowsAffectedCount = _SqlCommand.ExecuteNonQuery();
                }

                return _RowsAffectedCount;
            }
            catch
            {
                throw;
            }
        }

        public int ExecuteNonQueryWithOutputParam(string SqlQuery, CommandType SqlCommandType, string outPutParamName, List<SqlParameter>? SqlParameterList = null)
        {
            try
            {
                int _RowsAffectedCount = 0;
                int _OutputParam = 0;
                SqlCommand _SqlCommand = new SqlCommand();

                using (SqlConnection _SqlConnection = new SqlConnection(Global.sqlConnectionString))
                {
                    _SqlConnection.Open();
                    _SqlCommand.Connection = _SqlConnection;
                    _SqlCommand.CommandTimeout = 0;
                    _SqlCommand.CommandType = SqlCommandType;
                    _SqlCommand.CommandText = SqlQuery;

                    if (SqlParameterList != null)
                    {
                        _SqlCommand.Parameters.Clear();
                        foreach (SqlParameter oSqlParameter in SqlParameterList)
                        {
                            _SqlCommand.Parameters.Add(oSqlParameter);
                        }
                    }

                    _RowsAffectedCount = _SqlCommand.ExecuteNonQuery();
                    _OutputParam = Convert.ToInt32(_SqlCommand.Parameters[outPutParamName].Value);
                }

                return _OutputParam;
            }
            catch
            {
                throw;
            }
        }

        public Object ExecuteScalar(string SqlQuery, CommandType SqlCommandType, List<SqlParameter>? SqlParameterList = null)
        {
            try
            {
                Object? _Result = null;
                SqlCommand _SqlCommand = new SqlCommand();

                using (SqlConnection _SqlConnection = new SqlConnection(Global.sqlConnectionString))
                {
                    _SqlConnection.Open();
                    _SqlCommand.Connection = _SqlConnection;
                    _SqlCommand.CommandTimeout = 0;
                    _SqlCommand.CommandType = SqlCommandType;
                    _SqlCommand.CommandText = SqlQuery;

                    if (SqlParameterList != null)
                    {
                        _SqlCommand.Parameters.Clear();
                        foreach (SqlParameter oSqlParameter in SqlParameterList)
                        {
                            _SqlCommand.Parameters.Add(oSqlParameter);
                        }
                    }

                    _Result = _SqlCommand.ExecuteScalar();
                }

                return _Result;
            }
            catch
            {
                throw;
            }
        }

    }
}
