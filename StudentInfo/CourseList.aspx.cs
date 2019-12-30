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
    public partial class CourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//页面首次加载自动执行
            {
                LoadData();
            }
        }

        public void LoadData()
        {
            string conditon = string.Empty;
            conditon = "(CourseId is not null and CourseId<>' ')";

            DALcourse dal = new DALcourse();
            IList<courseEntity> course = dal.GetcoursesbyCondition(conditon);//按照条件来查询数据
            grdCourse.DataSource = course;
            grdCourse.DataBind();
        }
        protected void grdCourse_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grdCourse_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
    }
}