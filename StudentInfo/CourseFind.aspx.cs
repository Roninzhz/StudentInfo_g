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
    public partial class CourseFind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string conditon = string.Empty;
            conditon = "(StudentId is not null and StudentId<>' ')";
            if (!string.IsNullOrEmpty(DropDownList1.SelectedValue))
            {
               conditon += " and CourseId='" + DropDownList1.SelectedValue+ "' and StudentId='"+Session["uName"]+"'";
            }
            DALstudent_course dal = new DALstudent_course();
            IList<student_courseEntity> Course = dal.Getstudent_coursesbyCondition(conditon);
            GridView1.DataSource = Course;
            GridView1.DataBind();
        }
    }
}