<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FenPeiManger.aspx.cs" Inherits="Admin_FenPeiManger"  EnableEventValidation="false" ValidateRequest="false" %>

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
                                    答辩意见稿<br />
                              
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
                    <asp:Button ID="Button2" runat="server" Height="36px" onclick="Button2_Click" 
                        Text="下载" Width="114px" />
                    <br />
                    开题征求意见方案：<br />
                    &nbsp;<asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
                        <ItemTemplate>
                            <table align="center" border="1" cellpadding="0" cellspacing="0" style="width: 100%;
                                padding-left: 10px">
                                <tr>
                                    <td nowrap="nowrap" colspan="2" style="width: 260px; height: 32px;">
                                        <%#Eval("zm") %>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        学生组：
                                    </td>
                                    <td style="height: 32px">
                                        <%#xsz(Eval("zm").ToString())%>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        <div align="left">
                                            答辩评委：</div>
                                    </td>
                                    <td style="height: 32px">
                                        <div align="left">
                                            <%#dbpw(Eval("zm").ToString())%>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        开题导师：
                                    </td>
                                    <td style="height: 32px">
                                        <%#ktds(Eval("zm").ToString())%>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        答辩时间：
                                    </td>
                                    <td style="height: 32px">
                                        <%#Eval("addtime").ToString()%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" height="40">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td valign="middle" background="../images/mail_leftbg.gif">
                </td>
                <td valign="top" bgcolor="#F7F8F9" style="font-family: 黑体; font-size: large; font-weight: bold;
                    font-style: normal;">
                    <br />
                    预答辩征求意见方案：<br />
                    &nbsp;<asp:DataList ID="DataList2" runat="server" RepeatColumns="3">
                        <ItemTemplate>
                            <table align="center" border="1" cellpadding="0" cellspacing="0" style="width: 100%;
                                padding-left: 10px">
                                <tr>
                                    <td nowrap="nowrap" colspan="2" style="width: 260px; height: 32px;">
                                        <%#Eval("zm") %>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        学生组：
                                    </td>
                                    <td style="height: 32px">
                                        <%#xsz(Eval("zm").ToString())%>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        <div align="left">
                                            答辩评委：</div>
                                    </td>
                                    <td style="height: 32px">
                                        <div align="left">
                                            <%#ydbpw(Eval("zm").ToString())%>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        开题导师：
                                    </td>
                                    <td style="height: 32px">
                                        <%#ktds(Eval("zm").ToString())%>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        答辩时间：
                                    </td>
                                    <td style="height: 32px">
                                        <%#Eval("addtime").ToString()%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" height="40">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td valign="middle" background="../images/mail_leftbg.gif">
                </td>
                <td valign="top" bgcolor="#F7F8F9" style="font-family: 黑体; font-size: large; font-weight: bold;
                    font-style: normal;">
                    <br />
                    答辩征求意见方案：<br />
                    &nbsp;<asp:DataList ID="DataList3" runat="server" RepeatColumns="3">
                        <ItemTemplate>
                            <table align="center" border="1" cellpadding="0" cellspacing="0" style="width: 100%;
                                padding-left: 10px">
                                <tr>
                                    <td nowrap="nowrap" colspan="2" style="width: 260px; height: 32px;">
                                        <%#Eval("zm") %>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        学生组：
                                    </td>
                                    <td style="height: 32px">
                                        <%#xsz(Eval("zm").ToString())%>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        <div align="left">
                                            答辩评委：</div>
                                    </td>
                                    <td style="height: 32px">
                                        <div align="left">
                                            <%#ddbpw(Eval("zm").ToString())%>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td nowrap="nowrap" style="width: 99px; height: 32px">
                                        答辩时间：
                                    </td>
                                    <td style="height: 32px">
                                        <%#Eval("addtime").ToString()%>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" height="40">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    <br />
                    选择意见：<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>通过</asp:ListItem>
                        <asp:ListItem>不通过</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click1" />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
