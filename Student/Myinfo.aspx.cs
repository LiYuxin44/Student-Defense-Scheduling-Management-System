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
public partial class Student_Myinfo : System.Web.UI.Page
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
       
         
            GetArticle();
        }
    }

    private void GetArticle()
    {

        SqlDataReader dr;
        dr = data.GetDataReader("select * from  Student where  Name= '" + Session["Student"].ToString() + "' ");
        dr.Read();
        txtname.Text = dr["Name"].ToString();
        txtds.Text = dr["Ds"].ToString();
            DropDownList1.Items.FindByValue(dr["Sex"].ToString()).Selected = true;//选项Text

            try
            {
                DropDownList2.Items.FindByText(dr["XueLi"].ToString()).Selected = true;//选项Text  
                DropDownList2.Items.FindByText(dr["XueLi"].ToString()).Selected = true;//选项Text  
            }
            catch { }
   
        Literal1.Text = dr["daoshi"].ToString();
        Literal2.Text = dr["yjfx"].ToString();
        txtAge.Text = dr["UserAge"].ToString();
        txttime1.Value = dr["chushengriqi"].ToString();
        this.TNmuber.Text = dr["TNmuber"].ToString();

    }




    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        data.RunSql("update   Student set Name='" + txtname.Text + "',Ds='" + txtds.Text + "',Sex='" + DropDownList1.SelectedItem.Text + "', XueLi='" + DropDownList2.SelectedItem.Text + "',UserAge='" + txtAge.Text + "',chushengriqi='" + txttime1.Value + "'  where  Name= '" + Session["Student"].ToString() + "'");

        Alert.AlertAndRedirect("修改成功！", "Myinfo.aspx");
    }
}
