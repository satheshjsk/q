using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quotestest.View;
using quotestest.Model;
using System.Data;

namespace quotestest.Presenter
{
  public  class QuotesPresenter
    {
      IQuotesView objQuotesview;

      public QuotesPresenter(IQuotesView _iQuotesview)
      {

          objQuotesview = _iQuotesview;
      
      }

       #region IView Members

      public string getdetails()
      {
          string message;

          QuotesModel m = new QuotesModel();
          if ((objQuotesview.UserID == m.UserID) && (objQuotesview.PassWord == m.PassWord))
          {

             return message = "Valid";
          }
          else
          {
              return message = "InValid";
          }

         
      }
#endregion

      public DataTable getdbvalues()
      {
          DataTable dtmember = new DataTable();

          QuotesModel m = new QuotesModel();
          
          dtmember = m.GetAllClubMembers();
          return dtmember;
      }


    }
}
