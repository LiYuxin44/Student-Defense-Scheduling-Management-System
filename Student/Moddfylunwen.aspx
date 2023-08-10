<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Moddfylunwen.aspx.cs" Inherits="Student_Moddfylunwen" %>

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
                        <input id="Hidden2" runat="server" type="hidden" />
                        <input id="Hidden1" runat="server" type="hidden" />
    <div>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">修改课题</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 100%">               <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    课题编号：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:TextBox ID="KeTiBianHao" runat="server" Width="176px" ReadOnly="True"></asp:TextBox>
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
                        &nbsp;<asp:TextBox ID="txtTitle" runat="server" Width="428px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="*"></asp:RequiredFieldValidator></div>
                </td>
            </tr>

            
            <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    研究方向：</td>
                <td class="STYLE1" style="height: 32px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>金融工程与风险管理</asp:ListItem>
                        <asp:ListItem>运营与供应链</asp:ListItem>
                        <asp:ListItem>大数据与智能决策</asp:ListItem>
                        <asp:ListItem>服务科学与服务管理中心</asp:ListItem>
                        <asp:ListItem>管理决策与优化</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>

            
            <tr>
                <td class="STYLE1" nowrap="nowrap" style="width: 99px; height: 32px">
                    &nbsp;</td>
                <td class="STYLE1" style="height: 32px">
                    &nbsp;</td>
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
                        <asp:TextBox ID="txtlunwenInfo" runat="server" Height="174px" TextMode="MultiLine"
                            Width="793px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                                runat="server" ControlToValidate="txtlunwenInfo" ErrorMessage="*"></asp:RequiredFieldValidator>&nbsp;</div>
                </td>
                <td class="STYLE1" colspan="1" style="height: 139px">
                </td>
            </tr>
            <tr>
                <td align="center" class="STYLE1" colspan="2" height="40">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="修改" />
                    &nbsp;</td>
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
