using System.Data;
using System.Reflection;
using Microsoft.Data.SqlClient;


namespace UTIL_Valication
{
    public class DBUTIL
    {
        private static string connString = "Server =NGUYENNHUTDUY\\NHUTDUY; Database =QuanLiRapChieuPhim; Integrated Security = true; TrustServerCertificate=True";
        public static SqlCommand GetCommand(string sql, List<Object> args, CommandType cmdTyoe)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = cmdTyoe;
            if (args != null)
            {
                for (int i = 0; i < args.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@" + i, args[i]);
                }
            }
            return cmd;
        }
        public static void Update(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            SqlCommand cmd = GetCommand(sql, args, cmdType);
            cmd.Connection.Open();
            cmd.Transaction = cmd.Connection.BeginTransaction();
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

            }
            catch (Exception)
            {
                cmd.Transaction.Rollback();
                throw;
            }
        }
        public static SqlDataReader Query(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SqlCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static Object Value(string sql, List<Object> args, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SqlCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Object result = new object();

                if (reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        PropertyInfo propertyInfo = result.GetType().GetProperty(columnName);

                        if (propertyInfo != null)
                        {
                            var value = reader.IsDBNull(i) ? null : reader[columnName];
                            propertyInfo.SetValue(result, value);
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static object ScalarQuery(string sql, List<object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"{i + 1}", parameters[i] ?? DBUTIL.Value);

                    }
                    object result = cmd.ExecuteScalar();
                    return result;
                }
            }
        }
        public static string GenerateId(string tableName, string columnName, string prefix)
        {
            string query = $"SELECT TOP 1 {columnName} FROM {tableName} ORDER BY {columnName} DESC";
            try
            {
                // Get the maximum ID from the database
                string lastId = ScalarQuery(query, new List<object>())?.ToString() ?? string.Empty;
                if (string.IsNullOrEmpty(lastId))
                {
                    return prefix + "001";
                }
                // Extract the numeric part and increment it
                string numericPart = lastId.Substring(prefix.Length);


                // Check if the numeric part is a valid number
                if (!int.TryParse(numericPart, out int nextNumber))
                {
                    throw new FormatException($"The last ID '{lastId}' does not match the expected format for table {tableName}. Please delete the invalid staffId in database");
                }

                nextNumber = nextNumber + 1;
                return prefix + nextNumber.ToString("D3");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating new ID for table {tableName}: " + ex.Message);
            }
        }

    }

}

