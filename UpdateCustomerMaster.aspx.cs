﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class UpdateCustomerMaster : System.Web.UI.Page
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
                lblcomno.Text = Request.QueryString["no"].ToString();
          //      lblrole.Text = Session["role"].ToString();
             //   bindcustgroup();
                bindbusstype();
                bindIndustry();
                binddepartment();
                binddesignation();
                filldata();
                bindcontactdata();
                txtName.Focus();

          //  }
        }
    }
    public void filldata()
    {
        try
        {
            DataTable dtdata = bal.getallCustomerdatabynoBAL(lblcomno.Text);
            if (dtdata.Rows.Count > 0)
            {
              //  dpcustgroup.SelectedValue = dtdata.Rows[0]["GroupNo"].ToString();
                txtName.Text = dtdata.Rows[0]["Name"].ToString();
                txtaddress.Text = dtdata.Rows[0]["Address"].ToString();
                txtcity.Text = dtdata.Rows[0]["City"].ToString();
                txtstate.Text = dtdata.Rows[0]["State"].ToString();
                txtdistrict.Text = dtdata.Rows[0]["District"].ToString();
                txtcountry.Text = dtdata.Rows[0]["Country"].ToString();
                txtpincode.Text = dtdata.Rows[0]["Pincode"].ToString();
                txtphno.Text = dtdata.Rows[0]["PhoneNo"].ToString();
                txtemail.Text = dtdata.Rows[0]["Email"].ToString();
                dpbusstype.SelectedValue = dtdata.Rows[0]["BussinessType"].ToString();
                dpindustry.SelectedValue = dtdata.Rows[0]["Industrygroup"].ToString();
                txturl.Text = dtdata.Rows[0]["URL"].ToString();
                rbtnstatus.SelectedItem.Text = dtdata.Rows[0]["Status"].ToString();
                txtgstno.Text = dtdata.Rows[0]["GSTno"].ToString();
                txtbankname.Text = dtdata.Rows[0]["Bankname"].ToString();
                txtaccno.Text = dtdata.Rows[0]["Accountno"].ToString();
                txtifsccode.Text = dtdata.Rows[0]["IFSCcode"].ToString();
                btndelete.Visible = true;

            }
        }
        catch (Exception ex)
        {

        }
    }
    // public void bindcustgroup()
    //{
    //    try
    //    {
    //        DataTable dtbtype = new DataTable();


    //        dtbtype = bal.getCustomerGroupNameBAL(lblloginid.Text);
    //        if (dtbtype.Rows.Count > 0)
    //        {
    //            dpcustgroup.DataSource = dtbtype;
    //            dpcustgroup.DataTextField = "Name";
    //            dpcustgroup.DataValueField = "Groupno";
    //            dpcustgroup.DataBind();
    //        }
    //        dpcustgroup.Items.Insert(0, new ListItem("----Select Group----", "0"));

    //    }
    //    catch (Exception ex)
    //    {
    //        Getconnection.SiteErrorInsert(ex);
    //    }
    //}

    public string getmaxcomno()
    {
        string s = string.Empty, id = string.Empty;
        Getconnection c = new Getconnection();
        try
        {
            string s1 = "select Top (1) No from tbl_Customer_Noseries    order By  Id DESC";
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
            bal.tbl_Customer_Noseries_InsertBAL(s, "", "");
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
    public void bindbusstype()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallbusinesstypefroadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpbusstype.DataSource = dtbtype;
                dpbusstype.DataTextField = "BusinessTypeName";
                dpbusstype.DataValueField = "id";
                dpbusstype.DataBind();
            }
            dpbusstype.Items.Insert(0, new ListItem("----Select BussinessType----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }
    public void bindIndustry()
    {
        try
        {
            DataTable dtindustry = new DataTable();


            dtindustry = bal.getallIndustrygroupfroadminBAL();
            if (dtindustry.Rows.Count > 0)
            {
                dpindustry.DataSource = dtindustry;
                dpindustry.DataTextField = "IndustryName";
                dpindustry.DataValueField = "id";
                dpindustry.DataBind();
            }
            dpindustry.Items.Insert(0, new ListItem("----Select Industrytype----", "0"));

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
                ddlDept.DataValueField = "id";
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
                ddldesign.DataSource = dtdesign;
                ddldesign.DataTextField = "Designation";
                ddldesign.DataValueField = "id";
                ddldesign.DataBind();
            }
            ddldesign.Items.Insert(0, new ListItem("----Select Designation----", "0"));
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void lbtnaddcontact_Click(object sender, EventArgs e)
    {
        try
        {

            DataTable dt1 = new DataTable();
            dt1 = bal.checkcustomercontactnameBAL(lblcomno.Text, txtcontactname.Text, txtcontactemail.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {

                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                bal.tbl_Customer_Contact_Master_InsertBAL(lblcomno.Text, txtcontactname.Text, txtcontactemail.Text, txtcontactphno.Text, txtcontactmno1.Text, txtcontactmno2.Text, Convert.ToInt32(ddlDept.SelectedValue.ToString()), Convert.ToInt32(ddldesign.SelectedValue.ToString()), lblloginid.Text, localTime, txtdob.Text, txtdoani.Text, "", "", "");
                resetcontact();
                bindcontactdata();
                txtcontactname.Focus();
            }
        }
        catch (Exception ex)
        {

        }

    }

    public void resetcontact()
    {
        try
        {
            txtcontactname.Text = "";
            txtcontactemail.Text = "";
            txtcontactphno.Text = "";
            txtcontactmno1.Text = "";
            txtcontactmno2.Text = "";
            txtdob.Text = "";
            txtdoani.Text = "";
            ddlDept.ClearSelection();
            ddldesign.ClearSelection();
        }
        catch (Exception ex)
        {

        }
    }

    protected void grdcontact_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string result;
            lblid.Text = e.CommandArgument.ToString();
            if (e.CommandName == "editdata")
            {
                DataTable dtdata = bal.getCustomercontactdatabyidBAL(lblid.Text);
                if (dtdata.Rows.Count > 0)
                {
                    txtcontactname.Text = dtdata.Rows[0]["ContactName"].ToString();
                    txtcontactemail.Text = dtdata.Rows[0]["ContactEmail"].ToString();
                    txtcontactphno.Text = dtdata.Rows[0]["ContactPhone"].ToString();
                    txtcontactmno1.Text = dtdata.Rows[0]["ContactMobileno1"].ToString();
                    txtcontactmno2.Text = dtdata.Rows[0]["ContactMobileno2"].ToString();
                    ddlDept.SelectedValue = dtdata.Rows[0]["Dept"].ToString();
                    ddldesign.SelectedValue = dtdata.Rows[0]["Design"].ToString();
                    txtdob.Text = dtdata.Rows[0]["Extra1"].ToString();
                    txtdoani.Text = dtdata.Rows[0]["Extra2"].ToString();
                    txtcontactname.Focus();
                    lbtnaddcontact.Visible = false;
                    lbtnupdatecontact.Visible = true;
                    //  bindDetail();
                }
            }
            else if (e.CommandName == "deletedata")
            {

                result = bal.deleteCustomercontactdatabyidBAL(lblid.Text);

                ShowMessage("Record Deleted!!!", MessageType.Success);

                bindcontactdata();
                lbtnaddcontact.Visible = true;
                lbtnupdatecontact.Visible = false;

            }

        }
        catch (Exception ex)
        {

        }
    }

    public void bindcontactdata()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getCustomercontactdataBAL(Convert.ToInt32(lblcomno.Text));
            if (dtcontact.Rows.Count > 0)
            {
                grdcontact.DataSource = dtcontact;
                grdcontact.DataBind();
                grdcontact.UseAccessibleHeader = true;
                grdcontact.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grdcontact.DataSource = dtcontact;
                grdcontact.DataBind();
                grdcontact.UseAccessibleHeader = true;
                grdcontact.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void lbtnupdatecontact_Click(object sender, EventArgs e)
    {
        try
        {


            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

            bal.tbl_Customer_Contact_Master_updateBAL(Convert.ToInt32(lblid.Text), txtcontactname.Text, txtcontactemail.Text, txtcontactphno.Text, txtcontactmno1.Text, txtcontactmno2.Text, Convert.ToInt32(ddlDept.SelectedValue.ToString()), Convert.ToInt32(ddldesign.SelectedValue.ToString()), lblloginid.Text, localTime, txtdob.Text, txtdoani.Text, "", "", "");
            resetcontact();
            bindcontactdata();
            ShowMessage("Record Save!!!", MessageType.Success);

            txtcontactname.Focus();
            lbtnaddcontact.Visible = true;
            lbtnupdatecontact.Visible = false;

        }
        catch (Exception ex)
        {

        }
    }

    protected void ShowMessage(string Message, MessageType type)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }




    protected void lbtnresetcontact_Click(object sender, EventArgs e)
    {
        try
        {
            resetcontact();
        }
        catch (Exception ex)
        {

        }

    }



    protected void btnupdate_Click(object sender, EventArgs e)
    {

        try
        {

            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);


            bal.tbl_Customer_Master_updateBAL(lblcomno.Text, "", txtName.Text, "", txtaddress.Text, txtcity.Text, txtstate.Text, txtdistrict.Text, txtcountry.Text, txtpincode.Text, txtphno.Text, txtemail.Text, Convert.ToInt32(dpbusstype.SelectedValue.ToString()), Convert.ToInt32(dpindustry.SelectedValue.ToString()), txturl.Text, rbtnstatus.SelectedItem.Text, txtgstno.Text, txtbankname.Text, txtaccno.Text, txtifsccode.Text, lblloginid.Text, localTime, "", "", "", "", "");

            Response.Redirect("CustomerRegister.aspx", false);
        }
        catch (Exception ex)
        {

        }


    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            bal.deleteCustomerdatabynoBAL(lblcomno.Text);
            Response.Redirect("CustomerRegister.aspx", false);
        }
        catch (Exception ex)
        {

        }

    }

    protected void btncancel_Click(object sender, EventArgs e)
    {

        try
        {
            Response.Redirect("CustomerRegister.aspx", false);
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbtncbytype_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkbusinesstypedata(txtbtypename.Text);
            if (dt1.Rows.Count > 0)
            {
                mpbtype.Show();

                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.Savebusinesstypebll(txtbtypename.Text, lblloginid.Text, localTime, "", "", "", "", "");

                bindbusstype();
                txtbtypename.Text = "";
                txtbtypename.Focus();
                mpbtype.Hide();
            }
        }
        catch (Exception ex)
        {
            //  Getconnection.SiteErrorInsert(ex);
            ShowMessage(ex.ToString(), MessageType.Error);
        }
    }

    protected void lbtncreateindugroup_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = new DataTable();
            dt1 = bal.checkdata(txtgroupname.Text);
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
                mpindutype.Show();
            }
            else
            {
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.SaveMyTablebll(txtgroupname.Text, lblloginid.Text, localTime, "", "", "", "", "");
                bindIndustry();
                ShowMessage("Record Save!!!", MessageType.Success);
                txtgroupname.Text = "";
                txtgroupname.Focus();
                mpindutype.Hide();
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