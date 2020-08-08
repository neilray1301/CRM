using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UpdateQuotation : System.Web.UI.Page
{
    BusinessLogicLayer bal = new BusinessLogicLayer();
    public enum MessageType { Success, Error, Info, Warning };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblcomno.Text = Request.QueryString["no"].ToString();

            string zoneId = "India Standard Time";
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzi);
            txtfdate.Text = now.ToString("dd/MM/yyyy");
            txtdate.Text = now.ToString("dd/MM/yyyy");
            //   lblloginid.Text = Session["no"].ToString();
            //    lblrole.Text = Session["role"].ToString();


            bindstatus();
            bindsource();
            bindfollowup();
            binditem();
            binduom();
            binddepartment();
            binddesignation();
            filldata();
            binditemdata();
            bindfollowupdata();
            //  getInquiryNo();
            //  getmaxcomno();
            bindcustomer();
            BindDetail();
            bincustcontact();
            btnUpdate.Visible = true;


        }
    }
    public void binditemdata()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getallquotationitemdatabal(lblcomno.Text);
            if (dtcontact.Rows.Count > 0)
            {
                grdproduct.DataSource = dtcontact;
                grdproduct.DataBind();
                grdproduct.UseAccessibleHeader = true;
                grdproduct.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grdproduct.DataSource = dtcontact;
                grdproduct.DataBind();
                grdproduct.UseAccessibleHeader = true;
                grdproduct.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }
    public void filldata()
    {
        try
        {
            DataTable dtdata = bal.getallQuotationdatabynoBAL(lblcomno.Text);
            if (dtdata.Rows.Count > 0)
            {
                txtno.Text = dtdata.Rows[0]["QuotationNo"].ToString();
                txtdate.Text = dtdata.Rows[0]["Quotationdate"].ToString();
                txtemail.Text = dtdata.Rows[0]["ContactEmail"].ToString();
                txtcontactno.Text = dtdata.Rows[0]["Custcontactno"].ToString();
                txtmobileno.Text = dtdata.Rows[0]["ContactMno1"].ToString();
                txtmobileno2.Text = dtdata.Rows[0]["ContactMno2"].ToString();
                // dpcustgroup.SelectedValue = dtdata.Rows[0]["Groupno"].ToString();



                dpcust.SelectedValue = dtdata.Rows[0]["Custnameid"].ToString();



                dpcontactper.SelectedValue = dtdata.Rows[0]["Custcontact"].ToString();
                dpsource.SelectedValue = dtdata.Rows[0]["InqiurySource"].ToString();
                dpstatus.SelectedValue = dtdata.Rows[0]["InqiuryStatus"].ToString();

                txtremarks.Text = dtdata.Rows[0]["Remarks"].ToString();
                ddlDept.SelectedValue = dtdata.Rows[0]["Dept"].ToString();
                ddldesign.SelectedValue = dtdata.Rows[0]["Design"].ToString();
                //txturl.Text = dtdata.Rows[0]["URL"].ToString();
                //rbtnstatus.SelectedItem.Text = dtdata.Rows[0]["Status"].ToString();
                //txtgstno.Text = dtdata.Rows[0]["GSTno"].ToString();
                //txtbankname.Text = dtdata.Rows[0]["Bankname"].ToString();
                //txtaccno.Text = dtdata.Rows[0]["Accountno"].ToString();
                //txtifsccode.Text = dtdata.Rows[0]["IFSCcode"].ToString();
                //txtcountry.Text = dtdata.Rows[0]["Country"].ToString();
               // bindcustomer();
                //  bincustcontact();
            }
        }
        catch (Exception ex)
        {

        }
    }

    public void bincustcontact()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getCustomerConatctPersonBAL(Convert.ToInt32(dpcust.SelectedValue.ToString()));
            if (dtbtype.Rows.Count > 0)
            {
                dpcontactper.DataSource = dtbtype;
                dpcontactper.DataTextField = "ContactName";
                dpcontactper.DataValueField = "Id";
                dpcontactper.DataBind();



            }
            dpcontactper.Items.Insert(0, new ListItem("----Select Contact----", "0"));
            //  dpfollowstatus.Items.Insert(0, new ListItem("----Select Status----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }

    }

    public void bindstatus()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallstatusfroadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpstatus.DataSource = dtbtype;
                dpstatus.DataTextField = "Status";
                dpstatus.DataValueField = "id";
                dpstatus.DataBind();


                dpfollowstatus.DataSource = dtbtype;
                dpfollowstatus.DataTextField = "Status";
                dpfollowstatus.DataValueField = "id";
                dpfollowstatus.DataBind();
            }
            dpstatus.Items.Insert(0, new ListItem("----Select Status----", "0"));
            dpfollowstatus.Items.Insert(0, new ListItem("----Select Status----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void bindcustomer()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallCustomerMasterataforadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpcust.DataSource = dtbtype;
                dpcust.DataTextField = "Name";
                dpcust.DataValueField = "id";
                dpcust.DataBind();



            }
            dpcust.Items.Insert(0, new ListItem("----Select Customer----", "0"));
            //dpfollowstatus.Items.Insert(0, new ListItem("----Select Status----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }




    public void bindsource()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallsourcefroadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpsource.DataSource = dtbtype;
                dpsource.DataTextField = "Source";
                dpsource.DataValueField = "id";
                dpsource.DataBind();
            }
            dpsource.Items.Insert(0, new ListItem("----Select Source----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void binduom()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallunitofmeasurementfroadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpuom.DataSource = dtbtype;
                dpuom.DataTextField = "UnitofMeasurement";
                dpuom.DataValueField = "id";
                dpuom.DataBind();
            }
            dpuom.Items.Insert(0, new ListItem("----Select UOM----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void binditem()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallItemdataforadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpitem.DataSource = dtbtype;
                dpitem.DataTextField = "Itemname";
                dpitem.DataValueField = "id";
                dpitem.DataBind();
            }
            dpitem.Items.Insert(0, new ListItem("----Select Item----", "0"));

        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    public void bindfollowup()
    {
        try
        {
            DataTable dtbtype = new DataTable();


            dtbtype = bal.getallfollowuptypefroadminBAL();
            if (dtbtype.Rows.Count > 0)
            {
                dpfollowuptype.DataSource = dtbtype;
                dpfollowuptype.DataTextField = "FollowUpType";
                dpfollowuptype.DataValueField = "id";
                dpfollowuptype.DataBind();
            }
            dpfollowuptype.Items.Insert(0, new ListItem("----Select Followup Type----", "0"));

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

    public void resetcontact()
    {
        try
        {

            //dp.ClearSelection();
            //ddldesign.ClearSelection();
            //txtdob.Text = "";
            //txtdoani.Text = "";
            //   dpprincipal.ClearSelection();
            dpitem.ClearSelection();
            dpuom.ClearSelection();
            //   dpsuppliers.ClearSelection();
            txtqty.Text = "";
            txtrate.Text = "";
            txtamount.Text = "";
            Txtdiscount.Text = "";
        }
        catch (Exception ex)
        {

        }
    }

    //public void binditemdata()
    //{

    //    try
    //    {

    //        DataTable dtcontact = new DataTable();
    //        dtcontact = bal.getquotationDetailsdataBAL(Convert.ToInt32(lblcomno.Text));
    //        if (dtcontact.Rows.Count > 0)
    //        {
    //            grdproduct.DataSource = dtcontact;
    //            grdproduct.DataBind();
    //            grdproduct.UseAccessibleHeader = true;
    //            grdproduct.HeaderRow.TableSection = TableRowSection.TableHeader;
    //        }
    //        else
    //        {
    //            grdproduct.DataSource = dtcontact;
    //            grdproduct.DataBind();
    //            grdproduct.UseAccessibleHeader = true;
    //            grdproduct.HeaderRow.TableSection = TableRowSection.TableHeader;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Getconnection.SiteErrorInsert(ex);
    //    }
    //}

    public void bindfollowupdata()
    {

        try
        {

            DataTable dtcontact = new DataTable();
            dtcontact = bal.getQUotationFollowupdataDAL(Convert.ToInt32(lblcomno.Text));
            if (dtcontact.Rows.Count > 0)
            {
                grdfollowup.DataSource = dtcontact;
                grdfollowup.DataBind();
                grdfollowup.UseAccessibleHeader = true;
                grdfollowup.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grdfollowup.DataSource = dtcontact;
                grdfollowup.DataBind();
                grdfollowup.UseAccessibleHeader = true;
                grdfollowup.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
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

    protected void grdproduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string result;
            lblid.Text = e.CommandArgument.ToString();
            if (e.CommandName == "editdata")
            {
                DataTable dtdata = bal.getQuotationDetailsdatabyidDAL(lblid.Text);
                if (dtdata.Rows.Count > 0)
                {
                    dpitem.SelectedValue = dtdata.Rows[0]["Item"].ToString();
                    //  dpsuppliers.SelectedValue = dtdata.Rows[0]["Supplier"].ToString();
                    //   dpprincipal.SelectedValue = dtdata.Rows[0]["Principal"].ToString();
                    dpuom.SelectedValue = dtdata.Rows[0]["UOM"].ToString();
                    txtqty.Text = dtdata.Rows[0]["Qty"].ToString();
                    txtrate.Text = dtdata.Rows[0]["Rate"].ToString();
                    txtamount.Text = dtdata.Rows[0]["Amount"].ToString();


                    dpitem.Focus();
                    btnaddproduct.Visible = false;
                    lbtnupdatecontact.Visible = true;
                    //  bindDetail();
                }
            }
            else if (e.CommandName == "deletedata")
            {

                result = bal.deletequotationdetailsdatabyidBAL(lblid.Text);

                ShowMessage("Record Deleted!!!", MessageType.Success);

                binditemdata();


            }

        }
        catch (Exception ex)
        {

        }
    }


    protected void grdfollowup_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string result;
            lblid.Text = e.CommandArgument.ToString();
            if (e.CommandName == "editdata")
            {
                DataTable dtdata = bal.getFollowupDetailsdatabyidBAL(lblid.Text);
                if (dtdata.Rows.Count > 0)
                {
                    dpfollowuptype.SelectedValue = dtdata.Rows[0]["Follotype"].ToString();
                    dpfollowstatus.SelectedValue = dtdata.Rows[0]["FolloStatus"].ToString();


                    txtfremarks.Text = dtdata.Rows[0]["Remarks"].ToString();
                    txtfdate.Text = dtdata.Rows[0]["NextFolldate"].ToString();



                    lbtnaddfollowup.Visible = false;
                    lbtnupdatefollowup.Visible = true;
                    //  bindDetail();
                }
            }
            else if (e.CommandName == "deletedata")
            {

                result = bal.deleteinquiryfollowupdatabyidBAL(lblid.Text);

                ShowMessage("Record Deleted!!!", MessageType.Success);

                bindfollowupdata();


            }

        }
        catch (Exception ex)
        {

        }
    }

    protected void btnaddproduct_Click(object sender, EventArgs e)
    {
        try
        {

            DataTable dt1 = new DataTable();
            dt1 = bal.checkQuotationProductNameBAL(lblcomno.Text, Convert.ToInt32(dpitem.SelectedValue));
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {

                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);
                //  txtrate.Text = "2000";
                bal.tbl_Quotation_Details_InsertBAL(Convert.ToInt32(lblcomno.Text), Convert.ToInt32(dpitem.SelectedValue.ToString()), Convert.ToInt32(dpuom.SelectedValue.ToString()), Convert.ToDecimal(txtqty.Text), Convert.ToDecimal(txtrate.Text), Convert.ToDecimal(txtamount.Text), lblloginid.Text, localTime, "", "", "", "", "");
                resetcontact();
                binditemdata();
                //txtcontactname.Focus();
            }
        }
        catch (Exception ex)
        {

        }

    }

    protected void lbtnupdatecontact_Click(object sender, EventArgs e)
    {
        try
        {


            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

            bal.tbl_Quotation_Details_updateBAL(Convert.ToInt32(lblid.Text), Convert.ToInt32(dpitem.SelectedValue.ToString()), Convert.ToInt32(dpuom.SelectedValue.ToString()), Convert.ToDecimal(txtqty.Text), Convert.ToDecimal(txtrate.Text), Convert.ToDecimal(txtamount.Text), lblloginid.Text, localTime, "", "", "", "", "");
            resetcontact();
            binditemdata();
            ShowMessage("Record Save!!!", MessageType.Success);


            btnaddproduct.Visible = true;
            lbtnupdatecontact.Visible = false;

        }
        catch (Exception ex)
        {

        }
    }

    protected void lbtnaddfollowup_Click(object sender, EventArgs e)
    {
        try
        {

            DataTable dt1 = new DataTable();
            dt1 = bal.checkQuotationFollowupBAL(lblcomno.Text, txtfdate.Text, Convert.ToInt32(dpfollowuptype.SelectedValue.ToString()));
            if (dt1.Rows.Count > 0)
            {
                ShowMessage("Name Already Exist!!!", MessageType.Error);
            }
            else
            {

                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

                bal.tbl_Quotation_Followup_InsertBAL(Convert.ToInt32(lblcomno.Text), txtfdate.Text, Convert.ToInt32(dpfollowuptype.SelectedValue.ToString()), 0, Convert.ToInt32(dpfollowstatus.SelectedValue.ToString()), txtfremarks.Text, "", "", lblloginid.Text, localTime, "", "", "", "", "");
                resetfollowup();
                bindfollowupdata();
                //txtcontactname.Focus();
            }
        }
        catch (Exception ex)
        {

        }

    }

    public void resetfollowup()
    {
        try
        {
            string zoneId = "India Standard Time";
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzi);
            txtfdate.Text = now.ToString("dd/MM/yyyy");


            dpfollowuptype.ClearSelection();


            dpfollowstatus.ClearSelection();

            txtfremarks.Text = "";

        }
        catch (Exception ex)
        {

        }
    }

    protected void lbtnupdatefollowup_Click(object sender, EventArgs e)
    {
        try
        {


            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);

            bal.tbl_Quotation_Followup_updateBAL(Convert.ToInt32(lblid.Text), Convert.ToInt32(lblcomno.Text), txtfdate.Text, Convert.ToInt32(dpfollowuptype.SelectedValue.ToString()), 0, Convert.ToInt32(dpfollowstatus.SelectedValue.ToString()), txtfremarks.Text, "", "", lblloginid.Text, localTime, "", "", "", "", "");
            resetfollowup();
            bindfollowupdata();
            ShowMessage("Record Save!!!", MessageType.Success);


            lbtnaddfollowup.Visible = true;
            lbtnupdatefollowup.Visible = false;

        }
        catch (Exception ex)
        {

        }
    }

    protected void lbtnresetfollowup_Click(object sender, EventArgs e)
    {

    }

    public void BindDetail()
    {

        try
        {
            DataTable dt = bal.getallquotatationtermsandconditionsfroadminBAL(Convert.ToInt32(txtno.Text));


            if (dt.Rows.Count > 0)
            {
                grddata1.DataSource = dt;
                grddata1.DataBind();
                grddata1.UseAccessibleHeader = true;
                grddata1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                grddata1.DataSource = dt;
                grddata1.DataBind();
                grddata1.UseAccessibleHeader = true;
                grddata1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void dpcust_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            bincustcontact();
        }
        catch (Exception ex)
        {
            Getconnection.SiteErrorInsert(ex);
        }
    }

    protected void dpitem_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dtdata = bal.getallitemBAL(Convert.ToInt32(dpitem.SelectedValue));
            if (dtdata.Rows.Count > 0)
            {
                txtrate.Text = dtdata.Rows[0]["Itemrate"].ToString();
                dpuom.SelectedValue = dtdata.Rows[0]["ItemUOM"].ToString();
                int uomvaluye = Convert.ToInt32(dpuom.SelectedValue.ToString());
                txtqty.Focus();

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


            //  string Groupid = bal.getCustomerGroupIdbynameDAL(dpcustgroup.SelectedItem.Text);
            string custid = bal.getCustomerIdbynameBAL(dpcust.SelectedItem.Text);


            DataTable dt1 = new DataTable();
            
            
            
                DateTime utcTime = DateTime.UtcNow;
                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tzi);


                bal.tbl_Quotation_Master_updateBAL( Convert.ToInt32(lblcomno.Text), Convert.ToInt32(custid), Convert.ToInt32(dpcontactper.SelectedValue.ToString()), txtcontactno.Text, Convert.ToInt32(ddlDept.SelectedValue.ToString()), Convert.ToInt32(ddldesign.SelectedValue.ToString()), txtemail.Text, txtmobileno.Text, txtmobileno2.Text, Convert.ToInt32(dpstatus.SelectedValue.ToString()), Convert.ToInt32(dpsource.SelectedValue.ToString()), txtremarks.Text, lblloginid.Text, localTime, "", "", "", "", "");
                 bal.deletequtationtermsandconditionsdata(Convert.ToInt32(txtno.Text));
                try
                {
                    foreach (GridViewRow row in grddata1.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {

                            CheckBox chkrow = (row.Cells[0].FindControl("btnchkbox") as CheckBox);

                            int id = Convert.ToInt32(((Label)row.FindControl("lblid")).Text);
                            string title = ((Label)row.FindControl("lblname")).Text;
                            string descp = ((Label)row.FindControl("lbltandc")).Text;
                            if (chkrow.Checked)
                            {
                                bal.tbl_Quotation_tandc_InsertBAL(Convert.ToInt32(txtno.Text), id, title, descp, "True", lblloginid.Text, localTime, "", "", "", "", "");
                            }
                            else
                            {
                                bal.tbl_Quotation_tandc_InsertBAL(Convert.ToInt32(txtno.Text), id, title, descp, "False", lblloginid.Text, localTime, "", "", "", "", "");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }



                Response.Redirect("QuotationRegistry.aspx", false);
            

        }
        catch (Exception ex)
        {

        }


    }

    

   

    protected void grddata1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CheckBox chk = (CheckBox)e.Row.FindControl("btnchkbox");
            Label lblSatatus = (Label)e.Row.FindControl("lblstatus");

            if (lblSatatus.Text.ToString() == "True")
            {
                chk.Checked = true;
            }
            else
            {
                chk.Checked = false;
            }

        }
    }
}