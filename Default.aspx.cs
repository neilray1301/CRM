using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    BusinessLogicLayer bll = new BusinessLogicLayer();
    public enum MessageType { Success, Error, Info, Warning };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindDetail();
        }
    }
    public void bindDetail()
    {

        try
        {
            dt = bll.getallIndustrygroupfroadminBAL();


            if(dt.Rows.Count > 0)
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
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bll.checkdata(txtName.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bll.SaveMyTablebll(txtName.Text, "", localTime, "", "", "", "", "");

                bindDetail();
                txtName.Text = "";

                txtName.Focus();
            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }
    protected void grddata_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
       {
         string result;
           lblid.Text = e.CommandArgument.ToString();
           if (e.CommandName == "editdata")
           {
               DataTable dtdata = bll.getIndustrygroupdatabyidBAL(lblid.Text);
               if (dtdata.Rows.Count > 0)
               {
                   txtName.Text = dtdata.Rows[0]["IndustryName"].ToString();                       
                   txtName.Focus();
                   btnSave.Visible = false;
                   btnUpdate.Visible = true;

                }
           }
            else if (e.CommandName == "deletedata")
           {

              result = bll.deletedata(lblid.Text);

                 ShowMessage("Record Deleted!!!", MessageType.Success);

             bindDetail();

               btnSave.Visible = true;
              btnUpdate.Visible = false;
           }



       }
       catch (Exception ex)
      {

       }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
          bll.tbl_update(lblid.Text, txtName.Text);
          bindDetail();
          txtName.Text = "";  
          txtName.Focus();
          btnSave.Visible = true;
          btnUpdate.Visible = false;
        }
        catch (Exception ex)
        {
       }
    }

   
}