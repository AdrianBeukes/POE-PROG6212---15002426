<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="pgeHome.aspx.cs" Inherits="WebApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:TextBox ID="txtHead" runat="server" BackColor="White" BorderStyle="None" Font-Size="Larger" style="position: relative; top: -11px; left: 417px; font-weight: 700; width: 76px; text-decoration: underline;">HOME</asp:TextBox>
        </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to Durban First Health</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We are a well known medical clinic, that is also home to a world renowed physician, Dr Adrian Beukes</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; It is our hope and duty to help everyone better their health, and with our leading technology, today it is possible</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; So what are you waiting for, make your&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; today.<asp:Button ID="btnBooking" runat="server" BackColor="White" BorderStyle="None" ForeColor="#0099FF" OnClick="btnBooking_Click" style="position: relative; top: 0px; left: -98px; width: 56px" Text="Booking" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For more information or questions, please look at our&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; page and contact us, we will be more than willing to help.&nbsp;<asp:Button ID="btnAbout" runat="server" BackColor="White" BorderStyle="None" ForeColor="#0099FF" OnClick="btnAbout_Click" style="position: relative; top: 1px; left: -440px; width: 62px" Text="About Us" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
