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
public partial class Student_lunwenInfo : System.Web.UI.Page
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
        KeTiLeiXing.Text = dr["KeTiLeiXing"].ToString();
        TextBox1.Text = dr["daoshi"].ToString();
        StudentName.Text = dr["Student"].ToString();
      
    }
}
