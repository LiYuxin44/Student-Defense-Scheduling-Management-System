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
public partial class Admin_ModifyZhuanJia : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Type();
            GetArticle();
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
    private void GetArticle()
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        SqlDataReader dr;
        dr = data.GetDataReader("select * from  ZhuanJia where id=" + id);
        dr.Read();
        txtname.Text = dr["Name"].ToString();
        txtds.Text = dr["Ds"].ToString();
            DropDownList1.Items.FindByValue(dr["Sex"].ToString()).Selected = true;//选项Text  
           DropDownList2.Items.FindByText(dr["Leixing"].ToString()).Selected = true;//选项Text  
    

        txttime1.Value = dr["chushengriqi"].ToString();
        zhichi.Text = dr["zhicheng"].ToString();
        yjfx.Text = dr["yjfx"].ToString();
        GongHao.Text = dr["GongHao"].ToString();
    }




    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        data.RunSql("update   ZhuanJia set  zhicheng='"+zhichi.Text+"',yjfx='"+yjfx.Text+"', Name='" + txtname.Text + "',Ds='" + txtds.Text + "',Sex='" + DropDownList1.SelectedItem.Text + "', XueLi='" + DropDownList2.SelectedItem.Text + "',chushengriqi='" + txttime1.Value + "'  where id=" + id);

        Alert.AlertAndRedirect("修改成功！", "ZhuanJiaList.aspx");
    }
}
