﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai
{
    class Connection
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public Connection()
        {
            conn = ConnectionDB.get();
            comm = conn.CreateCommand();
        }
        public DataTable ExcuteQuery(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = null;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.CommandType = ct;
                comm.CommandText = strSQL;
                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Lỗi kết nối!");
                return null;
            }
            return dt;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public bool BackUpOrRestore(string strSQL, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch(SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
