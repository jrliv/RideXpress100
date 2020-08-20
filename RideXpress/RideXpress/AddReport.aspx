<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="AddReport.aspx.cs" Inherits="RideXpress_StarterKit.AddReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>New Incident Report</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="lblRide" runat="server" Text="Ride"
                        AssociatedControlID="ddlRide" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="ddlRide" runat="server" CssClass="form-control"></asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <span class="help-block">
                                    <span class="help-block">
                                        <asp:RequiredFieldValidator ID="RideRequired" runat="server" ErrorMessage="Ride is Required"
                                            ControlToValidate="ddlRide" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                    </span>
                                </span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblIncidentDate" runat="server" Text="Date of Incident"
                        AssociatedControlID="tbIncidentDate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="tbIncidentDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <span class="help-block">
                                    <span class="help-block">
                                        <asp:RequiredFieldValidator ID="DateRequired" runat="server" ErrorMessage="Date is Required"
                                            ControlToValidate="tbIncidentDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                    </span>
                                </span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblReportName" runat="server" Text="Name of Report"
                        AssociatedControlID="tbReportName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="tbReportName" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <span class="help-block">
                                    <span class="help-block">
                                        <asp:RequiredFieldValidator ID="NameOfReportRequired" runat="server" ErrorMessage="Name of Report is Required"
                                            ControlToValidate="tbReportName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                    </span>
                                </span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblDescription" runat="server" Text="Description"
                        AssociatedControlID="tbDescription" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="tbDescription" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <span class="help-block">
                                    <span class="help-block">
                                        <asp:RequiredFieldValidator ID="Description" runat="server" ErrorMessage="Description is Required"
                                            ControlToValidate="tbDescription" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                    </span>
                                </span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="btnAddReport" runat="server" Text="Submit" CssClass="btn btn-success" ValidationGroup="AllValidators" OnClick="btnAddReport_Click" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Reports.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
