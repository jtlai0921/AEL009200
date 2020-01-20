<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 468px;
            height: 63px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <img class="style1" src="booktitle.jpg" /><br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    DeleteCommand="DELETE FROM [書籍] WHERE [書號] = @書號" 
                    InsertCommand="INSERT INTO [書籍] ([書號], [書名], [單價], [數量]) VALUES (@書號, @書名, @單價, @數量)" 
                    SelectCommand="SELECT * FROM [書籍]" 
                    UpdateCommand="UPDATE [書籍] SET [書名] = @書名, [單價] = @單價, [數量] = @數量 WHERE [書號] = @書號">
                    <DeleteParameters>
                        <asp:Parameter Name="書號" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="書號" Type="String" />
                        <asp:Parameter Name="書名" Type="String" />
                        <asp:Parameter Name="單價" Type="Int32" />
                        <asp:Parameter Name="數量" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="書名" Type="String" />
                        <asp:Parameter Name="單價" Type="Int32" />
                        <asp:Parameter Name="數量" Type="Int32" />
                        <asp:Parameter Name="書號" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" 
                    CellPadding="4" DataKeyNames="書號" DataSourceID="SqlDataSource1" 
                    DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                    <EditRowStyle BackColor="#999999" />
                    <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                    <Fields>
                        <asp:BoundField DataField="書號" HeaderText="書號" ReadOnly="True" 
                            SortExpression="書號" />
                        <asp:BoundField DataField="書名" HeaderText="書名" SortExpression="書名" />
                        <asp:BoundField DataField="單價" HeaderText="單價" SortExpression="單價" />
                        <asp:BoundField DataField="數量" HeaderText="數量" SortExpression="數量" />
                        <asp:CommandField ButtonType="Button" ShowInsertButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                </asp:DetailsView>
                <br />
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                    BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    DataKeyNames="書號" DataSourceID="SqlDataSource1" PageSize="5">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                            ShowEditButton="True" />
                        <asp:BoundField DataField="書號" HeaderText="書號" ReadOnly="True" 
                            SortExpression="書號" />
                        <asp:BoundField DataField="書名" HeaderText="書名" SortExpression="書名" />
                        <asp:BoundField DataField="單價" HeaderText="單價" SortExpression="單價" />
                        <asp:BoundField DataField="數量" HeaderText="數量" SortExpression="數量" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
