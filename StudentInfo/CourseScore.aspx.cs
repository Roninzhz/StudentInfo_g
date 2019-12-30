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
    public partial class CourseScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                Response.Write("请先选择要录入的课程");
            LoadData();
        }
        public void LoadData()
        {
            string conditon = string.Empty;
            conditon = "CourseId='" + DropDownList1.SelectedValue+ "'";
            DALstudent_course dal = new DALstudent_course();
            IList<student_courseEntity> course = dal.Getstudent_coursesbyCondition(conditon);
            grdCourse.DataSource = course;
            grdCourse.DataBind();
        }

        protected void grdCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            DALstudent_course dal = new DALstudent_course();
            student_courseEntity course = new student_courseEntity();
            course.CourseScore=
        }
    }
}