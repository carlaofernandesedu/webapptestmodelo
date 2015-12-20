using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblresultado.Text = String.Empty;
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var valor = rnd.Next(0, 7);
            Thread.Sleep(valor * 1000);
            DataTable dt = (DataTable)Application["dtRegistros"];
            var row = dt.NewRow();
            row["campo1"] = txtcampo1.Text;
            row["campo2"] = txtcampo2.Text;
            row["campo3"] = txtcampo3.Text;
            dt.Rows.Add(row);
            Application ["dtRegistros"] = dt;
            lblresultado.Text = "registro salvo";
        }
    }
}