<%@ Page Title="USER" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WEBTest.About" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>

    <table1>
        <tr1>
            <td1>
                <asp:Label ID="lbl_Search" runat="server" Text="SEARCH : "></asp:Label>
            </td1>

            <td1>

                <asp:TextBox ID="txb_Search" runat="server" Width="500px"></asp:TextBox>

            </td1>
        </tr1>

    </table1>


    <input class="btn btn-default" id="btn_Search" type="submit" value="SEARCH" onclick="btn_Search_Click" />

    <br />
    <br />
    <br />

    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gv_Search" runat="server" AutoGenerateColumns="False" Width="1000px"
            OnPageIndexChanging="gv_Search_PageIndexChanging" BackColor="White" BorderColor="#CCCCCC"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="E-mail" SortExpression="Email" />
                <asp:BoundField DataField="Telephon" HeaderText="Telephone" SortExpression="Telephon" />
                <asp:BoundField DataField="TeamName" HeaderText="Team" SortExpression="TeamName" />
                <asp:BoundField DataField="CityName" HeaderText="City" SortExpression="CityName" />
                <asp:BoundField DataField="Position1" HeaderText="Position" SortExpression="Position" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />

            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

        <br />
        <br />

        <img src="Image/mm.png" class="img-circle" width="140" height="140">

        <%-- <table style="border-collapse: collapse; width:1000px" >
            <tr>
                <td style="width: 150px">Name:<br />
                    <asp:TextBox ID="txtName" runat="server" Width="140" />
                </td>
                <td style="width: 150px">E-mail:<br />
                    <asp:TextBox ID="txtEmail" runat="server" Width="140" />
                </td>
                 <td style="width: 150px">Telephone:<br />
                    <asp:TextBox ID="txtTel" runat="server" Width="140" />
                </td>
                 <td style="width: 150px">Team:<br />
                    <asp:DropDownList ID="ddl_Team" runat="server" Width="140px" DataSourceID="SqlDataSourceTT" DataTextField="ID" DataValueField="ID" />
                     <asp:SqlDataSource ID="SqlDataSourceTT" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT [ID], [TeamName] FROM [Team]"></asp:SqlDataSource>
                </td>
                 <td style="width: 150px">City:<br />
                    <asp:DropDownList ID="ddl_City" runat="server" Width="140px" DataSourceID="SqlDataSourceCC" DataTextField="ID" DataValueField="ID" />
                     <asp:SqlDataSource ID="SqlDataSourceCC" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT [ID], [CityName] FROM [City]"></asp:SqlDataSource>
                </td>
                 <td style="width: 150px">Position:<br />
                    <asp:DropDownList ID="ddl_Position" runat="server" Width="140px" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID" />
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT [ID], [Position] FROM [Position]"></asp:SqlDataSource>
                </td>

                <td style="width: 100px">
                    <asp:Button ID="btnAdd" runat="server" Text="Add"  OnClick="btnAdd_Click"/>
                </td>
            </tr>
        </table>--%>
    </asp:Panel>
    <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>"
        SelectCommand="SELECT [UserN].Name, [UserN].Email, [UserN].Telephon, [UserN].Date, [City].CityName, [Position].Position, [Team].TeamName
  FROM [UserN],[Team],[City],[Position]
  WHERE [UserN].City_id = [City].ID AND
  [UserN].Position_id = [Position].ID AND
  [UserN].Team_id = [Team].ID ORDER BY [Date] DESC"></asp:SqlDataSource>--%>
</asp:Content>
