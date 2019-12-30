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
    public partial class PasswordMod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    GetData(id);//获取数据
                }
            }
        }

        public void GetData(int id)
        {
            DALstudent_info dal = new DALstudent_info();
            student_infoEntity student = dal.Getstudent_info(id);
            ViewState["student"] = student;
            StudentId.Value = student.StudentId;
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            DALstudent_info dal = new DALstudent_info();
            student_infoEntity student = (student_infoEntity)ViewState["student"];//获取缓存
            if (student.StudentPassword == Password1.Value)
            {
                student.StudentPassword = L_pass.Value;//修改数据
                dal.Modstudent_info(student);//提交到数据库
                Response.Write("修改成功");
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改成功！');</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改失败，请检查密码正确性！');</script>");
            }
        }
    }
}