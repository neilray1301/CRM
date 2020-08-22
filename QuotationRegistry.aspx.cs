using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QuotationRegistry : System.Web.UI.Page
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
            Response.Redirect("QuotationEntry.aspx", false);
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
                dt = bal.getallQuotationdataforadminBAL();
            }
            else
            {

                dt = bal.getallQuotationdataBAL();
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
                Response.Redirect(String.Format("UpdateQuotation.aspx?no={0}", lblid.Text), false);
            }
            else if(e.CommandName == "revisedata")
                {
                Response.Redirect(String.Format("RevisedQuotation.aspx?no={0}", lblid.Text), false);
            }
            else if (e.CommandName == "wondata")
            {
                Response.Redirect(String.Format("OrderEntry.aspx?quoteno={0}", lblid.Text), false);
            }
            else if(e.CommandName == "lossdata")
            {
                
                
                    Response.Redirect(String.Format("OrderRegistry  .aspx?no={0}", lblid.Text), false);
                
            }
        }
        catch (Exception ex)
        {

        }
    }
}