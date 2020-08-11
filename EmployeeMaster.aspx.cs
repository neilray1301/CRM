using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class EmployeeMaster : System.Web.UI.Page
{
    BusinessLogicLayer bal = new BusinessLogicLayer();
    public enum MessageType { Success, Error, Info, Warning };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Session["no"] == null)
            //{
            //    Response.Redirect("Default.aspx", false);
            //}
            //else
            //{
            //    lblloginid.Text = Session["no"].ToString();
            //    lblrole.Text = Session["role"].ToString();
                getmaxcomno();
                bindrole();
                binddepartment();
                binddesignation();
                txtName.Focus();
         //   }
        }

    }

    public void bindrole()
    {
        try
        {
            DataTable dtdept = new DataTable();


            dtdept = bal.getallrolefroadminBAL();
            if (dtdept.Rows.Count > 0)
            {
                ddlRole.DataSource = dtdept;
                ddlRole.DataTextField = "Role";
                ddlRole.DataValueField = "Id";
                ddlRole.DataBind();
            }
            ddlRole.Items.Insert(0, new ListItem("----Select Role----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }
    public void binddepartment()
    {
        try
        {
            DataTable dtdept = new DataTable();


            dtdept = bal.getalldepartmentfroadminBAL();
            if (dtdept.Rows.Count > 0)
            {
                ddlDept.DataSource = dtdept;
                ddlDept.DataTextField = "Department";
                ddlDept.DataValueField = "Id";
                ddlDept.DataBind();
            }
            ddlDept.Items.Insert(0, new ListItem("----Select Department----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }
    public void binddesignation()
    {
        try
        {
            DataTable dtdesign = new DataTable();


            dtdesign = bal.getalldesignationfroadminBAL();
            if (dtdesign.Rows.Count > 0)
            {
                ddldesignation.DataSource = dtdesign;
                ddldesignation.DataTextField = "Designation";
                ddldesignation.DataValueField = "Id";
                ddldesignation.DataBind();
            }
            ddldesignation.Items.Insert(0, new ListItem("----Select Designation----", "0"));
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
            string s1 = "select Top (1) No from tbl_Employee_NoSeries    order By  Id DESC";
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
            bal.tbl_Employee_NoSeries_InsertBAL(s, "", "");
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

    protected void grddocument_RowCommand(object sender, GridViewCommandEventArgs e)
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

            string result = bal.deleteemployeedocumentdatabyidBAL(e.CommandArgument.ToString());

            ShowMessage("Record Deleted!!!", MessageType.Success);

            binddocument();


        }
    }
    protected void lbtnadddocument_Click(object sender, EventArgs e)
    {
        try
        {


            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/Documents/") + fileName);
                string filepath = "~/Documents/" + fileName;



                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                bal.tbl_Employee_Document_Master_InsertBAL(lblcomno.Text, txtdocument.Text, fileName, filepath, lblloginid.Text, localTime, "", "", "", "", "");
                txtdocument.Text = "";
                binddocument();
                txtdocument.Focus();
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

    public void binddocument()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getdocumentadataBAL(lblloginid.Text, Convert.ToInt32(lblcomno.Text));
            if (dtcontact.Rows.Count > 0)
            {
                grddocument.DataSource = dtcontact;
                grddocument.DataBind();
                grddocument.UseAccessibleHeader = true;
                grddocument.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grddocument.DataSource = dtcontact;
                grddocument.DataBind();
                grddocument.UseAccessibleHeader = true;
                grddocument.HeaderRow.TableSection = TableRowSection.TableHeader;
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

            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);


            bal.tbl_Employee_master_InsertBAL(lblcomno.Text, txtName.Text, txtfhname.Text, txtsurname.Text, ddlgen.SelectedValue.ToString(), txtpaddress.Text, txtperaddress.Text, txtcity.Text, txtstate.Text, txtdistrict.Text, txtcountry.Text, txtpincode.Text, txtphno.Text, txtpmobileno.Text, txtmobileoffice.Text, txtmobilenowhatsup.Text, ddlRole.SelectedValue.ToString(), txtpfno.Text, txtdoa.Text, txtdoj.Text, txtdol.Text, Convert.ToInt32(ddlDept.SelectedValue.ToString()), Convert.ToInt32(ddldesignation.SelectedValue.ToString()), txtEmail.Text, txtPwd.Text, txtecontatname.Text, txtecontactno.Text, txtcontactrelation.Text, rdbStatus.SelectedItem.Text, txtbankname.Text, txtaccno.Text, txtifsccode.Text, lblloginid.Text, localTime, txtdob.Text, txtdoani.Text, "", "", "");

            Response.Redirect("EmployeeRegister.aspx", false);
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbtncrole_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkroledata(txtrolename.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Saverolebll(txtrolename.Text, lblloginid.Text, localTime, "", "", "", "", "");
                bindrole();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtrolename.Text = "";
                txtrolename.Focus();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }
    protected void lbtncreatedept_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkdepartmentdata(txtdeptname.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
                mpdept.Show();
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Savedepartmentbll(txtdeptname.Text, lblloginid.Text, localTime, "", "", "", "", "");
                binddepartment();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtdeptname.Text = "";
                txtdeptname.Focus();
                mpdept.Hide();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }
    protected void lbtndesigncreate_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkdesignationdata(txtdesign.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
                mpdesign.Show();
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Savedesignationbll(txtdesign.Text, lblloginid.Text, localTime, "", "", "", "", "");
                binddesignation();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtdesign.Text = "";
                txtdesign.Focus();
                mpdesign.Hide();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }
}