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
public partial class Admin_ModifyStudent : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

       
            GetArticle();
        }
    }
    /// <summary>
    /// 绑定类别
    /// </summary>

    private void GetArticle()
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        SqlDataReader dr;
        dr = data.GetDataReader("select * from  Student where id=" + id);
        dr.Read();
        txtname.Text = dr["Name"].ToString();
        txtds.Text = dr["Ds"].ToString();
            DropDownList1.Items.FindByValue(dr["Sex"].ToString()).Selected = true;//选项Text  
        
     

        txtAge.Text = dr["UserAge"].ToString();
        txttime1.Value = dr["chushengriqi"].ToString();

        TNmuber.Text = dr["TNmuber"].ToString();
    }




    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        data.RunSql("update   Student set Name='" + txtname.Text + "',Ds='" + txtds.Text + "',Sex='" + DropDownList1.SelectedItem.Text + "',UserAge='" + txtAge.Text + "',chushengriqi='" + txttime1.Value + "'  where id=" + id);

        Alert.AlertAndRedirect("修改成功！", "StudentList.aspx");
    }
}
