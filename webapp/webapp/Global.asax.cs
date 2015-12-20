using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Security;
using System.Web.SessionState;

namespace webapp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("campo1");
            dt.Columns.Add("campo2");
            dt.Columns.Add("campo3");
            
            for (int i = 0; i < 40; i++)
            {
                var row = dt.NewRow();
                row["campo1"] = "campo" + i.ToString();
                row["campo2"] = "campo" + i.ToString();
                row["campo3"] = "campo" + i.ToString();
                dt.Rows.Add(row);
            }
            Application["dtRegistros"] = dt;
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}