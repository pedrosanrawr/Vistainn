using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Vistainn
{
    //database class
    public abstract class Database
    {
        public string connectionString { get; set; } = "Server=localhost;Database=vistainn; Uid=root; Pwd=;";

        public abstract IDbConnection CreateConnection();

        public abstract void OpenConnection(IDbConnection connection);

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var conn = CreateConnection())
            {
                OpenConnection(conn); 
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                        }
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public abstract IDataReader ExecuteReader(string query, Dictionary<string, object> parameters = null);
    }

    //mysql database class
    public class MySqlDatabase : Database
    {
        public override IDbConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public override void OpenConnection(IDbConnection connection)
        {
            connection.Open();
        }

        public override IDataReader ExecuteReader(string query, Dictionary<string, object> parameters = null)
        {
            var conn = CreateConnection();
            OpenConnection(conn);
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                    }
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}
