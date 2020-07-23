﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.Common;
using Connection;

namespace DataAccess
{
    public class clTTTT
    {
        public DataTable SELECT_TTTT_DN_KEHOACH(string pMA_DVIQLY,string pMA_TRAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TTTT_DN_KEHOACH";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVILQY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMA_TRAM", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public void Insert_TTTT_DN_KEHOACH(string pMA_DVIQLY, string pMA_TRAM, int pKEHOACH, int pTHANG, int pNAM, DateTime pNGAYTAO)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_DN_KEHOACH";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVILQY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMA_TRAM", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("pKEHOACH", OracleType.Number).Value = pKEHOACH;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = pNGAYTAO;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void Update_TTTT_DN_KEHOACH(string pMA_DVIQLY, string pMA_TRAM, int pKEHOACH, int pTHANG, int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.UPDATE_TTTT_DN_KEHOACH";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVILQY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMA_TRAM", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("pKEHOACH", OracleType.Number).Value = pKEHOACH;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void DELETE_TTTT_DN_KEHOACH(string pMA_DVIQLY,string pMA_TRAM, int pKEHOACH, int pTHANG, int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_DN_KEHOACH";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVILQY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMA_TRAM", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("pKEHOACH", OracleType.Number).Value = pKEHOACH;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }

        public DataTable select_TTTT_TONTHATKYTHUAT_THANG(string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM, int kieudulieu)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.select_TTTT_CHUKYTAI_THANG";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pKIEUDULIEU", OracleType.Number).Value = kieudulieu;

                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public void INSERT_TTTT_SLGNUT_CHUKY(string pMA_DVIQLY, string pMATRAM, string pMACOT, int pTHANG, int pNAM, decimal pSANLUONG, int pNGAY, int ChuKy)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_SLGNUT_CHUKY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.NVarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pMACOT", OracleType.VarChar).Value = pMACOT;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pSANLUONG", OracleType.Number).Value = pSANLUONG;
                objCmd.Parameters.Add("pNGAY", OracleType.Number).Value = pNGAY;
                objCmd.Parameters.Add("pCHUKY", OracleType.Number).Value = ChuKy;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public DataTable SELECT_TONTHAT_CHUKY(string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM, int pNGAYHT, int pGIOHT, int pNGAYCHUKYSAU, int pCHUKYSAU, int KIEMTRA)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TONTHAT_CHUKY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pNGAYHT", OracleType.Number).Value = pNGAYHT;
                objCmd.Parameters.Add("pGIOHT", OracleType.Number).Value = pGIOHT;
                objCmd.Parameters.Add("pNGAYCHUKYSAU", OracleType.Number).Value = pNGAYCHUKYSAU;
                objCmd.Parameters.Add("pCHUKYSAU", OracleType.Number).Value = pCHUKYSAU;
                objCmd.Parameters.Add("pKIEMTRA", OracleType.Number).Value = KIEMTRA;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public void INSERT_TTTT_CHUKYSLG_THANG(string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM, int pNGAY, int pGIO, decimal pCS)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_CHUKYSLG_THANG"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pNGAY", OracleType.Number).Value = pNGAY;
                objCmd.Parameters.Add("pGIO", OracleType.Number).Value = pGIO;
                objCmd.Parameters.Add("pCS", OracleType.Number).Value = pCS;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public DataTable Get_SLKhang(string pMA_DVIQLY, string pMakhang, int pTHANG, int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_NPCTTTT.Get_SLKhang";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMakhang", OracleType.VarChar).Value = pMakhang;
                objCmd.Parameters.Add("pThang", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNam", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public DataTable Get_Khang_byMaTBA(string pMA_DVIQLY, string pMA_TRAM, int pTHANG, int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_NPCTTTT.Get_Khang_byMaTBA";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("p_MaTram", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("pThang", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNam", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public DataTable SELECT_TONTHATKD_BYTRAM(string pMA_DVIQLY, string pMA_TRAM, int pTHANG , int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TONTHATKD_BYTRAM";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMA_TRAM", OracleType.VarChar).Value = pMA_TRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public DataTable SELECT_TRAM_HATHE(string pMA_DVIQLY)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TRAM_HATHE";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public DataTable SELECT_TTTT_TONTHATKYTHUAT_THANG(int pID)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TTTT_TONTHATKYTHUAT_THANG";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("ID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public void Delete_TTTT_TRAM_CHUYKYTINH(string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.Delete_TTTT_TRAM_CHUYKYTINH";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.NVarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void Insert_TTTT_TONTHATKYTHUAT_THANG(int pID, string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM, decimal pTONTHAT, DateTime pNGAYTAO, int pNGAY, int ChuKy)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_TONTHATKYTHUAT_THANG";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.NVarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pTONTHAT", OracleType.Number).Value = pTONTHAT;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = pNGAYTAO;
                objCmd.Parameters.Add("pNGAY", OracleType.Number).Value = pNGAY;
                objCmd.Parameters.Add("pCHUKY", OracleType.Number).Value = ChuKy;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void Update_TTTT_TONTHATKYTHUAT_THANG(int pID, string pMA_DVIQLY, string pMATRAM, int pTHANG, int pNAM, int pTONTHAT, DateTime pNGAYTAO)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.UPDATE_TTTT_TONTHATKYTHUAT_THANG";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("ID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("MA_DVIQLY", OracleType.NVarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("MATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("THANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("NAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("TONTHAT", OracleType.Number).Value = pTONTHAT;
                objCmd.Parameters.Add("NGAYTAO", OracleType.DateTime).Value = pNGAYTAO;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void DELETE_TTTT_TONTHATKYTHUAT_THANG(int pID)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_TONTHATKYTHUAT_THANG";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("ID", OracleType.Number).Value = pID;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }

        public DataTable TTTT_SELECT_SLG_DUONGDAY_TRAM(string pMA_DVIQLY,string pMATRAM,int pTHANG,int pNAM,int Ngay,int Gio)
        {
            DataTable dt = new DataTable(); OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.TTTT_SELECT_SLG_DUONGDAY_TRAM";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pTHANG", OracleType.Number).Value = pTHANG;
                objCmd.Parameters.Add("pNAM", OracleType.Number).Value = pNAM;
                objCmd.Parameters.Add("pNGAY", OracleType.Number).Value = Ngay;
                objCmd.Parameters.Add("pGIO", OracleType.Number).Value = Gio;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;

        }
        public void DELETE_TTTT_DM_LOAIDUONGDAY(int PID)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_DM_LOAIDUONGDAY"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public void DELETE_TTTT_DUONGDAYTRAM_BYTRAM(string pMATRAM)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_DUONGDAYTRAM_BYTRAM";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = pMATRAM;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public void DELETE_TTTT_DUONGDAY_TRAM(int PID)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_DUONGDAY_TRAM"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public void INSERT_TTTT_DM_LOAIDUONGDAY(int PID, string pMA_DVIQLY, string PMALOAIDAY, int PLOAIDAY, int PDIENTROSUAT, DateTime PNGAYTAO, int PNGUOITAO)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_DM_LOAIDUONGDAY"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMALOAIDAY", OracleType.VarChar).Value = PMALOAIDAY;
                objCmd.Parameters.Add("pLOAIDAY", OracleType.Number).Value = PLOAIDAY;
                objCmd.Parameters.Add("pDIENTROSUAT", OracleType.Number).Value = PDIENTROSUAT;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = PNGAYTAO; objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = PNGUOITAO;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public void INSERT_TTTT_DUONGDAY_TRAM(int PID, string PMATRAM, string PDIEMDAU, string PDIEMCUOI, string PIDLOAIDAY, DateTime PNGAYTAO, int PNGUOITAO, string pMA_DVIQLY, decimal pHESOCONGSUAT,decimal pCHIEUDAI,decimal pTongDienAP)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_DUONGDAY_TRAM"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = PMATRAM;
                objCmd.Parameters.Add("pDIEMDAU", OracleType.VarChar).Value = PDIEMDAU;
                objCmd.Parameters.Add("pDIEMCUOI", OracleType.VarChar).Value = PDIEMCUOI;
                objCmd.Parameters.Add("pIDLOAIDAY", OracleType.VarChar).Value = PIDLOAIDAY;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = PNGAYTAO; objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = PNGUOITAO;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pHESOCONGSUAT", OracleType.Number).Value = pHESOCONGSUAT;
                objCmd.Parameters.Add("pCHIEUDAI", OracleType.Number).Value = pCHIEUDAI;
                objCmd.Parameters.Add("pTONGDIENAP", OracleType.Number).Value = pTongDienAP;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public DataTable SELECT_ALLDUONGDAY(string pMA_DVIQLY)
        {
            DataTable dt = new DataTable(); OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_ALLDUONGDAY"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;

        }
        public DataTable SELECT_TTTT_DM_LOAIDUONGDAY(int PID)
        {
            DataTable dt = new DataTable(); OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TTTT_DM_LOAIDUONGDAY"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;

        }
        public DataTable SELECT_TTTT_DUONGDAY_TRAM(int PID)
        {
            DataTable dt = new DataTable(); OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(""));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TTTT_DUONGDAY_TRAM"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;

        }
        public DataTable TTTT_DM_LOAIDUONGDAY_CHECKNAME(int PID, string pMA_DVIQLY, string PMALOAIDAY)
        {
            DataTable dt = new DataTable(); OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.TTTT_DM_LOAIDUONGDAY_CHECKNAME"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMALOAIDAY", OracleType.VarChar).Value = PMALOAIDAY;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;

        }
        public void UPDATE_TTTT_DM_LOAIDUONGDAY(int PID, string pMA_DVIQLY, string PMALOAIDAY, int PLOAIDAY, int PDIENTROSUAT, DateTime PNGAYTAO, int PNGUOITAO)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.UPDATE_TTTT_DM_LOAIDUONGDAY"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMALOAIDAY", OracleType.VarChar).Value = PMALOAIDAY;
                objCmd.Parameters.Add("pLOAIDAY", OracleType.Number).Value = PLOAIDAY;
                objCmd.Parameters.Add("pDIENTROSUAT", OracleType.Number).Value = PDIENTROSUAT;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = PNGAYTAO; objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = PNGUOITAO;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
        public void UPDATE_TTTT_DUONGDAY_TRAM(int PID, string PMATRAM, string PDIEMDAU, string PDIEMCUOI, int PIDLOAIDAY, DateTime PNGAYTAO, int PNGUOITAO, string pMA_DVIQLY, int PHESOCONGSUAT)
        {
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.UPDATE_TTTT_DUONGDAY_TRAM"; objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = PID;
                objCmd.Parameters.Add("pMATRAM", OracleType.VarChar).Value = PMATRAM;
                objCmd.Parameters.Add("pDIEMDAU", OracleType.VarChar).Value = PDIEMDAU;
                objCmd.Parameters.Add("pDIEMCUOI", OracleType.VarChar).Value = PDIEMCUOI;
                objCmd.Parameters.Add("pIDLOAIDAY", OracleType.Number).Value = PIDLOAIDAY;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = PNGAYTAO; objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = PNGUOITAO;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pHESOCONGSUAT", OracleType.Number).Value = PHESOCONGSUAT;

                OracleDataReader objReader = objCmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }

        }
     
        
        public DataTable SELECT_TTTT_DM_LOAIDUONGDAY(int pID, string pMA_DVIQLY)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.SELECT_TTTT_DM_LOAIDUONGDAY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("rs", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = objCmd.ExecuteReader();
                dt.Load(objReader);
                objConn.Close();
                objCmd.Dispose();
                objCmd = null;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
            return dt;
        }
        public void Insert_TTTT_DM_LOAIDUONGDAY(int pID, string pMA_DVIQLY, string pMALOAIDAY, string pTENLOAIDAY, int pLOAIDAY, decimal pDIENTROSUAT, DateTime pNGAYTAO, int pNGUOITAO)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.INSERT_TTTT_DM_LOAIDUONGDAY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMALOAIDAY", OracleType.VarChar).Value = pMALOAIDAY;
                objCmd.Parameters.Add("pTENLOAIDAY", OracleType.NVarChar).Value = pTENLOAIDAY;
                objCmd.Parameters.Add("pLOAIDAY", OracleType.Number).Value = pLOAIDAY;
                objCmd.Parameters.Add("pDIENTROSUAT", OracleType.Number).Value = pDIENTROSUAT;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = pNGAYTAO;
                objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = pNGUOITAO;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void Update_TTTT_DM_LOAIDUONGDAY(int pID, string pMA_DVIQLY, string pMALOAIDAY, string pTENLOAIDAY, int pLOAIDAY, decimal pDIENTROSUAT, DateTime pNGAYTAO, int pNGUOITAO)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.UPDATE_TTTT_DM_LOAIDUONGDAY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = pID;
                objCmd.Parameters.Add("pMA_DVIQLY", OracleType.VarChar).Value = pMA_DVIQLY;
                objCmd.Parameters.Add("pMALOAIDAY", OracleType.VarChar).Value = pMALOAIDAY;
                objCmd.Parameters.Add("pTENLOAIDAY", OracleType.NVarChar).Value = pTENLOAIDAY;
                objCmd.Parameters.Add("pLOAIDAY", OracleType.Number).Value = pLOAIDAY;
                objCmd.Parameters.Add("pDIENTROSUAT", OracleType.Number).Value = pDIENTROSUAT;
                objCmd.Parameters.Add("pNGAYTAO", OracleType.DateTime).Value = pNGAYTAO;
                objCmd.Parameters.Add("pNGUOITAO", OracleType.Number).Value = pNGUOITAO;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }
        public void DELETE_TTTT_DM_LOAIDUONGDAY(int pID, string pMA_DVIQLY)
        {
            DataTable dt = new DataTable();
            OracleConnection objConn = new OracleConnection(ConnectString.ConnectionString(pMA_DVIQLY));
            OracleCommand objCmd = new OracleCommand();
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;
                objCmd.CommandText = "PKG_TTTT.DELETE_TTTT_DM_LOAIDUONGDAY";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("pID", OracleType.Number).Value = pID;
                OracleDataReader objReader = objCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
                objCmd = null;
            }
        }

    }
}