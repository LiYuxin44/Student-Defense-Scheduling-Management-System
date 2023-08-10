<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Import.aspx.cs" Inherits="Admin_Import" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">





<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
-->
</style>
    <link href="../Style/skin.css" rel="stylesheet" type="text/css" />
    <link href="../Style/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form2" runat="server">
    <div >
        <table width="100%" border="0" cellpadding="0" cellspacing="0" >
            <tr>
                <td width="17" valign="top" background="../images/mail_leftbg.gif">
                    <img src="../images/left-top-right.gif" width="17" height="29" />
                </td>
                <td valign="top" >
                    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg"
                        id="table2">
                        <tr>
                            <td height="31" align="left">           <div class="titlebt">
                                    数据导入<br />
                              
                                </div>
                            </td>
                        </tr>
   
                    </table>
                </td>
                <td width="16" valign="top" background="../images/mail_rightbg.gif">
                    <img src="../images/nav-right-bg.gif" width="16" height="29" />
                </td>
            </tr>
            <tr>
                <td valign="middle" background="../images/mail_leftbg.gif">
                </td>
                <td valign="top" bgcolor="#F7F8F9" style="font-family: 黑体; font-size: large; font-weight: bold;
                    font-style: normal;">
            <div align="center">
        <table style="height: 436px">
            <tr>
                <td>
                    <br />
                    <br />
                    <br />
                    选择导入类型：<asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="id">
                    
                        <asp:ListItem>学生信息</asp:ListItem>
                        <asp:ListItem>教工信息</asp:ListItem>
                        <asp:ListItem>教室管理员</asp:ListItem>
                    

                    </asp:DropDownList>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:Button ID="btnImport" runat="server" Text="导入" OnClick="btnImport_Click" Style="width: 40px" />
                </td>
            </tr>
        </table>
    </div>
                </td>
            </tr>
            
        
        </table>
    </div>
    </form>
</body>
</html>



















