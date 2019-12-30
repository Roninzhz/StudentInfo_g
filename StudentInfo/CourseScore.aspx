<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseScore.aspx.cs" Inherits="StudentInfo.CourseScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 800px;
            height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CourseName" DataValueField="CourseId" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grdCourse" DataKeyNames="Id" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField HeaderText="学号" DataField="StudentId" />
                                <asp:TemplateField HeaderText="成绩">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtCourse" Text="" runat="server" TextMode="SingleLine"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connStr %>" SelectCommand="SELECT [Id], [CourseId], [CourseName] FROM [course]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnOK" runat="server" Text="录入" OnClick="btnOK_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
