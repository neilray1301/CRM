using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class OrderRegistry : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    BusinessLogicLayer bal = new BusinessLogicLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            bindDetail();

        }
    }
    protected void btncreate_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("OrderEntry.aspx", false);
        }
        catch (Exception ex)
        {

        }

    }
    public void bindDetail()
    {

        try
        {

            if (lblrole.Text.Equals("admin"))
            {
                dt = bal.getallOrderdataforadminBAL();
            }
            else
            {

                dt = bal.getallOrderdataBAL();
            }



            if (dt.Rows.Count > 0)
            {
                grddata.DataSource = dt;
                grddata.DataBind();
                grddata.UseAccessibleHeader = true;
                grddata.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grddata.DataSource = dt;
                grddata.DataBind();
                grddata.UseAccessibleHeader = true;
                grddata.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }
    protected void grddata_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string result;
            lblid.Text = e.CommandArgument.ToString();
            if (e.CommandName == "editdata")
            {
                Response.Redirect(String.Format("UpdateOrder.aspx?no={0}", lblid.Text), false);
            }
           
        }
        catch (Exception ex)
        {

        }
    }

}