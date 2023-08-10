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
public partial class Admin_AddStudent : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList2.DataSource = data.GetDataReader("select * from  XueLi  ");
            DropDownList2.DataTextField = "Name";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();

            DropDownList4.DataSource = data.GetDv(" select Name from ZhuanJia where name not like '%校外%'");
            DropDownList4.DataValueField = "Name";
            DropDownList4.DataTextField = "Name";
            DropDownList4.DataBind();
       
        }
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        SqlDataReader dr = data.GetDataReader("select * from  Student where  TNmuber='" + TNmuber.Text + "'");
        if (dr.Read())
        {
            Label2.Text = "学号不能重复请更换工号";
        }
        else
        {
            data.RunSql("insert into Student(Pwd,Name,Sex,UserAge,chushengriqi,Ds,TNmuber,XueLi,Yjfx,daoshi)values('" + TextBox1.Text + "','" + txtname.Text + "','" + DropDownList1.SelectedItem.Text + "','" + txtAge.Text + "','" + txttime1.Value + "','" + txtds.Text + "','" + TNmuber.Text + "','" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "','" + DropDownList4.SelectedValue + "')");

            Alert.AlertAndRedirect("添加成功！", "StudentList.aspx");
        }
    }
    protected void txtds_TextChanged(object sender, EventArgs e)
    {

    }
}
