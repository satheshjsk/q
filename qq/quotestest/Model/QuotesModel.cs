using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quotestest.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace quotestest.Model
{
    public class QuotesModel :IQuotesModel
    {
         #region IModel Members

        public string UserID
        {
            get
            {
                return "Admin" ;
            }

            set
            {
            this.UserID=value;
            }
           
        }
        public string PassWord
        {
            get
            {
                return "Admin";
            }

            set
            {
            this.PassWord=value;
            }
           
        }

        #endregion

        public string ConnectionString()
        {
            
            
                return ConfigurationManager
                    .ConnectionStrings["quotessdfconn"]
                    .ToString();
            
        }

        public DataTable GetAllClubMembers()
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter oleDbDataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new SqlCommand();
                oleDbDataAdapter.SelectCommand.Connection = new SqlConnection(ConnectionString());
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = "select * from TBL_ITEM";

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
        
    }
    
}
