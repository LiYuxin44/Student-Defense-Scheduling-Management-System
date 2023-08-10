<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lunwenInfo.aspx.cs" Inherits="Student_lunwenInfo" %>

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
        <td height="31"><div class="titlebt">课题内容</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 100%"><tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    课题编号：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:TextBox ID="KeTiBianHao" runat="server" Width="176px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="KeTiBianHao"
                        ErrorMessage="*"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    <div align="left">
                        课题名称：</div>
                </td>
                <td class="STYLE1" style="height: 32px">
                    <div align="left">
                        &nbsp;<asp:TextBox ID="txtTitle" runat="server" ReadOnly="True" Width="428px"></asp:TextBox>
                    </div>
                </td>
            </tr>   
             <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    学生姓名：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:TextBox ID="StudentName" runat="server" Width="176px"></asp:TextBox></td>
            </tr>
                        <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    导师姓名：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    研究方向：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:TextBox ID="KeTiLeiXing" runat="server" Width="176px"></asp:TextBox></td>
            </tr>
      
            <tr>
                <td class="STYLE1" style="width: 99px; height: 139px">
                    <div align="center" nowrap="nowrap">
                        <div align="left">
                            课题详情：</div>
                    </div>
                </td>
                <td class="STYLE1" style="height: 139px">
                    <div align="left">
                        <asp:TextBox ID="txtlunwenInfo" runat="server" Height="174px" ReadOnly="True" TextMode="MultiLine"
                            Width="793px"></asp:TextBox>&nbsp;</div>
                </td>
                <td class="STYLE1" colspan="1" style="height: 139px">
                </td>
            </tr>
            <tr>
                <td class="STYLE1" style="width: 99px; height: 31px">
                </td>
                <td class="STYLE1" style="height: 31px">
                </td>
                <td class="STYLE1" colspan="1" style="height: 31px">
                </td>
            </tr>
            <tr>
                <td align="center" class="STYLE1" colspan="2" height="40">
                    &nbsp;&nbsp;</td>
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
