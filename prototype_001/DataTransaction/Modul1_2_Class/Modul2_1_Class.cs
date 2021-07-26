using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AppConfig; 

namespace DataTransaction.Modul1_2__Class
{
    public class Modul2_1_Class
    {
        public DataTable Modul1_2(DataTable dt, string job)
        {
            app_config appconfig = new app_config();

            appconfig.openConnection();
            var trans = appconfig.mycontrans;

            if (job == app_helper.show)
            {
                try
                {
                    

                    appconfig.cmd = new SqlCommand();

                    var cmd = appconfig.cmd;
                    cmd.Connection = appconfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.spMenu2_1";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = app_helper.show;
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = DBNull.Value;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = DBNull.Value;
                    cmd.Parameters.Add("@ttl", SqlDbType.Date).Value = DBNull.Value;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 1000).Value = DBNull.Value;

                    dt.Clear();

                    appconfig.DA = new SqlDataAdapter(cmd);

                    var da = appconfig.DA;

                    da.Fill(dt);
                    da.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else if (job == app_helper.insert)
            {
                try
                {
                    appconfig.cmd = new SqlCommand();

                    var cmd = appconfig.cmd;
                    cmd.Connection = appconfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.spMenu2_1";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = "create";
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dt.Rows[0]["ID"];
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = dt.Rows[0]["Nama"] != DBNull.Value ? dt.Rows[0]["Nama"] : "No Name";
                    cmd.Parameters.Add("@ttl", SqlDbType.Date).Value = dt.Rows[0]["Ttl"] ?? DBNull.Value;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 1000).Value = dt.Rows[0]["Alamat"] != DBNull.Value ? dt.Rows[0]["Alamat"] : "No Alamat";
                    cmd.ExecuteNonQuery(); 

                    dt.Clear();

                }
                catch (Exception)
                {

                    throw;
                }

            }
            else if (job == app_helper.update)
            {
                try
                {
                    appconfig.cmd = new SqlCommand();

                    var cmd = appconfig.cmd;
                    cmd.Connection = appconfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.spMenu2_1";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = app_helper.update;
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dt.Rows[0]["ID"];
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = dt.Rows[0]["Nama"] != DBNull.Value ? dt.Rows[0]["Nama"] : "No Name";
                    cmd.Parameters.Add("@ttl", SqlDbType.Date).Value = dt.Rows[0]["Ttl"] ?? DBNull.Value;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 1000).Value = dt.Rows[0]["Alamat"] != DBNull.Value ? dt.Rows[0]["Alamat"] : "No Alamat";
                    cmd.ExecuteNonQuery(); 

                    dt.Clear();

                }
                catch (Exception)
                {

                    throw;
                }

            }
            else if (job == app_helper.delete)
            {
                try
                {
                    appconfig.cmd = new SqlCommand();

                    var cmd = appconfig.cmd;
                    cmd.Connection = appconfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.spMenu2_1";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = app_helper.delete;
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dt.Rows[0]["ID"];
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = dt.Rows[0]["Nama"] != DBNull.Value ? dt.Rows[0]["Nama"] : "No Name";
                    cmd.Parameters.Add("@ttl", SqlDbType.Date).Value = dt.Rows[0]["Ttl"] ?? DBNull.Value ;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 1000).Value = dt.Rows[0]["Alamat"] != DBNull.Value ? dt.Rows[0]["Alamat"] : "No Alamat";
                    cmd.ExecuteNonQuery(); 

                    dt.Clear();

                }
                catch (Exception)
                {

                    throw;
                }

            }
          

            appconfig.closeConnection(); 
            
            return dt; 
        }
    }
  
}
