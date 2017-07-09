<%@ Page Title="USER" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WEBTest.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>ADD DATA IN FORM</h3>



    <table id="tb_data" runat="server">
        <tr>
            <td>

                <asp:Label ID="lbl_Name" runat="server" Text="NAME : "></asp:Label>
            </td>
            <td>

                <asp:TextBox ID="txt_Name" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_Email" runat="server" Text="E-mail : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Email" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_Telephon" runat="server" Text="Telephon : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Tel" runat="server" Width="500px"></asp:TextBox>
            </td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_City" runat="server" Text="City : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddl_City" runat="server" Width="500px" DataTextField="CityName" DataValueField="CityName"></asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSourceCity" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT * FROM [City] ORDER BY [CityName]"></asp:SqlDataSource>
            --%></td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_Position" runat="server" Text="Position : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddl_Position" runat="server" Width="500px" DataTextField="Position" DataValueField="Position"></asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSourcePosition" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT * FROM [Position]"></asp:SqlDataSource>
           --%> </td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_Team" runat="server" Text="Team : "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddl_Team" runat="server" Width="500px" DataTextField="TeamName" DataValueField="TeamName"></asp:DropDownList>

                <%--<asp:SqlDataSource ID="SqlDataSourceTeam" runat="server" ConnectionString="<%$ ConnectionStrings:TESTConnectionString %>" SelectCommand="SELECT * FROM [Team]"></asp:SqlDataSource>--%>

            </td>
        </tr>

        <tr>

            <td>

                <asp:Label ID="lbl_Image" runat="server" Text="Image : "></asp:Label>
            </td>
            <td>
                <asp:FileUpload ID="ful_Img" runat="server" />
                <input id="btnUpload" type="button" value="Upload" runat="server" onserverclick="btnUpload_ServerClick" />
            </td>
        </tr>
    </table>
    

    <br />



    <%-- <asp:Button ID="btn_Submit" runat="server" Text="SUBMIT"  OnClick="btn_Submit_Click"/>--%>
    <input class="btn btn-default" id="btn_Submit" type="submit" value="SUBMIT" onclick="btn_Submit_Click" />


</asp:Content>
