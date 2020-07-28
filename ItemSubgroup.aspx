﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.master" AutoEventWireup="true" CodeFile="ItemSubgroup.aspx.cs" Inherits="ItemSubgroup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="content-wrapper">
    <section class="content-header">
            <h1>Item Subgroup</h1>
            <ol class="breadcrumb">
                <li><a href="Default.aspx"><i class="fa fa-dashboard"></i>Home</a></li>
                <li><a href="Demo.master">Master</a></li>
                <li class="active">Item Subgroup</li>
                  <asp:Label ID="lblid" runat="server" Visible="false" Text=""></asp:Label>
                 <asp:Label ID="lblloginid" runat="server" Visible="false" Text=""></asp:Label>
                   <asp:Label ID="lblrole" runat="server" Visible="false" Text=""></asp:Label>
            </ol>
        </section>
               <section class="content">
            <div class="row">
                <div class="col-md-6">
                    <div class="box box-primary">
                        <div class="box-header">
                            <h4>Item SubGroup Entry</h4>
                        </div>
                        <div class="box-body">
                            <div class="form-group">
                                <label class="control-label">
                                   Item SubGroup Name<span class="required">* </span>
                                </label>
                                <asp:TextBox ID="txtName" class="form-control" TabIndex="1" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ValidationGroup="isubgroup"
                                    Display="Dynamic" ErrorMessage="Please Enter Name" Text="(*) Required" SetFocusOnError="true" ForeColor="Red"
                                    CssClass="validate"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                            <label>Under Item Group<span class="required">* </span></label>
                            <asp:DropDownList ID="ddlgroup" runat="server" data-placeholder="Select Item Group" class="form-control select2" TabIndex="2">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="isubgroup" runat="server" ControlToValidate="ddlgroup"
                                Display="Dynamic" ErrorMessage="Please Select Group" SetFocusOnError="true" ForeColor="Red"
                                CssClass="validate" InitialValue="0"></asp:RequiredFieldValidator>
                        </div>
                            <div class="form-group pull-right">
                                <asp:LinkButton ID="btnSave" runat="server" OnClick="btnSave_Click" TabIndex="3" ValidationGroup="isubgroup" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Save</asp:LinkButton>
                            <asp:LinkButton ID="btnUpdate" Visible="false" OnClick="btnUpdate_Click" runat="server" TabIndex="4" CssClass="btn btn-bitbucket btn-flat"><i class="fa fa-save"></i>&nbsp;Update</asp:LinkButton>
                            <asp:LinkButton ID="btnDelete" runat="server" TabIndex="5" CssClass="btn btn-bitbucket bg-gray btn-flat" CausesValidation="false"><i class="fa fa-times"></i>&nbsp;Reset</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="box box-primary">
                        <div class="box-header">
                            <h4>Item SubGroup Details</h4>
                        </div>
                        <div class="box-body">
                            <asp:GridView ID="grddata" runat="server" AlternatingRowStyle-BackColor="#C2D69B" AllowPaging="false" AllowSorting="false"
                                AutoGenerateColumns="False" BorderWidth="1px" OnRowCommand="grddata_RowCommand" ShowHeaderWhenEmpty="true"
                                CssClass="table table-striped table-bordered table-hover dataTable no-footer" CellPadding="2"
                                CellSpacing="2" EditRowStyle-HorizontalAlign="Center" PageSize="5" HeaderStyle-BackColor="#3c8dbc" HeaderStyle-ForeColor="White">
                                <AlternatingRowStyle BackColor="White" />
                                <PagerStyle CssClass="csspager" />
                                <EmptyDataTemplate>No Records Available</EmptyDataTemplate>
                                <Columns>
                                     <asp:TemplateField HeaderText="Subgroup Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblItemsubGroupName" runat="server" Text='<%# Eval("SubGroupName") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                        <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Group Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblItemGroupName" runat="server" Text='<%# Eval("ItemGroup") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Wrap="true" HorizontalAlign="Left" />
                                        <HeaderStyle Wrap="true" HorizontalAlign="Left" CssClass="grdhead" />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderStyle-CssClass="lblfamt" HeaderText="Edit">
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
                                        <%--  <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" ConfirmText="Do You Want to Delete?" runat="server" TargetControlID="btnDelete"></asp:ConfirmButtonExtender> --%>
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
        </section>

           </div>
</asp:Content>

