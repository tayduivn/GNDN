//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       DataAcessGen.cst
//-- Date Generated: Monday, July 12, 2010
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Connection;
using Entity;


namespace DataAccess
{
    public partial class SYS_ExceptionDataAccess
    {

        private SYS_Exception _sys_exception;

        private MSSqlHelper _DbHelper = new MSSqlHelper();

        public static string FIELD_ID = "ID";
        public static string FIELD_TIME = "Time";
        public static string FIELD_EXCEPTIONTRACE = "ExceptionTrace";


        #region Private methods

        private static void SetSYS_ExceptionInfo(DbDataReader reader, ref SYS_Exception sys_exception)
        {
            sys_exception.ID = int.Parse("0" + reader[FIELD_ID]);
            DateTime Time = (DateTime)reader[FIELD_TIME];
            sys_exception.Time = Time != null ? (DateTime)Time : DateTime.Now;
            sys_exception.ExceptionTrace = "" + reader[FIELD_EXCEPTIONTRACE];
        }

        private static void SetListSYS_ExceptionInfo(ref DbDataReader reader, ref List<SYS_Exception> sys_exceptions)
        {
            SYS_Exception sys_exception = null;
            while (reader.Read())
            {
                sys_exception = new SYS_Exception();
                SYS_ExceptionDataAccess.SetSYS_ExceptionInfo(reader, ref sys_exception);
                sys_exceptions.Add(sys_exception);
            }
        }

        #endregion

