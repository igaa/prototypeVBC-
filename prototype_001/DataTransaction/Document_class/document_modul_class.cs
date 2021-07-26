using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppConfig;
using System.Data.SqlClient;


namespace DataTransaction.Document_class
{
   public class document_modul_class
    {
        public DataTable getContentTemplate( DataTable dt, string job)
        {
            DataTable dtNew = new DataTable();
            app_config appConfig = new app_config(); 
            appConfig.openConnection();

            var trans = appConfig.mycontrans;

            try
            {
                
                if (job == app_helper.show)
                {

                    appConfig.cmd = new SqlCommand();

                    var cmd = appConfig.cmd;
                    cmd.Connection = appConfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.SpGetTemplate";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = app_helper.show;
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = Guid.Empty;
                    cmd.Parameters.Add("@ID_TAG", SqlDbType.UniqueIdentifier).Value = Guid.Empty;

                    dt.Clear();

                    appConfig.DA = new SqlDataAdapter(cmd);

                    var da = appConfig.DA;

                    da.Fill(dt);
                    da.Dispose();
                }
                else if (job == app_helper.showByID)
                {

                    appConfig.cmd = new SqlCommand();

                    var cmd = appConfig.cmd;
                    cmd.Connection = appConfig.Conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.SpGetTemplate";
                    cmd.Transaction = trans;
                    cmd.Parameters.Add("@Job", SqlDbType.VarChar, 20).Value = app_helper.showByID;
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = dt.Rows[0]["ID"];
                    cmd.Parameters.Add("@ID_TAG", SqlDbType.UniqueIdentifier).Value = dt.Rows[0]["ID_TAG"];

                    dt.Clear();


                    dtNew.Clear(); 
                    appConfig.DA = new SqlDataAdapter(cmd);

                    var da = appConfig.DA;

                    da.Fill(dtNew);
                    da.Dispose();
                    appConfig.closeConnection();
                    return dtNew; 
                 
                }

            }
            catch (Exception)
            {

                throw;
            }


            appConfig.closeConnection();
            return dt;
        }
    }
}
