<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminList.aspx.cs" Inherits="StudentInfo.AdminList" %>

<!DOCTYPE html class="x-admin-sm">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理员列表</title>
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
            <a class="layui-btn layui-btn-small" style="line-height: 1.6em; margin-top: 3px; float: right" onclick="location.reload()" title="刷新">
                <i class="layui-icon layui-icon-refresh" style="line-height: 30px"></i></a>
        </div>
        <div class="layui-fluid">
            <div class="layui-row layui-col-space15">
                <div class="layui-col-md12">
                    <div class="layui-card">
                        <div class="layui-card-body ">
                            <div class="layui-inline layui-show-xs-block">
                                <input class="layui-input" autocomplete="off" placeholder="开始日" name="start" id="start">
                            </div>
                            <div class="layui-inline layui-show-xs-block">
                                <input class="layui-input" autocomplete="off" placeholder="截止日" name="end" id="end">
                            </div>
                            <div class="layui-inline layui-show-xs-block">
                                <input type="text" name="username" placeholder="请输入用户名" autocomplete="off" class="layui-input">
                            </div>
                            <div class="layui-inline layui-show-xs-block">
                                <button class="layui-btn" lay-submit="" lay-filter="sreach"><i class="layui-icon">&#xe615;</i></button>
                            </div>

                        </div>
                        <div class="layui-card-header">
                            <button class="layui-btn layui-btn-danger" onclick="delAll()"><i class="layui-icon"></i>批量删除</button>
                            <button class="layui-btn" onclick="xadmin.open('添加用户','AdminAdd.aspx',700,500)"><i class="layui-icon"></i>添加</button>
                        </div>
                        <form class="layui-form layui-col-space5" runat="server">
                        <div class="layui-card-body ">
                            <asp:GridView ID="grdadmin" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="Sqladmin" CssClass="layui-table layui-form" PageSize="3">
                                <Columns>
                                    <asp:BoundField DataField="UserName" HeaderText="管理员姓名" SortExpression="UserName" />
                                    <asp:BoundField DataField="UserPassword" HeaderText="管理员密码" SortExpression="UserPassword" />
                                    <asp:BoundField DataField="LoginTimes" HeaderText="登录次数" SortExpression="LoginTimes" />
                                    <asp:BoundField DataField="LinkTelephone" HeaderText="手机号" SortExpression="LinkTelephone" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="Sqladmin" runat="server" ConnectionString="<%$ ConnectionStrings:SMDB %>" SelectCommand="SELECT * FROM [admin_user]"></asp:SqlDataSource>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
