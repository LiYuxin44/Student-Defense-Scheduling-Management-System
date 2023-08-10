<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_top.aspx.cs" Inherits="Admin_admin_top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../Style/skin.css" rel="stylesheet" type="text/css">
    <script language=JavaScript>
function logout(){
	if (confirm("您确定要退出控制面板吗？"))
	    top.location = "../Login.aspx";
	return false;
}
</script>

<script language=JavaScript1.2>
function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}
</script>
<meta http-equiv=Content-Type content=text/html;charset=gb2312>
<meta http-equiv="refresh" content="60">
<script language=JavaScript1.2>
function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" height="64" border="0" cellpadding="0" cellspacing="0" class="admin_topbg">
  <tr>
    <td width="61%" height="64" style="font-size: 25px">&nbsp;欢迎使用学生答辩排程管理系统</td>
    <td width="39%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="74%" height="38" class="admin_txt" style="color: #FFFFFF">
            &nbsp;<asp:Label ID="Label2" runat="server" ForeColor="Black" Text="当前登录用户："></asp:Label>
            <asp:Label ID="Label1" 
                runat="server" ForeColor="Red"></asp:Label></td>
        <td width="22%"><a href="#" target="_self" onClick="logout();"><img src="../images/out.gif" alt="安全退出" width="46" height="20" border="0"></a></td>
        <td width="4%">&nbsp;</td>
      </tr>
      <tr>
        <td height="19" colspan="3">&nbsp;</td>
        </tr>
    </table></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
