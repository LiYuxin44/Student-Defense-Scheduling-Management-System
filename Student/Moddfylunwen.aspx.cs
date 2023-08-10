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
public partial class Student_Moddfylunwen : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            GetInfo();
        }

    }
    public void GetInfo()
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        SqlDataReader dr;
        dr = data.GetDataReader("select top 1  * from  Lunwen where id=" + id);

        dr.Read();
        txtTitle.Text = dr["Name"].ToString();
      
        txtlunwenInfo.Text = dr["lunwen"].ToString();
   
    
        KeTiBianHao.Text = dr["KeTiBianHao"].ToString();
        DropDownList1.SelectedValue = dr["KeTiLeiXing"].ToString();
     
        Hidden1.Value = dr["Checked1"].ToString();
        Hidden2.Value = dr["Checked2"].ToString();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        if (Hidden1.Value == "通过" && Hidden2.Value == "通过")
        {
            Alert.AlertAndRedirect("已经审核通过不能修改！", "LunwenList.aspx");

        }
        else
        {
            data.RunSql("update  Lunwen set    KeTiLeiXing='"+DropDownList1.SelectedValue+"',     Name='" + txtTitle.Text + "',lunwen='" + txtlunwenInfo.Text + "',KeTiBianHao='" + KeTiBianHao.Text + "'  where id=" + id);
            Alert.AlertAndRedirect("修改成功！", "LunwenList.aspx");
        }
    }
}
