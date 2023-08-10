using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Cells;
using Aspose.Words;
using System.Data;
public partial class Admin_Import : System.Web.UI.Page
{
    SqlHelper DB = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnImport_Click(object sender, EventArgs e)
    {
        string IsXls = System.IO.Path.GetExtension(FileUpload1.FileName.ToString().ToLower());
        if (IsXls != ".xls")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script type='text/javascript' language='javascript'>alert('只可以选择Excel文件')</script>");
            return;//当选择的不是Excel文件时,返回
        }
        string str = DateTime.Now.ToString("yyyyMMddhhmmss");
        FileUpload1.SaveAs(Server.MapPath("../Import/" + str + FileUpload1.PostedFile.FileName));
        DataTable dt = new DataTable();
        dt = ExcelToDatatalbe(Server.MapPath("../Import/" + str + FileUpload1.PostedFile.FileName));
        string sql;


        if (DropDownList1.SelectedValue == "学生信息")
        {
            for (int i = 1; i < dt.Rows.Count; i++)
            {

                sql = "insert into Student(name,TNmuber,Sex,xueli,daoshi,Yjfx,Pwd) ";
                sql += "values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "','123456')";
                DB.RunSql(sql);
            }
        }
        else if (DropDownList1.SelectedValue == "教工信息")
        {
            for (int i = 1; i < dt.Rows.Count; i++)
            {

                sql = "insert into ZhuanJia(name,sex,gonghao,leixing,zhicheng,Yjfx,Pwd) ";
                sql += "values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "','" + dt.Rows[i][6].ToString() + "')";
                DB.RunSql(sql);
            }
        }
        else if (DropDownList1.SelectedValue == "教室管理员")
        {
            for (int i = 1; i < dt.Rows.Count; i++)
            {

                sql = "insert into JiaosShiGly ";
                sql += "values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "')";
                DB.RunSql(sql);
            }
        }
      




        Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script type='text/javascript' language='javascript'>alert('导入成功')</script>");


    }

    public DataTable ExcelToDatatalbe(string fullFilename)//导入
    {
        Workbook book = new Workbook();
        book.Open(fullFilename);
        Worksheet sheet = book.Worksheets[0];
        Cells cells = sheet.Cells;
        //获取excel中的数据保存到一个datatable中
        DataTable dt_Import = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, false);
        // dt_Import.

        return dt_Import;
    }
}