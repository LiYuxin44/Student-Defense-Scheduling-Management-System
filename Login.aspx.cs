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
public partial class Login : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    SqlDataReader dr;
    Alert js = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Login_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "管理员")
        {
            chkADmin();

        }
        if (DropDownList1.SelectedItem.Text == "学生")
        {
            chkjiaoshi();
        }
        if (DropDownList1.SelectedItem.Text == "教师")
        {
            chkUser();
        }
        if (DropDownList1.SelectedItem.Text == "教室管理员")
        {
            chkJs();
        }
    }
    private void chkUser()
    {
        if (UserName.Text == "" && PassWord.Text == "")
            {
                Alert.AlertAndRedirect("没有输入账号和密码！", "Login.aspx");


            }
            else
            {
                dr = data.GetDataReader("select * from  [ZhuanJia] where GongHao='" + UserName.Text.Trim() + "'and Pwd='" + PassWord.Text.Trim() + "'");
                if (dr.Read())
                {
                    Session["User"] = dr["Name"].ToString();
                    Session["UserId"] = dr["id"].ToString();
                    Session["Leixing"] = dr["Leixing"].ToString();
                    Session["daoshi"] = dr["name"].ToString();
                    Response.Redirect("ZhuanJia/index.html");

                }
                else
                {
                    Alert.AlertAndRedirect("账号或者密码不对请重新登陆！", "Login.aspx");
                }
            }
    }
    private void chkjiaoshi()
    {


        if (UserName.Text == "" && PassWord.Text == "")
            {
                Alert.AlertAndRedirect("没有输入账号和密码！", "Login.aspx");


            }
            else
            {
                dr = data.GetDataReader("select * from  [Student] where TNmuber='" + UserName.Text.Trim() + "'and Pwd='" + PassWord.Text.Trim() + "'");
                if (dr.Read())
                {
                    Session["UserId"] = dr["id"].ToString();
                    Session["User"] = dr["Name"].ToString();
                    Session["Student"] = dr["Name"].ToString();
                    Session["daoshi"] = dr["daoshi"].ToString();
                    Session["yjfx"] = dr["yjfx"].ToString();
                    Response.Redirect("Student/index.html");

                }
                else
                {
                    Alert.AlertAndRedirect("账号或者密码不对请重新登陆！", "Login.aspx");
                }
            }
    }
    private void chkADmin()
    {
        if (UserName.Text == "" && PassWord.Text == "")
        {
            Alert.AlertAndRedirect("没有输入账号和密码！", "Login.aspx");


        }
        else
        {
            dr = data.GetDataReader("select * from  Admin where name='" + UserName.Text.Trim() + "'and Password='" + PassWord.Text.Trim() + "'");
            if (dr.Read())
            {
                Session["Userid"] = dr["id"].ToString();
                Session["User"] = dr["Name"].ToString();
                Session["admin"] = dr["name"].ToString();
                Response.Redirect("Admin/index.html");

            }
            else
            {
                Alert.AlertAndRedirect("管理员的账号或者密码不对请重新登陆！", "Login.aspx");
            }
        }
    }









    private void chkJs()
    {
        if (UserName.Text == "" && PassWord.Text == "")
        {
            Alert.AlertAndRedirect("没有输入账号和密码！", "Login.aspx");


        }
        else
        {
            dr = data.GetDataReader("select * from  Admin where name='" + UserName.Text.Trim() + "'and Password='" + PassWord.Text.Trim() + "' and type='教室管理员' ");
            if (dr.Read())
            {
                Session["Userid"] = dr["id"].ToString();
                Session["User"] = dr["Name"].ToString();
                Session["admin"] = dr["name"].ToString();
                Response.Redirect("JiaosShiGly/index.html");

            }
            else
            {
                Alert.AlertAndRedirect("管理员的账号或者密码不对请重新登陆！", "Login.aspx");
            }
        }
    }
}

