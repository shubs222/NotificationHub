using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL.Repository
{
    public class AddNotificationRepository
    {

        public int InsertEvent(string Name, int Sourceid)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connections.Constring;
            connection.Open();
            // Note the "placeholders" in the SQL query.
            string sql = "Insert Into Event" +
                                "(Name, SourceId) Values" +
                                "(@Name, @Sourceid)";


            // This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = Name,
                    SqlDbType = SqlDbType.Char,
                    Size = 30
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Sourceid",
                    Value = Sourceid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                //parameter = new SqlParameter
                //{
                //    ParameterName = "@Mandatory",
                //    Value = Mandetory,
                //    SqlDbType = SqlDbType.Bit,
                //    Size = 1
                //};
                //command.Parameters.Add(parameter);

                //parameter = new SqlParameter
                //{
                //    ParameterName = "@Confidential",
                //    Value = Confidential,
                //    SqlDbType = SqlDbType.Bit,
                //    Size = 1
                //};
                //command.Parameters.Add(parameter);


                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Cant insert Data!", ex);
                    throw error;
                }
            }
            //string str = "select SCOPE_IDENTITY()";
            //SqlCommand sqlCommand = new SqlCommand(str, connection);
            //object o = sqlCommand.ExecuteScalar();
            //long y= Convert.ToInt64(o);
            string str = "select max(Id) from event";
            SqlCommand sqlCommand = new SqlCommand(str, connection);
            int y = Convert.ToInt32(sqlCommand.ExecuteScalar());
            connection.Close();
             return y;
        }
        public void InsertEventChannel(long id, int channelid)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connections.Constring;
            connection.Open();
            // Note the "placeholders" in the SQL query.
            string sql = "Insert Into EventChannel" +
                                "(EventId, ChannelId) Values" +
                                "(@Eventid, @Channelid)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Eventid",
                    Value = id,
                    SqlDbType = SqlDbType.Int,
                    Size = 30
                };
                command.Parameters.Add(parameter);
                 parameter = new SqlParameter
                {
                    ParameterName = "@Channelid",
                    Value = channelid,
                    SqlDbType = SqlDbType.Int,
                    Size = 30
                };
                command.Parameters.Add(parameter);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Cant insert Data!", ex);
                    throw error;
                }
            }
        }
       
    }
    
}
