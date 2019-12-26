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
    public partial class AdminAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            DALadmin_user dal = new DALadmin_user();
            admin_userEntity admin = new admin_userEntity();
            admin.UserName = username.Value;
            admin.UserPassword = L_pass.Value;
            admin.LoginTimes = 1;
            admin.LinkTelephone = phone.Value;
            dal.Addadmin_user(admin);
            ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加成功');location.href='AdminAdd.aspx';</script>");
        }
    }
}