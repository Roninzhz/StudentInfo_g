<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="StudentInfo.CourseList" %>

<!DOCTYPE html class="x-admin-sm">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>全部课程</title>
    <meta name="renderer" content="webkit" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width,user-scalable=yes, minimum-scale=0.4, initial-scale=0.8,target-densitydpi=low-dpi" />
    <link rel="stylesheet" href="./css/font.css" />
    <link rel="stylesheet" href="./css/xadmin.css" />
    <script src="./lib/layui/layui.js" charset="utf-8"></script>
    <script type="text/javascript" src="./js/xadmin.js"></script>
</head>
<body>
    <div class="x-nav">
        <span class="layui-breadcrumb">
            <a href="#">首页</a>
            <a href="#">演示</a>
            <a>
                <cite>导航元素</cite></a>
        </span>
        <a class="layui-btn layui-btn-small" style="line-height: 1.6em; margin-top: 3px; float: right" title="刷新" runat="server" onclick="location.reload()">
            <i class="layui-icon layui-icon-refresh" style="line-height: 30px"></i></a>
    </div>
    <div class="layui-fluid">
        <div class="layui-row layui-col-space15">
            <div class="layui-col-md12">
                    <form class="layui-form layui-col-space5" runat="server">
                        <div class="layui-card-body ">
                            <asp:GridView ID="grdCourse" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="layui-table layui-form" PageSize="3"
                                OnRowCommand="grdCourse_RowCommand" OnRowCreated="grdCourse_RowCreated">
                                <Columns>
                                    <asp:BoundField DataField="CourseId" HeaderText="课程编号" SortExpression="CourseId" />
                                    <asp:BoundField DataField="CourseName" HeaderText="课程名" SortExpression="CourseName" />
                                    <asp:BoundField DataField="CourseTeacher" HeaderText="任课教师" SortExpression="CourseTeacher" />
                                    <asp:BoundField DataField="CourseInfo" HeaderText="课程详情" SortExpression="CourseInfo" />
                                    <asp:BoundField DataField="CourseStudentNum" HeaderText="限报人数" SortExpression="CourseStudentNum" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlCourse" runat="server" ConnectionString="<%$ ConnectionStrings:connStr %>" SelectCommand="SELECT * FROM [course]"></asp:SqlDataSource>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
