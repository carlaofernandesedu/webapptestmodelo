using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace webapp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var totalrows = ((DataTable)Application["dtRegistros"]).Rows.Count;
            var datahora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lbldatahora.Text = "hora:" + datahora;
            lblregistros.Text = "registros:" + totalrows.ToString();
        }
    }
}