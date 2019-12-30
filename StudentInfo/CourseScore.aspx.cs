﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLDAL;
using Model;
using System.Data;
namespace StudentInfo
{
    public partial class CourseScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("请先选择要录入的课程");
            }  
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

        protected void btnOK_Click(object sender, EventArgs e)
        {
            DALstudent_course dal = new DALstudent_course();
            student_courseEntity course = new student_courseEntity();
            foreach (GridViewRow gvr in grdCourse.Rows)
            {
                if (gvr.RowType == DataControlRowType.DataRow)
                {
                    int id = int.Parse(grdCourse.DataKeys[gvr.RowIndex].Value.ToString());
                    course = dal.Getstudent_course(id);
                    TextBox tb = (TextBox)gvr.FindControl("txtCourse");
                    course.CourseScore = decimal.Parse(tb.Text.Trim());
                    dal.Modstudent_course(course);
                }
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}