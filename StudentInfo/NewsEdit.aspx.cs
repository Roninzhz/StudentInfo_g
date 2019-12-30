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
    public partial class NewsEdit : System.Web.UI.Page
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
            //将取回的数据在页面进行展示，可以修改的数据使用TextBox来展示，并提供修改。
            //通过按钮触发，实现将数据编辑保存的功能

            DALnew dal = new DALnew();
            newEntity news = dal.Getnews(id);
            ViewState["news"] = news;
            desc1.Value = news.Id.ToString();
            desc.Value = news.Content;
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            DALnew dal = new DALnew();
            newEntity news = (newEntity)ViewState["news"];
            news.Title = desc1.Value;
            news.Content = desc.Value;
            dal.Modnews(news);
            ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('编辑成功！');</script>");
        }
    }
}