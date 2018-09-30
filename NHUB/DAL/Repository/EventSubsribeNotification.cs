using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL.Repository
{
    public class EventSubsribeNotification
    {
        public int InsertEvent_slm_subscribe(int Pevid,int Pslid,int Pslmid,bool Pconf,bool Pmand )
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connections.Constring;
            connection.Open();
            // Note the "placeholders" in the SQL query.
            string sql = "Insert Into Event_slm_subscribe" +
                                "(EventId, ServiceLineId, ServiceLineManagerId, Confidential, Mandatory) Values" +
                                "(@EventId, @ServiceLineId,@ServiceLineManagerId,@Confidential,@Mandatory)";


            // This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@EventId",
                    Value = Pevid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@ServiceLineId",
                    Value = Pslid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@ServiceLineManagerId",
                    Value = Pslmid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Confidential",
                    Value = Pconf,
                    SqlDbType = SqlDbType.Bit,
                    Size = 1
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "@Mandatory",
                    Value = Pconf,
                    SqlDbType = SqlDbType.Bit,
                    Size = 1
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

            string str = "select max(Id) from Event_slm_subscribe";
            SqlCommand sqlCommand = new SqlCommand(str, connection);
            int y = Convert.ToInt32(sqlCommand.ExecuteScalar());
            connection.Close();
            return y;
        }

        public void InsertEvent_slm_subscribe_channel(int PEslmid,int PChid)
        {
            
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Connections.Constring;
                connection.Open();
                // Note the "placeholders" in the SQL query.
                string sql = "Insert Into Event_slm_subscribe_channel" +
                                    "(Event_slm_subscribe_Id, ChannelId) Values" +
                                    "(@Event_slm_subscribe_Id, @ChannelId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Fill params collection.
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@Event_slm_subscribe_Id",
                        Value = PEslmid,
                        SqlDbType = SqlDbType.Int,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "@Channelid",
                        Value = PChid,
                        SqlDbType = SqlDbType.Int,
                        Size = 10
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

        public void InsertEvent_slm_subscribe_users(int PEslmid, int PUid)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Connections.Constring;
            connection.Open();
            // Note the "placeholders" in the SQL query.
            string sql = "Insert Into Event_slm_subscribe_users" +
                                "(Event_slm_subscribe_Id, UserId) Values" +
                                "(@Event_slm_subscribe_Id, @UserId)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Event_slm_subscribe_Id",
                    Value = PEslmid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "@UserId",
                    Value = PUid,
                    SqlDbType = SqlDbType.Int,
                    Size = 10
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

