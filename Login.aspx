<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>欢迎使用学生答辩排程管理系统</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"><style type="text/css">
<!--
body,td,th {
	font-family: 宋体;
	font-size: 12px;
	color: #000000;
}
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
a {
	font-family: 宋体;
	font-size: 12px;
	color: #000000;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #000000;
}
a:hover {
	text-decoration: none;
	color: #000000;
}
a:active {
	text-decoration: none;
	color: #000000;
}
                                                                       .style1
                                                                       {
                                                                           width: 479px;
                                                                           height: 361px;
                                                                       }
                                                                       .style2
                                                                       {
                                                                           height: 68px;
                                                                           width: 476px;
                                                                       }
                                                                       .style3
                                                                       {
                                                                           width: 476px;
                                                                       }
                                                                       .style4
                                                                       {
                                                                           height: 19px;
                                                                           width: 476px;
                                                                       }
                                                                       .style5
                                                                       {
                                                                           height: 22px;
                                                                           width: 476px;
                                                                       }
-->
</style></head>
<body style="background-color: lightgrey">
      <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      
      <table border="0" align="center" cellpadding="0" cellspacing="0" 
            style="width: 354px; height: 179px; background-image: url('images/InfoDiv.gif');">
        <tr align="left" valign="top">
          <td width="388"><table border="0" cellpadding="0" cellspacing="0" class="style1" style="width: 422px; height: 248px">
              <tr>
                  <td style="font-size: 30px; color: #006666;" align="center" class="style2">
                      </td>
              </tr>
            <tr>
              <td align="center" class="style4"><div align="center">
                  <asp:Label ID="Label1" runat="server" Text="用户账号："></asp:Label>&nbsp;
                  <asp:TextBox ID="UserName" runat="server" Height="14px" Width="130px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="UserName" ErrorMessage="*"></asp:RequiredFieldValidator>
              </div></td>
            </tr>
            <tr>
              <td class="style3">&nbsp;</td>
            </tr>
            <tr>
              <td class="style5"><div align="center">
                  <asp:Label ID="Label2" runat="server" Text="登录密码："></asp:Label>&nbsp;
                  <asp:TextBox ID="PassWord" runat="server" Height="14px" TextMode="Password" Width="130px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="PassWord" ErrorMessage="*"></asp:RequiredFieldValidator>
              </div></td>
            </tr>
              <tr>
                  <td class="style3">
                      &nbsp;</td>
              </tr>
              <tr>
                  <td align="center" class="style3">
                      <asp:Label ID="Label3" runat="server" Text="用户角色："></asp:Label>
                      &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="144px">
                          <asp:ListItem>管理员</asp:ListItem>
                          <asp:ListItem>学生</asp:ListItem>
                          <asp:ListItem>教师</asp:ListItem>
                                 <asp:ListItem>教室管理员</asp:ListItem>
                      </asp:DropDownList></td>
              </tr>
            <tr>
              <td class="style3" align="center">
                  <asp:Button ID="btn_Login" runat="server" Text="登　录" OnClick="btn_Login_Click" CausesValidation="False" />&nbsp;
                </td>
            </tr>
            <tr>
              <td class="style3"></td>
            </tr>
          </table></td>
        </tr>
      </table>
    
   
    </div>
    </form>
</body>
</html>