        #region Static methods
        #endregion
        public int InsertSYS_Exception(SYS_Exception sys_exception)
        {
            DbConnection conn = _DbHelper.CreateConnection(Common.ConnectionString);
            conn.Open();
            try
            {
                List<DbParameter> para = new List<DbParameter>();
                DbParameter ouput = _DbHelper.CreateParameter(FIELD_ID, DbType.Int32, true);
                para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));
                para.Add(ouput);
                _DbHelper.ExecuteReader(conn, Common.DatabaseSchema + "[SYS_Exception_Insert]", para.ToArray());
                return (int)ouput.Value;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Insert: {0}", ex.Message));
            }
            finally
            {
                conn.Close();
            }
        }

        public int UpdateSYS_Exception(List<SYS_Exception> sys_exceptions)
        {
            DbConnection conn = _DbHelper.CreateConnection(Common.ConnectionString);
            conn.Open();
            int count = 0;
            try
            {

                foreach (SYS_Exception sys_exception in sys_exceptions)
                {
                    List<DbParameter> para = new List<DbParameter>();

                    para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));
                    para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                    para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));

                    _DbHelper.ExecuteNonQuery(conn, Common.DatabaseSchema + "[sys_exception_Update]", para.ToArray());
                    count++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Update: {0}", ex.Message));
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public void UpdateSYS_Exception(SYS_Exception sys_exception)
        {
            DbConnection conn = _DbHelper.CreateConnection(Common.ConnectionString);
            conn.Open();
            try
            {
                List<DbParameter> para = new List<DbParameter>();

                para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));
                para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));

                _DbHelper.ExecuteReader(conn, Common.DatabaseSchema + "[SYS_Exception_Update]", para.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Update: {0}", ex.Message));
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteSYS_Exception(List<SYS_Exception> sys_exceptions)
        {
            DbConnection conn = _DbHelper.CreateConnection(Common.ConnectionString);
            conn.Open();
            List<DbParameter> para = new List<DbParameter>();

            try
            {

                foreach (SYS_Exception sys_exception in sys_exceptions)
                {

                    para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));

                    _DbHelper.ExecuteNonQuery(conn, Common.DatabaseSchema + "[SYS_Exception_Delete]", para.ToArray());
                    para.Clear();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Delete: {0}", ex.Message));
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteSYS_Exception(SYS_Exception sys_exception)
        {
            DbConnection conn = _DbHelper.CreateConnection(Common.ConnectionString);
            conn.Open();
            try
            {
                List<DbParameter> para = new List<DbParameter>();
                para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));
                _DbHelper.ExecuteReader(conn, Common.DatabaseSchema + "[SYS_Exception_Delete]", para.ToArray());
            }
            catch (Exception)
            {


                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        public SYS_Exception SelectSYS_Exception(int ID)
        {

            SYS_Exception sys_exception = new SYS_Exception();
            DbDataReader reader = null;
            DbConnection connection = Common.CreateConnection(Common.ConnectionString);
            connection.Open();
            try
            {
                List<DbParameter> para = new List<DbParameter>();
                para.Add(_DbHelper.CreateParameter(FIELD_ID, ID, false));

                reader = _DbHelper.ExecuteReader(connection, Common.DatabaseSchema + "[SYS_Exception_SelectById]", para.ToArray());
                if (reader.HasRows && reader.Read())
                    SYS_ExceptionDataAccess.SetSYS_ExceptionInfo(reader, ref sys_exception);
                return sys_exception;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.SelectById: {0}", ex.Message));
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                connection.Close();
            }

        }


        public List<SYS_Exception> SelectAllSYS_Exception()
        {
            List<SYS_Exception> sys_exception = new List<SYS_Exception>();
            DbDataReader reader = null;
            DbConnection connection = Common.CreateConnection(Common.ConnectionString);
            connection.Open();
            try
            {
                reader = _DbHelper.ExecuteReader(connection, Common.DatabaseSchema + "[SYS_Exception_SelectAll]", (DbParameter[])null);
                if (reader.HasRows)
                    SYS_ExceptionDataAccess.SetListSYS_ExceptionInfo(ref reader, ref sys_exception);
                return sys_exception;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format(" SYS_ExceptionDataAccess.SelectAll: {0}", ex.Message));
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                connection.Close();
            }
        }

        public int InsertSYS_Exception(DbTransaction transaction, SYS_Exception sys_exception)
        {
            try
            {
                List<DbParameter> para = new List<DbParameter>();

                DbParameter ouput = _DbHelper.CreateParameter(FIELD_ID, DbType.Int32, true);
                para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));

                para.Add(ouput);

                _DbHelper.ExecuteNonQuery(transaction, Common.DatabaseSchema + "[SYS_Exception_Insert]", para.ToArray());

                return (int)ouput.Value;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Insert: {0}", ex.Message));
            }
        }



        public int UpdateSYS_Exception(DbTransaction transaction, List<SYS_Exception> sys_exceptions)
        {

            int count = 0;
            try
            {

                foreach (SYS_Exception sys_exception in sys_exceptions)
                {
                    List<DbParameter> para = new List<DbParameter>();

                    para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));
                    para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                    para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));

                    _DbHelper.ExecuteNonQuery(transaction, Common.DatabaseSchema + "[SYS_Exception_Update]", para.ToArray());
                    count++;
                }
            }

            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Update: {0}", ex.Message));
            }

            return count;
        }

        public void UpdateSYS_Exception(DbTransaction transaction, SYS_Exception sys_exception)
        {
            try
            {
                List<DbParameter> para = new List<DbParameter>();

                para.Add(_DbHelper.CreateParameter(FIELD_ID, sys_exception.ID, false));
                para.Add(_DbHelper.CreateParameter(FIELD_TIME, sys_exception.Time, false));
                para.Add(_DbHelper.CreateParameter(FIELD_EXCEPTIONTRACE, sys_exception.ExceptionTrace, false));

                _DbHelper.ExecuteNonQuery(transaction, Common.DatabaseSchema + "[SYS_Exception_Update]", para.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Update: {0}", ex.Message));
            }
        }

        public int DeleteSYS_Exception(DbTransaction transaction, List<SYS_Exception> sys_exceptions)
        {
            int count = 0;
            try
            {
                List<DbParameter> para = new List<DbParameter>();
                foreach (SYS_Exception sys_exception in sys_exceptions)
                {
                    para.Add(_DbHelper.CreateParameter(FIELD_ID, DbType.Int32, false));

                    _DbHelper.ExecuteNonQuery(transaction, Common.DatabaseSchema + "[SYS_Exception_Delete]", para.ToArray());
                    para.Clear();
                    count++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SYS_ExceptionDataAccess.Delete: {0}", ex.Message));
            }

            return count;
        }
    }
}
