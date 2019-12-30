<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseFind.aspx.cs" Inherits="StudentInfo.CourseFind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            height: 200px;
        }

        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlCourse" DataTextField="CourseName" DataValueField="CourseId">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="sqlCourse" runat="server" ConnectionString="<%$ ConnectionStrings:connStr %>" SelectCommand="select s.StudentId,s.CourseId,s.Id,c.CourseName,s.CourseScore from course c join student_course s on s.CourseId=c.CourseId"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:Button ID="btnFind" runat="server" Text="查询成绩" OnClick="btnFind_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="CourseScore" HeaderText="该课程成绩为：" SortExpression="CourseScore" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
