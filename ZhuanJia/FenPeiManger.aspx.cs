using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
public partial class Admin_FenPeiManger : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert js = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string yj = data.ReturnSql(" select yj from zhuanjia where id=" + Session["UserId"]);
            DataTable dt = data.GetDs(" select *  from zhuanjia  where  ( zt  is not null or yzt is not null or dzt is not null ) and id=" + Session["UserId"], "abc").Tables[0];
            if (dt.Rows.Count>0)
            {
                try
                {
                    DataBinds();
                    YDataBinds();
                    DDataBinds();
                }
                catch { }

                if (yj.Length > 0)
                {

                    Button1.Visible = false;
                    DropDownList1.SelectedValue = yj;
                
                
                
                
                
                }
            }
            else
            {
           
            }

  
        }

    }

    public void DataBinds()
    {

        string sqls = "select xl,fx,zm,addtime from Fenzu group by xl,fx,zm,addtime order  by   addtime asc";
        DataList1.DataSource = data.GetDv(sqls);
        DataList1.DataBind();





    }
    public void DDataBinds()
    {

        string sqls = "select xl,fx,zm,addtime from Fenzu group by xl,fx,zm,addtime order  by   addtime asc";
        DataList3.DataSource = data.GetDv(sqls);
        DataList3.DataBind();





    }


    public void YDataBinds()
    {

        string sqls = "select xl,fx,zm,addtime from Fenzu group by xl,fx,zm,addtime order  by   addtime asc";
        DataList2.DataSource = data.GetDv(sqls);
        DataList2.DataBind();





    }















    public string xsz(string zm)
    {

        DataTable dt = new DataTable();
        string name = "";
        dt = data.GetDs(" select sid from fenzu where zm='" + zm + "' ", "abc").Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            name = name + "  " + data.ReturnSql(" select name from student where id=" + dt.Rows[i][0].ToString());


        }
        return name;


    }





    public string dbpw(string zm)
    {

        DataTable dt = new DataTable();
        string name = "";
        dt = data.GetDs(" select name from ZhuanJia where zt='" + zm + "' ", "abc").Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            name = name + "  " + dt.Rows[i][0].ToString();


        }
        return name;


    }

    public string ydbpw(string zm)
    {

        DataTable dt = new DataTable();
        DataTable ydt = new DataTable();
        ydt = data.GetDs(" select name from ZhuanJia where yzt='" + zm + "' and Dbzx=1 ", "abc").Tables[0];
        string name = ydt.Rows[0][0].ToString() + "(答辩主席)";
        dt = data.GetDs(" select name from ZhuanJia where yzt='" + zm + "' and Dbzx is NULL", "abc").Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            name = name + "  " + dt.Rows[i][0].ToString();


        }
        return name;


    }



    public string ddbpw(string zm)
    {

        DataTable dt = new DataTable();
        DataTable ydt = new DataTable();
        ydt = data.GetDs(" select name from ZhuanJia where dzt='" + zm + "' and Dbbzx=1 ", "abc").Tables[0];
        string name = ydt.Rows[0][0].ToString() + "(答辩主席)";
        dt = data.GetDs(" select name from ZhuanJia where dzt='" + zm + "' and Dbbzx is NULL", "abc").Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            name = name + "  " + dt.Rows[i][0].ToString();


        }
        return name;


    }








    public string ktds(string zm)
    {

        DataTable dt = new DataTable();
        string name = "";
        dt = data.GetDs(" select sid from fenzu where zm='" + zm + "' ", "abc").Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (!name.Contains(data.ReturnSql(" select daoshi from student where id=" + dt.Rows[i][0].ToString())))
                name = name + "  " + data.ReturnSql(" select daoshi from student where id=" + dt.Rows[i][0].ToString());


        }
        return name;

    }











    protected void GvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {


    }
    public DataSet GetCodeBy(int iCount)
    {

        string strTop = "";
        if (iCount > 1)
        {
            strTop = "top " + iCount.ToString();
        }
        string sql = "select  " + strTop + "  * from [Lunwen] where IsFenPei='是'";
        SqlConnection con = new SqlConnection(SqlHelper.connstring);
        SqlCommand cmd = new SqlCommand(sql, con);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = null;
        try
        {
            con.Open();
            ds = new DataSet();
            da.Fill(ds);

        }
        catch (SqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
        return ds;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        data.RunSql(" delete from Fenzu ");
        data.RunSql(" update ZhuanJia set Zt=NULL,Yzt=NULL,Dbzx=NULL,Dzt=NULL,Dbbzx=NULL ");
        data.RunSql(" update  dbtime  set zt=0");

        DataTable xueli = new DataTable();
        DataTable Yjfx = new DataTable();
        Yjfx = data.GetDs(" select distinct KeTiLeiXing from Lunwen ", "xueli").Tables[0];
        xueli = data.GetDs(" select name from xueli ", "xueli").Tables[0];
        int a = 1;

        for (int i = 0; i < xueli.Rows.Count; i++)
        {


            for (int j = 0; j < Yjfx.Rows.Count; j++)
            {
                int cd = 0;
                int pm = 1;
                DataTable fz = new DataTable();
                fz = data.GetDs(" select student.*,lunwen.ketileixing from lunwen inner join Student on lunwen.[student]=Student.name    where xueli='" + xueli.Rows[i][0] + "' and ketileixing='" + Yjfx.Rows[j][0] + "'  order by newid() ", "abc").Tables[0];

                string time =data.ReturnSql(" select time from dbtime where zt=0  order by  newid()");
                data.RunSql(" update dbtime set zt=1 where time='" + time + "'");
                for (int k = 0; k < fz.Rows.Count; k++)
                {

                    if (cd != 0 && cd % 5 == 0)
                    {
                        pm = pm + 1;


                        time = data.ReturnSql(" select time from dbtime where zt=0  order by  newid()");
                        data.RunSql(" update dbtime set zt=1 where time='" + time + "'");





                    }

                    data.RunSql(" update ZhuanJia set gl='" + fz.Rows[k]["xueli"] + fz.Rows[k]["ketileixing"] + "'+'第" + pm + "组'  where Name='" + fz.Rows[k]["daoshi"].ToString()+ "'");

                    data.RunSql(" insert into Fenzu values(" + fz.Rows[k]["id"] + ",'" + fz.Rows[k]["xueli"] + "','" + fz.Rows[k]["ketileixing"] + "','" + fz.Rows[k]["xueli"] + fz.Rows[k]["ketileixing"] + "'+'第" + pm + "组','" + time + "') ");
                    a = a + 1;
                    cd = cd + 1;
                }



            }



        }

        DataTable fenzu = new DataTable();
        fenzu = data.GetDs(" select  xl,fx,zm  from Fenzu group by xl,fx,zm ", "abc").Tables[0];
        DataTable daoshi = new DataTable();
        string lx;
        for (int c = 0; c < fenzu.Rows.Count; c++)
        {
            if (fenzu.Rows[c]["xl"].ToString() == "MBA" || fenzu.Rows[c]["xl"].ToString() == "普通硕士")
                lx = "硕师";
            else
                lx = "博导";
            daoshi = data.GetDs(" select * from ZhuanJia where leixing='" + lx + "' and zt is  null order by newid()", "abc").Tables[0];
            if (daoshi.Rows.Count > 1)
            {
                data.RunSql(" update  ZhuanJia set zt='" + fenzu.Rows[c]["zm"] + "' where id=" + daoshi.Rows[0][0].ToString());
                data.RunSql(" update  ZhuanJia set zt='" + fenzu.Rows[c]["zm"] + "' where id=" + daoshi.Rows[1][0].ToString());


            }
            else
            {



                Alert js = new Alert();
                js.Alertjs("导师人数不够不能执行");

            }

         


        }




        ////////////////抽取教授

        for (int cc = 0; cc < fenzu.Rows.Count; cc++)
        {
            if (fenzu.Rows[cc]["xl"].ToString() == "MBA" || fenzu.Rows[cc]["xl"].ToString() == "普通硕士")
                lx = "硕师";
            else
                lx = "博导";
            DataTable daoshis = data.GetDs(" select * from ZhuanJia where leixing='" + lx + "' and yzt is  null order by newid()", "abc").Tables[0];
            if (daoshis.Rows.Count > 1)
            {

                data.RunSql(" update  ZhuanJia set yzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshis.Rows[0][0].ToString());



            }

            DataTable daoshiss = data.GetDs(" select * from ZhuanJia where zhicheng='教授' and yzt is  null order by newid()", "abc").Tables[0];
            if (daoshiss.Rows.Count > 1)
            {

                data.RunSql(" update  ZhuanJia set Dbzx=1, yzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshiss.Rows[0][0].ToString());



            }



        }



        ///////////////答辩
        for (int cc = 0; cc < fenzu.Rows.Count; cc++)
        {
            if (fenzu.Rows[cc]["xl"].ToString() == "MBA" || fenzu.Rows[cc]["xl"].ToString() == "普通硕士")
                lx = "硕师";
            else
                lx = "博导";
            DataTable daoshis = data.GetDs(" select * from ZhuanJia where leixing='" + lx + "' and gl!='" + fenzu.Rows[cc]["zm"].ToString() + "' and dzt is  null order by newid()", "abc").Tables[0];
            if (daoshis.Rows.Count > 3)
            {

                data.RunSql(" update  ZhuanJia set dzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshis.Rows[0][0].ToString());
                data.RunSql(" update  ZhuanJia set dzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshis.Rows[1][0].ToString());
                data.RunSql(" update  ZhuanJia set dzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshis.Rows[2][0].ToString());
                data.RunSql(" update  ZhuanJia set dzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshis.Rows[3][0].ToString());


            }

            DataTable daoshiss = data.GetDs(" select * from ZhuanJia where zhicheng='教授' and Dzt is  null order by newid()", "abc").Tables[0];
            if (daoshiss.Rows.Count > 1)
            {

                data.RunSql(" update  ZhuanJia set Dbbzx=1, dzt='" + fenzu.Rows[cc]["zm"] + "' where id=" + daoshiss.Rows[0][0].ToString());



            }



        }
        











        
        Response.Redirect("fenpeiManger.aspx");
    }




    protected void Button1_Click1(object sender, EventArgs e)
    {
        data.RunSql(" update zhuanjia  set yj='" + DropDownList1.SelectedValue + "' where  id=" + Session["UserId"]);
        Alert js = new Alert();
        js.Alertjs("提交成功！");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //设置Http的头信息,编码格式  
        HttpContext.Current.Response.Buffer = true;
        HttpContext.Current.Response.Clear();
        //HttpContext.Current.Response.Charset = "UTF8";
        //HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;//注意编码
        HttpContext.Current.Response.ClearContent();
        HttpContext.Current.Response.ClearHeaders();
        System.Web.HttpContext.Current.Response.Charset = "UTF-8";   //GB2312 

        HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
        HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + DateTime.Now.ToString("yyyymmddhhmmss") + ".xls");





        //关闭控件的视图状态  ,如果仍然为true，RenderControl将启用页的跟踪功能，存储与控件有关的跟踪信息
        this.EnableViewState = false;
        //将要下载的页面输出到HtmlWriter  
        System.IO.StringWriter writer = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter htmlWriter = new System.Web.UI.HtmlTextWriter(writer);
        this.RenderControl(htmlWriter);
        //提取要输出的内容  
        string pageHtml = writer.ToString();
        int startIndex = pageHtml.IndexOf("<divs id=\"abc\">");
        int endIndex = pageHtml.LastIndexOf("</divs>");
        int lenth = endIndex - startIndex;
        pageHtml = pageHtml.Substring(startIndex, lenth);
        //输出
        System.Web.HttpContext.Current.Response.Write("<meta http-equiv=\"content-type\" content=\"application/ms-excel; charset=UTF-8\"/>");
        HttpContext.Current.Response.Write(pageHtml.ToString());
        HttpContext.Current.Response.End();
    }
}

