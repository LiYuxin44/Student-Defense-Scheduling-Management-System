<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Js.aspx.cs" Inherits="Admin_AdminManger" %>

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
    <link href="../Style/skin.css" rel="stylesheet" type="text/css" />      <link href="../Style/style.css" rel="stylesheet" type="text/css" />
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
            教室审核</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
  <td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif" style="height: 18px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9" style="height: 18px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="zm" RowStyle-HorizontalAlign="Center"
            OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting"
            OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
            Width="100%" EnableModelValidation="True">
            <Columns>
                <asp:TemplateField HeaderText="编号">
                    <ItemTemplate>
                       <%#Container.DataItemIndex+1%>
                    </ItemTemplate>
                </asp:TemplateField>
                               <asp:TemplateField HeaderText="分组名称">
                    <ItemTemplate>
                       <%#Eval("zm")%>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="教室名称">
            
                    <ItemTemplate>
                        <asp:Label ID="js" runat="server"><%# Eval("js")%></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="审核状态">
                             <EditItemTemplate>
                     <asp:DropDownList ID="DropDownList1" Width="150px" runat="server" >
           <asp:ListItem>通过</asp:ListItem>
           <asp:ListItem>不通过</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                       <%#Eval("zt")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="审核" ShowEditButton="True" />
           
            </Columns>
           <HeaderStyle CssClass="ct" />
        </asp:GridView>
        <asp:Label ID="Label4" runat="server"></asp:Label></td>
    <td background="../images/mail_rightbg.gif" style="height: 18px">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif" align="center"><img src="../images/buttom_bgs.gif" width="17" height="17">
    
       
    </td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
