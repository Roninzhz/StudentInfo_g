<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentInfo.Login" %>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<link rel="stylesheet" type="text/css" href="css/skin_/login.css" />
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.select.js"></script>
<title>教务管理系统_用户登录</title>
</head>

<body>
    <form runat="server">
        <div id="container" runat="server">
    <div id="bd" runat="server">
    	<div id="main" runat="server">
        	<div class="login-box" runat="server">
                <div id="logo"></div>
                
                <div class="input username" id="username" runat="server">
                    <label for="userName">用户名</label>
                    <span></span>
                    <input type="text" id="uName" runat="server" />
                </div>
                <div class="input psw" id="psw" runat="server">
                    <label for="password">密&nbsp;&nbsp;&nbsp;&nbsp;码</label>
                    <span></span>
                    <input type="password" id="uPassword" runat="server" />
                </div>
                <div class="input validate" id="validate" runat="server">
                    <label for="valiDate">验证码</label>
                    <input type="text" id="vcode" runat="server" />
                    <div class="value">
                        <asp:Label ID="lblCode" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="styleArea">
                    <div class="styleWrap">
                        <asp:DropDownList ID="style" runat="server">
                            <asp:ListItem Value="0" Text="用户类型"></asp:ListItem>
                            <asp:ListItem Value="1" Text="管理员"></asp:ListItem>
                            <asp:ListItem Value="2" Text="学生"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div id="btn" class="loginButton" runat="server">
                    <asp:Button ID="btnLogin" runat="server" Text="登录"  OnClick="btnLogin_Click" ForeColor="Black" />
                </div>
            </div>
        </div>
    </div>
   
</div>
    </form>

</body>
<script type="text/javascript">
	var height = $(window).height() > 445 ? $(window).height() : 445;
	$("#container").height(height);
	var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
	$('#bd').css('padding-top', bdheight);
	$(window).resize(function(e) {
        var height = $(window).height() > 445 ? $(window).height() : 445;
		$("#container").height(height);
		var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
		$('#bd').css('padding-top', bdheight);
    });
	$('select').select();
</script>

</html>

