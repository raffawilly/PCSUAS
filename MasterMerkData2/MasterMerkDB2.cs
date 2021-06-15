﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMerkData2
{
    public static class MasterMerkDB2
    {
        public static List<MasterMerk2> get()
        {
            List<MasterMerk2> merkList = new List<MasterMerk2>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            string selectStatement =
                "SELECT ID, MERK_CODE, MERK_DESC " +
                "FROM m_merk ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk2 mastermerk = new MasterMerk2();
                    mastermerk.Id = (int)reader["ID"];
                    mastermerk.Merk_code = reader["MERK_CODE"].ToString();
                    mastermerk.Merk_desc = reader["MERK_DESC"].ToString();
                    merkList.Add(mastermerk);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return merkList;
        }
    }
}
