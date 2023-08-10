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

public partial class Student_Addlunwen : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert js = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Literal1.Text = Session["daoshi"].ToString();
            Literal2.Text = Session["yjfx"].ToString();
            StudentName.Text = Session["Student"].ToString();
            
            KeTiBianHao.Text = System.DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        string Sname = txtTitle.Text;
 
        string SStudent = Session["Student"].ToString();
        string lunwenInfo = txtlunwenInfo.Text;

        data.RunSql("insert into Lunwen(Name,Student,lunwen,KeTiBianHao,KeTiLeiXing,daoshi) values('" + Sname + "','" + SStudent + "','" + lunwenInfo + "','" + KeTiBianHao.Text + "','" + Literal2.Text + "','" + Literal1.Text + "')");

       Alert.AlertAndRedirect(" 添加成功", "Addlunwen.aspx");
    }
 

}
