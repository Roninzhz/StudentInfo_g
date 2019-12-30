﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLDAL;
using Model;
namespace StudentInfo
{
    public partial class NewsWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DALnew dal = new DALnew();
            newEntity news = new newEntity();
            news.Title = desc1.Value;
            news.Content = desc.Value;
            news.Author = Session["uName"].ToString();
            news.ReleaseTime = System.DateTime.Now;
            dal.Addnews(news);
            ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('新闻编辑成功');</script>");
        }
    }
}