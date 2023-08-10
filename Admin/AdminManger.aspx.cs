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

public partial class Admin_AdminManger : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            InitData();
        }
    }
    protected void InitData()
    {
        GridView1.DataSource = data.GetDataReader("select * from Admin where type='教室管理员' ");
        GridView1.DataBind();
    }
    //GridView控件RowDeleting事件
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {


        string ID = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
        try
        {
            data.RunSql("delete  from Admin  where  id='" + ID + "'");

            Label4.Text = "删除成功！";
            GridView1.EditIndex = -1;
            InitData();
        }
        catch
        {

            Label4.Text = "删除失败！";
        }

    }
    //GridView控件RowUpdating事件
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        string ID = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
        try
        {
            data.RunSql("update Admin  set name ='" + ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName")).Text + "'  where id=" + ID);



            Label4.Text = "修改成功！";
            GridView1.EditIndex = -1;
            InitData();
        }
        catch
        {
            Label4.Text = "修改失败！";
        }

    }
    //GridView控件RowCanceling事件
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        InitData();
    }
    //GridView控件RowEditing事件
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        InitData();
    }

}
