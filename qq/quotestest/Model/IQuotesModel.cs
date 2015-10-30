using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace quotestest.Model
{
   public  interface IQuotesModel
    {
        string UserID { get; set; }
        string PassWord { get; set; }
         string ConnectionString();
         DataTable GetAllClubMembers();
    }
}
