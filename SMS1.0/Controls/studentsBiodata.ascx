<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="studentsBiodata.ascx.cs" Inherits="SMS1._0.Controls.studentsBiodata" %>
<script src="../Scripts/bootstrap.js"></script>
<script src="../Scripts/jquery-1.10.2.js"></script>
<link href="../Content/bootstrap.css" rel="stylesheet" />


<div class="container">
    <div class="col-md-2"></div>
    <div class="col-md-8">

        <table class="nav-justified">
            <tr>
                <td>
                    <label for="yoe">Year Of Entry:</label><br />
                <asp:DropDownList ID="ddlYearOfBirth" runat="server">
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                            </asp:DropDownList>

                        </td>
                <td>&nbsp;</td>
                <td>
                    <label for="sports">Sports:</label><br />
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Sports</asp:ListItem>
                        <asp:ListItem>Football</asp:ListItem>
                        <asp:ListItem>Tennis</asp:ListItem>
                        <asp:ListItem>Badminton</asp:ListItem>
                        <asp:ListItem>Cricket</asp:ListItem>
                        <asp:ListItem>Athletics</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <label for="ct">Class Type:</label><br />
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <label for="disabilities">Disabilities:</label><br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>None</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <label for="religion">Religion:</label><br />
                    <asp:DropDownList ID="DropDownList4" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <label for="nationality">Nationality:</label><br />
                    <asp:DropDownList ID="DropDownList5" runat="server">
                        <asp:ListItem>Nationality</asp:ListItem>
                        <asp:ListItem>Non-Nigerian</asp:ListItem>
                        <asp:ListItem>Nigerian</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <label for="state">State:</label><br />
                    <asp:DropDownList ID="DropDownList6" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
    <div class="col-md-2"></div>
</div>