<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="pgeBooking.aspx.cs" Inherits="WebApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-weight: 700">
        <asp:TextBox ID="txtBooking" runat="server" BackColor="White" BorderStyle="None" Font-Size="Larger" style="position: relative; top: 8px; left: 399px; font-weight: 700; width: 118px; text-decoration: underline;">BOOKING</asp:TextBox>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Durban First Health Booking:</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We are glad to see you&#39;re doing a booking with us, hope we can help you as soon as possible.</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please fill out all the information below:</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Name :<asp:TextBox ID="txtName" runat="server" style="position: relative; top: 0px; left: 238px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Surname :<asp:TextBox ID="txtSurname" runat="server" style="position: relative; top: 0px; left: 223px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phone Number :<asp:TextBox ID="txtNumber" runat="server" style="position: relative; top: 0px; left: 184px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date :</p>
    <asp:Calendar ID="CalDate" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" style="z-index: 1; left: 339px; top: 414px; position: absolute; height: 188px; width: 259px" Width="330px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Time :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDwnTime" runat="server">
            <asp:ListItem>9:00</asp:ListItem>
            <asp:ListItem>9:30</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
            <asp:ListItem>10:30</asp:ListItem>
            <asp:ListItem>11:00</asp:ListItem>
            <asp:ListItem>11:30</asp:ListItem>
            <asp:ListItem>12:00</asp:ListItem>
            <asp:ListItem>12:30</asp:ListItem>
            <asp:ListItem>13:00</asp:ListItem>
            <asp:ListItem>13:30</asp:ListItem>
            <asp:ListItem>14:00</asp:ListItem>
            <asp:ListItem>14:30</asp:ListItem>
            <asp:ListItem>15:00</asp:ListItem>
            <asp:ListItem>15:30</asp:ListItem>
            <asp:ListItem>16:00</asp:ListItem>
            <asp:ListItem>16:30</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Short Description / Reason for Booking&nbsp;:<asp:TextBox ID="txtDescription" runat="server" style="position: relative; top: 48px; left: 34px; width: 299px; height: 58px; z-index: 1" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Check availability allows you to view if physician is availible during that time, and must be done before you can book.&nbsp;</p>
    <asp:Button ID="btnAvailability" runat="server" style="position: relative; top: -11px; left: 328px; width: 171px" Text="Check Availability" OnClick="btnAvailability_Click" />
    <p>
        <asp:Button ID="btnClear" runat="server" style="position: relative; top: -11px; left: 154px; width: 171px" Text="Clear" OnClick="btnClear_Click" />
        <asp:Button ID="btnBook" runat="server" Enabled="False" style="position: relative; top: -11px; left: 329px; width: 171px" Text="Book" OnClick="btnBook_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
