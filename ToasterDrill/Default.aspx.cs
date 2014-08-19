using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToasterDrill
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ToastClassesDataContext db = new ToastClassesDataContext();
            Toaster t = new Toaster { SalesPerson = "new toaster" };
            db.Toasters.InsertOnSubmit(t);
            db.SubmitChanges();
            GridView1.DataBind();
           
        }


    }
}