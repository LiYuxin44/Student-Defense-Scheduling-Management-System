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

public partial class AddJs : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string name = txtUser.Text.Trim();
   


        if (name.Length < 1)
        {

            alert.Alertjs("教室名称长度不能小于1位");

            return;
        }

        data.RunSql("insert into js(name)values('" + txtUser.Text + "')");
        Label4.Text = "添加成功！";
        txtUser.Text = "";
      
    }
}
