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
public partial class Admin_Checked : System.Web.UI.Page
{

    SqlHelper data = new SqlHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        if (RadioButtonList1.SelectedValue == "通过")
        {
         
            data.RunSql("update  Lunwen set  Checked='" + RadioButtonList1.SelectedValue + "',PinShenDs='" + TextBox1.Text + "' where id=" + id);

            Alert.AlertAndRedirect("审核成功", "isshenheList.aspx");
        }
        else
        {
            data.RunSql("update  Lunwen set  Checked='" + RadioButtonList1.SelectedValue + "',PinShenDs='" + TextBox1.Text + "' where id=" + id);

  
            Alert.AlertAndRedirect("审核成功", "isshenheList.aspx");
        }
    }
}
