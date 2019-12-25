using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using SQLDAL;

namespace StudentInfo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["CheckCode"];
            string username = user_name.Value;
            string password = pass_word.Value;
            SQLDAL.DALadmin_user dALadmin_User = new DALadmin_user();
            IList<admin_userEntity> users = dALadmin_User.Getadmin_usersbyCondition("userName='" + username + "' and userPassword='" + password + "'");
            if (users.Count > 0&& cookie.Value == CheckCode.Value)
            {
                this.Page.RegisterStartupScript("", "<script>alert('登陆成功！');</script>");
            }
            else
            {
                this.Page.RegisterStartupScript("", "<script>alert('登陆失败！');</script>");
            }
            //if (cookie.Value == txtCheckCode.Text)
            //    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('注册成功');location.href='Login.aspx';</script>");
            //else
            //    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('验证码错误');</script>");
        }

        protected void shuxin_Click(object sender, EventArgs e)
        {
            Image.ImageUrl = "~/CheckCode.aspx";
        }
    }
}