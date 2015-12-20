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
    public partial class search : System.Web.UI.Page
    {

        private DataTable _tabela ;
        protected void Page_Load(object sender, EventArgs e)
        {
            _tabela = (DataTable)Application["dtRegistros"];
            if (!Page.IsPostBack)
            {
            //    Random rnd = new Random();
            //    var valor = rnd.Next(0, 7);
            //    Thread.Sleep(valor * 1000);
                SearchTable(ref tbresultado, _tabela);
            }
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            var tbResult = _tabela.Clone();

            if (txtcampo1.Text == "erro")
                throw new Exception("Erro na aplicação search parametro" + txtcampo1.Text);

            if (txtcampo1.Text == "lentidao")
                Thread.Sleep(5000);

            var rows = _tabela.Select("campo1 like '%" + txtcampo1.Text + "%'");
            if (rows!=null)
            {
                foreach(var item in rows.ToList<DataRow>())
                {
                    var newrow = tbResult.NewRow();
                    newrow[0] = item[0];
                    newrow[1] = item[1];
                    newrow[2] = item[2];
                    tbResult.Rows.Add(newrow);
                }
            }
            
            SearchTable(ref tbresultado, tbResult);
        }

       

        private void SearchTable(ref Table table, DataTable dt)
        {
            TableRow row = null;

            //Add the Headers
            row = new TableRow();
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                TableHeaderCell headerCell = new TableHeaderCell();
                headerCell.Text = dt.Columns[j].ColumnName;
                row.Cells.Add(headerCell);
            }
            table.Rows.Add(row);

            //Add the Column values
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = new TableRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = dt.Rows[i][j].ToString();
                    row.Cells.Add(cell);
                }
                // Add the TableRow to the Table
                table.Rows.Add(row);
            }
            // Add the the Table in the Form
            table.DataBind();
        }
    }
}