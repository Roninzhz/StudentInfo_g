using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SQLDAL;
using Model;

namespace StudentInfo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateCode();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["CheckCode"];
            string uname = uName.Value;
            string pwd = uPassword.Value;
            Session["uName"] = uname;
            if (style.SelectedItem.Text=="管理员")
            {
                DALadmin_user dal = new DALadmin_user();//定义一个admin_user表的对象
                IList<admin_userEntity> users = dal.Getadmin_usersbyCondition("userName='" + uname + "'and userPassword='" + pwd + "'");

                if (users.Count > 0)//查找表中是否有相关的记录
                {
                    
                    if (cookie.Value == vcode.Value)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登陆成功！');location.href='index.aspx';</script>");
                    }
                    else
                        ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('验证码错误！');</script>");
                }
                else
                {
                    this.Page.RegisterStartupScript("", "<script>alert('登陆失败!');</script>");
                }
            }
            else if(style.SelectedItem.Text=="学生")
            {
                DALstudent_info dal = new DALstudent_info();
                IList<student_infoEntity> users= dal.Getstudent_infosbyCondition("StudentId='" + uname + "'and studentPassword='" + pwd + "'");
                if (users.Count > 0)//查找表中是否有相关的记录
                {
                    if (cookie.Value == vcode.Value)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('登陆成功！');location.href='student.aspx';</script>");
                    }
                    else
                        ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('验证码错误！');</script>");
                }
                else
                {
                    this.Page.RegisterStartupScript("", "<script>alert('登陆失败!');</script>");
                }
            }
            else
            {
                this.Page.RegisterStartupScript("", "<script>alert('请先选择用户类型！');</script>");
            }

        }

        private void GenerateCode()
        {
            int num;
            char code;
            string checkCode = String.Empty;
            //定义随机变量
            Random random = new Random();
            //随机产生4个随机字母或数字
            for (int i = 0; i < 4; i++)
            {
                num = random.Next();

                if (i % 2 != 0)
                {
                    code = (char)('0' + (char)(num % 10));//2，4位上产生数字
                }
                else
                {
                    code = (char)('A' + (char)(num % 26));//1，3位上产生字母
                }

                checkCode += code;
            }
            lblCode.Text = checkCode.ToString();
            Response.Cookies.Add(new HttpCookie("CheckCode", checkCode));
        }

    }
}