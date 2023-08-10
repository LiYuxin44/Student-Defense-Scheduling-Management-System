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
public partial class Admin_AddZhuanJia : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Type();
        }
    }
    /// <summary>
    /// 绑定类别
    /// </summary>
    private void Type()
    {

        DropDownList2.DataSource = data.GetDataReader("select * from  Leixing  ");
        DropDownList2.DataTextField = "Name";
        DropDownList2.DataValueField = "id";
        DropDownList2.DataBind();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        SqlDataReader dr = data.GetDataReader("select * from  ZhuanJia where  GongHao='" + GongHao.Text + "'");
        if (dr.Read())
        {
            Label2.Text = "工号不能重复请更换工号";
        }
        else
        {
            data.RunSql("insert into ZhuanJia(Pwd,Name,Sex,Leixing,chushengriqi,Ds,GongHao,zhicheng,yjfx)values('" + TextBox1.Text + "','" + txtname.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + txttime1.Value + "','" + txtds.Text + "','" + GongHao.Text + "','" + zhichi.SelectedValue + "','" + yjfx.SelectedValue + "')");

            Alert.AlertAndRedirect("添加成功！", "ZhuanJiaList.aspx");
        }
    }
    protected void txtds_TextChanged(object sender, EventArgs e)
    {

    }
}
