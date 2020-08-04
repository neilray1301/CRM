<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.master" AutoEventWireup="true" CodeFile="QuotationEntry.aspx.cs" Inherits="QuotationEntry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="../../bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="../../dist/css/AdminLTE.min.css">
    <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="../../dist/css/skins/_all-skins.min.css">

    <script type="text/javascript">
        function tSpeedValue(txt) {



            var qty = txtqty.value;
            var rate = txtrate.value;
            var amount = qty * rate;
            txtamount.value = amount;



        }
    </script>


    <style>
        .example-modal .modal {
            position: relative;
            top: auto;
            bottom: auto;
            right: auto;
            left: auto;
            text-align: left;
            display: block;
            z-index: 1;
        }

        .example-modal .modal {
            background: transparent !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Quotation Entry</h1>
            <ol class="breadcrumb">
                <li><a href="Default.aspx"><i class="fa fa-dashboard"></i>Home</a></li>
                <li><a href="Demo.master">Quotation</a></li>
                <li class="active">Quotation Entry</li>
                <asp:Label ID="lblcomno" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblid" runat="server" Visible="false" Text=""></asp:Label>
                <asp:Label ID="lblloginid" runat="server" Visible="false" Text=""></asp:Label>
                <asp:Label ID="lblrole" runat="server" Visible="false" Text=""></asp:Label>
            </ol>
        </section>

        <section class="content">
            <!-- SELECT2 EXAMPLE -->
            <div class="box box-primary">

                <!-- /.box-header -->
                <div class="box-body">

                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                No:<span class="required">* </span>
                            </label>
                            <asp:TextBox ID="txtno" class="form-control" TabIndex="1" ReadOnly="true" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtno"
                                Display="Dynamic" ErrorMessage="Please Enter Name" Text="(*) Required" ValidationGroup="Emst" SetFocusOnError="true" ForeColor="Red"
                                CssClass="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                Date:
                            </label>
                            <asp:TextBox ID="txtdate" class="form-control" TabIndex="2" runat="server"></asp:TextBox>
                            <asp:CalendarExtender ID="CalendarExtender3" TargetControlID="txtdate" Format="dd/MM/yyyy" runat="server"></asp:CalendarExtender>
                        </div>
                    </div>


                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label>Name of Customer <span class="required">* </span></label>


                            <div class="input-group">
                                <asp:DropDownList ID="dpcust" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dpcust_SelectedIndexChanged" data-placeholder="Select Customer" CssClass="form-control select2" TabIndex="3"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <asp:LinkButton ID="lbtncindugrp" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                            </div>


                        </div>
                        <div class="col-md-6 form-group">
                            <label>Status <span class="required">* </span></label>


                            <div class="input-group">
                                <asp:DropDownList ID="dpstatus" runat="server" AutoPostBack="false" data-placeholder="Select Customer" CssClass="form-control select2" TabIndex="4"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                            </div>


                        </div>
                    </div>



                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label>Contact Person<span class="required">* </span></label>


                            <div class="input-group">
                                <asp:DropDownList ID="dpcontactper" runat="server" AutoPostBack="true" data-placeholder="Select Contact Person" CssClass="form-control select2" TabIndex="5"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                            </div>


                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                Contact no
                            </label>
                            <asp:TextBox ID="txtcontactno" class="form-control" TabIndex="6" runat="server"></asp:TextBox>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label>Department<span class="required"> </span></label>


                            <asp:DropDownList ID="ddlDept" runat="server" AutoPostBack="false" Enabled="true" data-placeholder="Select Department" CssClass="form-control select2" TabIndex="23"></asp:DropDownList>


                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                Designation
                            </label>
                            <asp:DropDownList ID="ddldesign" runat="server" AutoPostBack="false" Enabled="true" data-placeholder="Select Designation" CssClass="form-control select2" TabIndex="24"></asp:DropDownList>

                        </div>
                    </div>
                    <div class="row">

                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                Email Id
                            </label>
                            <asp:TextBox ID="txtemail" class="form-control" TabIndex="7" runat="server"></asp:TextBox>

                        </div>
                        <div class="col-md-6 form-group">
                            <label>Source<span class="required">* </span></label>


                            <div class="input-group">
                                <asp:DropDownList ID="dpsource" runat="server" AutoPostBack="false" data-placeholder="Select Source" CssClass="form-control select2" TabIndex="8"></asp:DropDownList>
                                <span class="input-group-btn">
                                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                            </div>


                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                MobileNo:<span class="required">* </span>
                            </label>
                            <asp:TextBox ID="txtmobileno" class="form-control" TabIndex="9" runat="server"></asp:TextBox>
                            <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtaddress"
                                Display="Dynamic" ErrorMessage="Please Enter Name" Text="(*) Required" ValidationGroup="Emst" SetFocusOnError="true" ForeColor="Red"
                                CssClass="validate"></asp:RequiredFieldValidator>--%>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label">
                                MobileNo(2)
                            </label>
                            <asp:TextBox ID="txtmobileno2" class="form-control" TabIndex="10" runat="server"></asp:TextBox>

                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12 form-group">
                            <label class="control-label">
                                Remarks
                            </label>
                            <asp:TextBox ID="txtremarks" class="form-control" TabIndex="10" TextMode="MultiLine" runat="server"></asp:TextBox>

                        </div>
                    </div>
                </div>
                <div class="box-body">
                    <div class="box box-primary">
                        <div class="row">

                            <div class="col-md-3 form-group">
                                <label>Select Product <span class="required">* </span></label>


                                <div class="input-group">
                                    <asp:DropDownList ID="dpitem" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dpitem_SelectedIndexChanged" data-placeholder="Select Product" CssClass="form-control select2" TabIndex="4"></asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                                </div>
                            </div>
                            <div class="col-md-2 form-group">
                                <label>UOM <span class="required">* </span></label>


                                <div class="input-group">
                                    <asp:DropDownList ID="dpuom" runat="server" AutoPostBack="true" data-placeholder="Select UOM" CssClass="form-control select2" TabIndex="4"></asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:LinkButton ID="LinkButton12" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                                </div>
                            </div>
                            <div class="col-md-1 form-group">
                                <label class="control-label">
                                    Qty:
                                </label>
                                <asp:TextBox ID="txtqty" ClientIDMode="Static" onkeyup="tSpeedValue(this)" class="form-control" TabIndex="2" runat="server"></asp:TextBox>

                            </div>
                            <div class="col-md-1 form-group">
                                <label class="control-label">
                                    Rate:
                                </label>
                                <asp:TextBox ID="txtrate" ReadOnly="true" ClientIDMode="Static" class="form-control" TabIndex="2" runat="server"></asp:TextBox>

                            </div>
                            <div class="col-md-2 form-group">
                                <label class="control-label">
                                    Amount:
                                </label>
                                <asp:TextBox ID="txtamount" ClientIDMode="Static" class="form-control" TabIndex="2" runat="server"></asp:TextBox>

                            </div>


                            <div class="col-md-2 form-group" style="margin-top: 25px; text-align: left">

                                <asp:LinkButton ID="btnaddproduct" runat="server" TabIndex="35" OnClick="btnaddproduct_Click" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Add Product</asp:LinkButton>
                                <asp:LinkButton ID="lbtnupdatecontact" Visible="false" runat="server" OnClick="lbtnupdatecontact_Click" TabIndex="28" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Update</asp:LinkButton>
                                <asp:LinkButton ID="lbtnresetcontact" runat="server" TabIndex="29" CssClass="btn btn-bitbucket bg-gray btn-flat" CausesValidation="false"><i class="fa fa-times"></i>&nbsp;Reset</asp:LinkButton>
                                </div></div>
                                <div class="row">

                                    <div class="box-body">
                                        <asp:GridView ID="grdproduct" runat="server" AlternatingRowStyle-BackColor="#C2D69B" AllowPaging="false" AllowSorting="false"
                                            AutoGenerateColumns="False" BorderWidth="1px" OnRowCommand="grdproduct_RowCommand" ShowHeaderWhenEmpty="true"
                                            CssClass="table table-striped table-bordered table-hover dataTable no-footer" CellPadding="2"
                                            CellSpacing="2" EditRowStyle-HorizontalAlign="Center" PageSize="5" HeaderStyle-BackColor="#3c8dbc" HeaderStyle-ForeColor="White">
                                            <AlternatingRowStyle BackColor="White" />
                                            <PagerStyle CssClass="csspager" />
                                            <EmptyDataTemplate>No Records Available</EmptyDataTemplate>
                                            <Columns>
                                                <asp:TemplateField HeaderText="ItemName">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblItemName" runat="server" Text='<%# Eval("itemgroup") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>



                                                <asp:TemplateField HeaderText="UOM">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblUOM" runat="server" Text='<%# Eval("UnitofMeasurement") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Qty">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblQty" runat="server" Text='<%# Eval("Qty") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Rate">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblRate" runat="server" Text='<%# Eval("Rate") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Amount">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblAmount" runat="server" Text='<%# Eval("Amount") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>



                                                <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Edit">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="btnedit" ImageUrl="images/viewIcon.png" ToolTip="Click here to update"
                                                            runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("Id") %>'
                                                            CommandName="editdata" CausesValidation="False" />
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Delete">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="btnDelete" ImageUrl="images/delete.png" ToolTip="Click here to delete"
                                                            runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("Id") %>'
                                                            CommandName="deletedata" CausesValidation="False" />
                                                        <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" ConfirmText="Do You Want to Delete?" runat="server" TargetControlID="btnDelete"></asp:ConfirmButtonExtender>
                                                    </ItemTemplate>
                                                    <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                    <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <EditRowStyle HorizontalAlign="Center"></EditRowStyle>
                                        </asp:GridView>
                                    </div>
                                </div>
                            
                        

                    </div>

                </div>
                <div class="box-body">
                    <div class="box box-primary">
                        <div class="row">

                            <div class="col-md-3 form-group">
                                <label class="control-label">
                                    Next Followup Date
                                </label>
                                <asp:TextBox ID="txtfdate" class="form-control" TabIndex="2" runat="server"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtfdate" Format="dd/MM/yyyy" runat="server"></asp:CalendarExtender>
                            </div>
                            <div class="col-md-2 form-group">
                                <label>Followup Type<span class="required">* </span></label>


                                <div class="input-group">
                                    <asp:DropDownList ID="dpfollowuptype" runat="server" AutoPostBack="false" data-placeholder="Select Conatct Person" CssClass="form-control select2" TabIndex="5"></asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:LinkButton ID="LinkButton5" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                                </div>


                            </div>
                            <div class="col-md-3 form-group">
                                <label>Status<span class="required">* </span></label>


                                <div class="input-group">
                                    <asp:DropDownList ID="dpfollowstatus" runat="server" AutoPostBack="false" data-placeholder="Select Conatct Person" CssClass="form-control select2" TabIndex="5"></asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:LinkButton ID="LinkButton8" runat="server" CssClass="btn btn-dropbox btn-flat" CausesValidation="false"><i class="fa fa-plus"></i></asp:LinkButton></span>
                                </div>


                            </div>


                            <div class="col-md-9 form-group">
                                <label class="control-label">
                                    Remarks:<span class="required">* </span>
                                </label>
                                <asp:TextBox ID="txtfremarks" class="form-control" TabIndex="9" TextMode="MultiLine" runat="server"></asp:TextBox>
                                <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtfremarks"
                                    Display="Dynamic" ErrorMessage="Please Enter remarks" Text="(*) Required" ValidationGroup="Emst" SetFocusOnError="true" ForeColor="Red"
                                    CssClass="validate"></asp:RequiredFieldValidator>--%>
                            </div>


                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtfremarks"
                                    Display="Dynamic" ErrorMessage="Please Enter remarks" Text="(*) Required" ValidationGroup="Emst" SetFocusOnError="true" ForeColor="Red"
                                    CssClass="validate"></asp:RequiredFieldValidator>--%>

                            <div class="col-md-2 form-group" style="margin-top: 25px; text-align: left">

                                <asp:LinkButton ID="lbtnaddfollowup" runat="server" OnClick="lbtnaddfollowup_Click" TabIndex="36" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Add Followup</asp:LinkButton>
                                <asp:LinkButton ID="lbtnupdatefollowup" Visible="false" OnClick="lbtnupdatefollowup_Click" runat="server" TabIndex="37" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Update Followup</asp:LinkButton>
                                <asp:LinkButton ID="lbtnresetfollowup" OnClick="lbtnresetfollowup_Click" runat="server" TabIndex="38" CssClass="btn btn-bitbucket bg-gray btn-flat" CausesValidation="false"><i class="fa fa-times"></i>&nbsp;Reset</asp:LinkButton>



                            </div>
                        </div>
                        <div class="row">

                            <div class="box-body">
                                <asp:GridView ID="grdfollowup" runat="server" AlternatingRowStyle-BackColor="#C2D69B" AllowPaging="false" AllowSorting="false"
                                    AutoGenerateColumns="False" BorderWidth="1px" OnRowCommand="grdfollowup_RowCommand" ShowHeaderWhenEmpty="true"
                                    CssClass="table table-striped table-bordered table-hover dataTable no-footer" CellPadding="2"
                                    CellSpacing="2" EditRowStyle-HorizontalAlign="Center" PageSize="5" HeaderStyle-BackColor="#3c8dbc" HeaderStyle-ForeColor="White">
                                    <AlternatingRowStyle BackColor="White" />
                                    <PagerStyle CssClass="csspager" />
                                    <EmptyDataTemplate>No Records Available</EmptyDataTemplate>
                                    <Columns>
                                        <asp:TemplateField HeaderText="NextFolldate">
                                            <ItemTemplate>
                                                <asp:Label ID="lblNextFolldate" runat="server" Text='<%# Eval("NextFolldate") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                            <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Followup Type">
                                            <ItemTemplate>
                                                <asp:Label ID="lblFollowupName" runat="server" Text='<%# Eval("FollowUpType") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                            <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status">
                                            <ItemTemplate>
                                                <asp:Label ID="lblStatusName" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                            <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                        </asp:TemplateField>




                                        <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Edit">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btnedit" ImageUrl="images/viewIcon.png" ToolTip="Click here to update"
                                                    runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("Id") %>'
                                                    CommandName="editdata" CausesValidation="False" />
                                            </ItemTemplate>
                                            <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                            <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Delete">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btnDelete" ImageUrl="images/delete.png" ToolTip="Click here to delete"
                                                    runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("Id") %>'
                                                    CommandName="deletedata" CausesValidation="False" />
                                                <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" ConfirmText="Do You Want to Delete?" runat="server" TargetControlID="btnDelete"></asp:ConfirmButtonExtender>
                                            </ItemTemplate>
                                            <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                            <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <EditRowStyle HorizontalAlign="Center"></EditRowStyle>
                                </asp:GridView>
                            </div>
                        </div>
                        <div class="box box-primary">
                            <div class="box-body margin">
                                <div class="col-md-12">

                                    <asp:GridView ID="grddata" runat="server" AlternatingRowStyle-BackColor="#C2D69B" AllowPaging="false" AllowSorting="false"
                                        AutoGenerateColumns="False" BorderWidth="1px" ShowHeaderWhenEmpty="true"
                                        CssClass="table table-striped table-bordered table-hover dataTable no-footer" CellPadding="2"
                                        CellSpacing="2" EditRowStyle-HorizontalAlign="Center" PageSize="5" HeaderStyle-BackColor="#3c8dbc" HeaderStyle-ForeColor="White">
                                        <AlternatingRowStyle BackColor="White" />
                                        <PagerStyle CssClass="csspager" />
                                        <EmptyDataTemplate>No Records Available</EmptyDataTemplate>
                                        <Columns>
                                            <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="select">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="btnchkbox" ToolTip="Click here to update"
                                                        runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("id") %>'
                                                        CausesValidation="False" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Title">

                                                <ItemTemplate>
                                                    <asp:Label ID="lblname" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Description">

                                                <ItemTemplate>
                                                    <asp:Label ID="lbltandc" runat="server" Text='<%# Eval("TermsandConditions") %>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                                <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                            </asp:TemplateField>







                                            <%--<asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnedit" ImageUrl="images/viewIcon.png" ToolTip="Click here to update"
                                                runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("id") %>'
                                                CommandName="editdata" CausesValidation="False" />
                                        </ItemTemplate>
                                        <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                        <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Delete">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnDelete" ImageUrl="images/delete.png" ToolTip="Click here to delete"
                                                runat="server" CssClass="imgbtnalign1" CommandArgument='<%# Eval("id") %>'
                                                CommandName="deletedata" CausesValidation="False" />
                                         
                                        </ItemTemplate></asp:TemplateField>
                                            --%>
                                        </Columns>
                                        <EditRowStyle HorizontalAlign="Center"></EditRowStyle>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>





                        <div class="row">
                            <div class="col-md-12 form-group" style="padding-top: 5px; text-align: right">
                                <asp:LinkButton ID="btnSave" runat="server" ValidationGroup="Emst" OnClick="btnSave_Click" TabIndex="36" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Save</asp:LinkButton>
                                <asp:LinkButton ID="btnUpdate" Visible="false" runat="server" TabIndex="37" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Update</asp:LinkButton>
                                <asp:LinkButton ID="btnDelete" runat="server" TabIndex="38" CssClass="btn btn-bitbucket bg-gray btn-flat" CausesValidation="false"><i class="fa fa-times"></i>&nbsp;Reset</asp:LinkButton>
                            </div>



                        </div>
                    </div>






                </div>
        </section>

    </div>





</asp:Content>

