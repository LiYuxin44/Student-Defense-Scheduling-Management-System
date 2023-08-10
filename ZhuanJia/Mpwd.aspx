<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mpwd.aspx.cs" Inherits="ZhuanJia_Mpwd" %>

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
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            修改密码</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td align="center" class="STYLE1" colspan="4" height="40">
                    <table id="Table1" align="center" border="0" cellpadding="5" cellspacing="0" width="100%">
                        <tr>
                            <td style="width: 71px">
                                <font face="宋体">原密码：</font></td>
                            <td style="width: 245px">
                                <asp:TextBox ID="txtpwd1" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpwd1"
                                    ErrorMessage=" 必填"></asp:RequiredFieldValidator></td>
                            <td style="font-family: 宋体">
                                <font face="宋体"><font face="宋体">新密码：<asp:TextBox ID="txtpwd2" runat="server" TextMode="Password"
                                    Width="138px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd2"
                                        ErrorMessage=" 必填"></asp:RequiredFieldValidator>确认密码：<asp:TextBox ID="MiMa2" runat="server"
                                            TextMode="Password" Width="158px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                                runat="server" ControlToValidate="MiMa2" ErrorMessage="*"></asp:RequiredFieldValidator><asp:CompareValidator
                                                    ID="CompareValidator1" runat="server" ControlToCompare="txtpwd2" ControlToValidate="MiMa2"
                                                    ErrorMessage="密码不一致"></asp:CompareValidator></font></font></td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="4">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" />
                                <asp:Label ID="LabelWarningMessage" runat="server" ForeColor="Red"></asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
