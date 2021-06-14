using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MasterMerkData
{
    public static class MasterMerkDB
    {
        public static List<MasterMerk> get()
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = dbProjectUas.GetConnection();
            string selectStatement =
                "SELECT ID, MERK_CODE, MERK_DESC, " +
                "FROM m_merk ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk mastermerk = new MasterMerk();
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
