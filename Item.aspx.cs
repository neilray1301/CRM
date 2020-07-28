using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;

public partial class Item : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    BusinessLogicLayer bal = new BusinessLogicLayer();
    public enum MessageType { Success, Error, Info, Warning };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["no"] == null)
            {

                binditemgroup();

                binditemsubgroup();
                getmaxcomno();
                binduom();
            }
        }
        
    }

    public void binditemgroup()
    {
        try
        {
            DataTable dtdept = new DataTable();


            dtdept = bal.getallitemgroupfroadminBAL();
            if (dtdept.Rows.Count > 0)
            {
                ddlgroup.DataSource = dtdept;
                ddlgroup.DataTextField = "ItemGroup";
                ddlgroup.DataValueField = "id";
                ddlgroup.DataBind();


                dlgroupnamemp.DataSource = dtdept;
                dlgroupnamemp.DataTextField = "ItemGroup";
                dlgroupnamemp.DataValueField = "id";
                dlgroupnamemp.DataBind();

            }
            ddlgroup.Items.Insert(0, new ListItem("----Select ItemGroup----", "0"));
            dlgroupnamemp.Items.Insert(0, new ListItem("----Select ItemGroup----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void binditemsubgroup()
    {
        try
        {
            DataTable dtdept = new DataTable();


            dtdept = bal.getallItemsubgroupforadminBAL();
            if (dtdept.Rows.Count > 0)
            {
                ddlsubgroup.DataSource = dtdept;
                ddlsubgroup.DataTextField = "SubgroupName";
                ddlsubgroup.DataValueField = "id";
                ddlsubgroup.DataBind();
            }
            ddlsubgroup.Items.Insert(0, new ListItem("----Select Item SubGroup----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public string getmaxcomno()
    {
        string s = string.Empty, id = string.Empty;
        Getconnection c = new Getconnection();
        try
        {
            string s1 = "select Top (1) No from tbl_Item_NoSeries    order By  Id DESC";
            SqlCommand cmd11 = new SqlCommand(s1, c.getconnection());
            if (cmd11.ExecuteScalar() != null)
                id = cmd11.ExecuteScalar().ToString();
            c.CloseConnection();
            int fid = 0;
            if (id.Equals(""))
            {
                id = "1";
                fid = Convert.ToInt32(id);
            }
            else
            {
                fid = Convert.ToInt32(id);
                fid = fid + 1;
            }
            s = fid.ToString();
            lblcomno.Text = s.ToString();
            //hfMaxEntryNo.Value = fid.ToString();
            bal.tbl_Item_NoSeries_InsertBAL(s, "", "");
        }
        catch (Exception ex)
        {

            //txtinqno.Text = "1";
        }
        finally
        {
            c.CloseConnection();
        }
        return s;
    }

    public void binduom()
    {
        try
        {
            DataTable dtdept = new DataTable();


            dtdept = bal.getallunitofmeasurementfroadminBAL();
            if (dtdept.Rows.Count > 0)
            {
                ddluom.DataSource = dtdept;
                ddluom.DataTextField = "UnitofMeasurement";
                ddluom.DataValueField = "id";
                ddluom.DataBind();
            }
            ddluom.Items.Insert(0, new ListItem("----Select UOM----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }

    protected void lbtncreategroup_Click(object sender, EventArgs e)
    {


        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkitemgroupdata(txtgroupname.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Saveitemgroupbll(txtgroupname.Text, lblloginid.Text, localTime, "", "", "", "", "");
                binditemgroup();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtgroupname.Text = "";
                txtgroupname.Focus();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }

    protected void lbtnresetgroup_Click(object sender, EventArgs e)
    {

    }

    protected void lbtcreatesubgroup_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkItemsubgroupnameBAL(txtsubgroupnamemp.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.tbl_Itemsubgroup_Master_InsertBAL(txtsubgroupnamemp.Text, Convert.ToInt32(dlgroupnamemp.SelectedValue.ToString()), lblloginid.Text, localTime, "", "", "", "", "");
                binditemsubgroup();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtsubgroupnamemp.Text = "";
                dlgroupnamemp.ClearSelection();
                txtsubgroupnamemp.Focus();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }
    protected void lbtresetesubgroup_Click(object sender, EventArgs e)
    {

    }

    protected void lbtncreateuom_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkunitofmeasurementdata(txtuom.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Saveunitofmeasurementbll(txtuom.Text, lblloginid.Text, localTime, "", "", "", "", "");
                binduom();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtuom.Text = "";
                txtuom.Focus();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }

    protected void grditem_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Download")
        {
            Response.Clear();
            Response.ContentType = "application/octect-stream";
            Response.AppendHeader("Content-Disposition", "filename=" + e.CommandArgument);
            Response.TransmitFile(Server.MapPath("~/Documents/") + e.CommandArgument);
            ShowMessage("Attachment Sucessfully Downloaded !!!", MessageType.Success);
            Response.End();

        }
        else if (e.CommandName == "deletedata")
        {

            string result = bal.deletitemimgdatabyidBAL(e.CommandArgument.ToString());

            ShowMessage("Record Deleted!!!", MessageType.Success);

            bindimg();


        }
    }

    protected void grditembro_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Download")
        {
            Response.Clear();
            Response.ContentType = "application/octect-stream";
            Response.AppendHeader("Content-Disposition", "filename=" + e.CommandArgument);
            Response.TransmitFile(Server.MapPath("~/Documents/") + e.CommandArgument);
            ShowMessage("Attachment Sucessfully Downloaded !!!", MessageType.Success);
            Response.End();

        }
        else if (e.CommandName == "deletedata")
        {

            string result = bal.deletitemdocumentdatabyidBAL(e.CommandArgument.ToString());

            ShowMessage("Record Deleted!!!", MessageType.Success);

            binddocument();


        }

    }

    protected void btnitemimg_Click(object sender, EventArgs e)
    {
        try
        {


            if (fuItemPic.HasFile)
            {
                string fileName = Path.GetFileName(fuItemPic.FileName);
                fuItemPic.SaveAs(Server.MapPath("~/Documents/") + fileName);
                string filepath = "~/Documents/" + fileName;



                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                bal.tbl_ItemImage_Master_InsertBAL(lblcomno.Text, "", fileName, filepath, lblloginid.Text, localTime, "", "", "", "", "");

                bindimg();
                // txtdocument.Focus();
            }

        }
        catch (Exception ex)
        {

        }
    }

    public void binddocument()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getItemdocumentadataBAL(lblloginid.Text, Convert.ToInt32(lblcomno.Text));
            if (dtcontact.Rows.Count > 0)
            {
                grditembro.DataSource = dtcontact;
                grditembro.DataBind();
                grditembro.UseAccessibleHeader = true;
                grditembro.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grditembro.DataSource = dtcontact;
                grditembro.DataBind();
                grditembro.UseAccessibleHeader = true;
                grditembro.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void bindimg()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getItemimageadataBAL(lblloginid.Text, Convert.ToInt32(lblcomno.Text));
            if (dtcontact.Rows.Count > 0)
            {
                grditem.DataSource = dtcontact;
                grditem.DataBind();
                grditem.UseAccessibleHeader = true;
                grditem.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grditem.DataSource = dtcontact;
                grditem.DataBind();
                grditem.UseAccessibleHeader = true;
                grditem.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void btnadditembro_Click(object sender, EventArgs e)
    {
        try
        {


            if (fuBroucher.HasFile)
            {
                string fileName = Path.GetFileName(fuBroucher.FileName);
                fuItemPic.SaveAs(Server.MapPath("~/Documents/") + fileName);
                string filepath = "~/Documents/" + fileName;



                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.tbl_ItemDocument_Master_InsertBAL(lblcomno.Text, "", fileName, filepath, lblloginid.Text, localTime, "", "", "", "", "");
                binddocument();

                // txtdocument.Focus();
            }

        }
        catch (Exception ex)
        {

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkItemnameBAL(txtItemName.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                
                bal.tbl_Item_Master_InsertBAL(Convert.ToInt32(lblcomno.Text), Convert.ToInt32(ddlgroup.SelectedItem.Value), Convert.ToInt32(ddlsubgroup.SelectedItem.Value), txtModalNo.Text, txtItemName.Text, txtFinalName.Text, txtAlias.Text, txtitemcategoryno.Text, Convert.ToInt32(ddluom.SelectedItem.Value), Convert.ToDecimal(txtRate.Text), Convert.ToInt32(txtGST.Text), txtHSN.Text, txtDescp.Text, lblloginid.Text, Convert.ToDateTime(localTime), "", "", "", "", "");

                ShowMessage("Record Save!!!", MessageType.Success);
                Response.Redirect("ItemRegister.aspx", false);
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }

}