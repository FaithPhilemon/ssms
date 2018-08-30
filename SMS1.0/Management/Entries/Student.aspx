<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="SMS1._0.Management.Entries.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.js"></script>
    <script src="../../Scripts/jquery-1.10.2.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 22px;
        }

        .auto-style3 {
            width: 1027px;
        }

        .auto-style4 {
            height: 22px;
            width: 1027px;
        }
    .auto-style5 {
        width: 198px;
    }
    .auto-style6 {
        height: 22px;
        width: 198px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-1"></div>
        <div class="col-md-10">

            <%-- Students form --%>
            <div class="form-group">

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Surname is required" ControlToValidate="txtSurname" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <label for="surname">Surname:</label>
                            &nbsp;<asp:TextBox ID="txtSurname" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style5">
                            <label for="othernames">Othernames:</label>
                            <asp:TextBox ID="txtOthernames" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Other Name(s) is required" ControlToValidate="txtOthernames" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;
                            
                        </td>
                        <td>
                            <label for="gender">Gender:</label><br />
                            <asp:DropDownList ID="ddlGender" runat="server">
                                <asp:ListItem>Select Gender</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style5">
                            <label for="dob">Date Of Birth:</label>
                            <asp:TextBox ID="txtDOB" CssClass="form-control" runat="server"></asp:TextBox><asp:Button ID="btnToggleCalender" runat="server" Text="Show Calender" OnClick="btnToggleCalender_Click" />
                            <br />
                            <asp:DropDownList ID="ddlYearOfBirth" Visible="false" runat="server">
                                <asp:ListItem>1990</asp:ListItem>
                                <asp:ListItem>1991</asp:ListItem>
                                <asp:ListItem>1992</asp:ListItem>
                                <asp:ListItem>1993</asp:ListItem>
                                <asp:ListItem>1994</asp:ListItem>
                                <asp:ListItem>1995</asp:ListItem>
                            </asp:DropDownList>

                            <asp:Calendar ID="calDOB" Visible="false" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="calDOB_SelectionChanged" SelectionMode="DayWeekMonth">
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                            </asp:Calendar>

                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phone is required" ControlToValidate="txtPhone" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <label for="phone">Phone:</label>
                            <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style5">
                            <br />
                            <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl="~/Img/NoImage.jpg" Width="120px" />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="Button1" runat="server" Text="Upload Image" />
                            <br />
                            <asp:Label ID="lblUploadFeedBack" runat="server"></asp:Label>
                            <br />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Button ID="btnRegister" CssClass="btn btn-success" runat="server" Text="Register" Width="200px" />
                        </td>
                        <td class="auto-style5">&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnReset" CssClass="btn btn-danger" runat="server" Text="Reset" />
                            &nbsp;
                            <asp:Label ID="lblMessage" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate" CssClass="btn btn-primary" runat="server" Text="Update Biodata" Width="200px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"></td>
                        <td class="auto-style2"></td>
                        <td class="auto-style6"></td>
                        <td class="auto-style2"></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
                <br />

            </div>
        </div>
        <div class="col-md-1"></div>
    </div>
</asp:Content>
