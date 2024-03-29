﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs"
    EnableEventValidation="false" Inherits="MTCSYT.PasswordChange" MasterPageFile="~/MasterPage/MasterPageMTCSYT.master"
    Culture="auto"  UICulture="auto" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>
<asp:Content ContentPlaceHolderID="Category" ID="Content1" runat="server">
   <script type="text/javascript">
       function CheckValie(s, e) {
           if (e.value == null)
               return;
       }
    </script>
      <table width="100%">
     <tr>
            <td colspan="3" valign="middle">     
                         <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/home.png" ImageAlign="TextTop"  />&nbsp;
                             <dxe:ASPxHyperLink
                                 ID="ASPxHyperLink1" runat="server" Text="Trang chủ" 
                             ForeColor="#24A3D6" NavigateUrl="~/Default.aspx">
                             </dxe:ASPxHyperLink>
                         &nbsp;<asp:Label ID="Label1" runat="server" Text="&raquo;" Font-Underline="False" />    
                         <dxe:ASPxHyperLink
                                 ID="ASPxHyperLink2" runat="server" Text="Thông tin cá nhân" 
                             ForeColor="#24A3D6" NavigateUrl="~/SYS/PersonalInformation.aspx">
                             </dxe:ASPxHyperLink>
                         &nbsp;<asp:Label ID="Label5" runat="server" Text="&raquo;" Font-Underline="False" />       
                         &nbsp;<asp:Label ID="Label4" runat="server" Text="Đổi mật khẩu" 
                             /> 
             
             </td>
          </tr>  
           <tr >
            <td colspan="3" >       
                <div style="border-top:solid 1px #EEEEEE; margin-top:5px;"></div>      
            </td> 
            </tr>      
          <tr>
            <td colspan="3">
                <div style="font-weight:bold;font-size:medium;width:97%; margin-left:5px; margin-top:5px;"> 
            <p style="font-size:20px;">
                <asp:Label ID="Label3" runat="server" 
                     Text="ĐỔI MẬT KHẨU"/></p>
           <p style="font-size:small;font-weight:normal">&nbsp;&nbsp;&nbsp;<span style="color:Red; text-decoration: underline;"><asp:Label ID="Label2" runat="server"  Text="Ghi chú:"/></span>&nbsp;<dxe:ASPxLabel 
                   ID="Label22" runat="server" Text="Nhập đầy đủ các thông tin"></dxe:ASPxLabel></p>   
          </div>
            </td>
          </tr>   
          <tr >
            <td colspan="3" >       
                <div style="border-top:solid 1px #EEEEEE; margin-top:5px;"></div>      
            </td> 
            </tr>               
    </table>
    <table width="1024px">
        <tr>
            <td class="style3" align="right">
                <dxe:ASPxLabel ID="ASPxLabel3" runat="server" 
                    Text="Tên Đăng Nhập :            ">
                </dxe:ASPxLabel>
            </td>
            <td class="style4">
            </td>
            <td class="style5" align="left" colspan="2">
                <dxe:ASPxLabel ID="lbUserName" runat="server" Text="">
                </dxe:ASPxLabel>
            </td>
            <tr>
                <td class="style3" align="right">
                    <dxe:ASPxLabel ID="ASPxLabel8" runat="server" Text="Mật Khẩu :                ">
                    </dxe:ASPxLabel>
                </td>
                <td class="style4">
                </td>
                <td class="style5" align="left" width="18%">
                    <dxe:ASPxTextBox ID="txtPassword" runat="server" Width="170px" Password="True">                    
                    </dxe:ASPxTextBox>
                </td>
                <td>
                    <dxe:ASPxLabel ID="ASPxLabel14" runat="server" Font-Italic="True" Font-Size="X-Small"
                        Text="(Bạn không được để trống)">
                    </dxe:ASPxLabel>
                </td>
            </tr>
            <td class="style3" align="right">
                <dxe:ASPxLabel ID="ASPxLabel9" runat="server" Text="Mật Khẩu Mới :            ">
                </dxe:ASPxLabel>
            </td>
            <td class="style4">
            </td>
            <td class="style5" align="left">
                <dxe:ASPxTextBox ID="txtPassWordNew" runat="server" Width="170px" Password="True">                 
                </dxe:ASPxTextBox>
            </td>
            <td>
                <dxe:ASPxLabel ID="ASPxLabel1" runat="server" Font-Italic="True" Font-Size="X-Small"
                    Text="(Bạn không được để trống)">
                </dxe:ASPxLabel>
            </td>
            <tr>
                <td class="style3" align="right">
               $    <dxe:ASPxLabel ID="ASPxLabel10" runat="server" Text="Gõ Lại Mật Khẩu Mới :">
                    </dxe:ASPxLabel>
                </td>
                <td class="style4">
                </td>
                <td class="style5" align="left">
                    <dxe:ASPxTextBox ID="txtRetypeNewPassword" runat="server" Width="170px" Password="True">
                        <ValidationSettings SetFocusOnError="True">
                            <RequiredField IsRequired="True" />
                            <RegularExpression ValidationExpression=".{2,}" />
                            <RegularExpression ValidationExpression=".{2,}"></RegularExpression>
                            <RequiredField IsRequired="True"></RequiredField>
                        </ValidationSettings>
                        <FocusedStyle>
                            <Border BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                            <Border BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></Border>
                        </FocusedStyle>
                        <InvalidStyle BackColor="#FFF5F5">
                            <Border BorderColor="Red" BorderStyle="Solid" BorderWidth="1px" />
                            <Border BorderColor="Red" BorderStyle="Solid" BorderWidth="1px"></Border>
                        </InvalidStyle>
                        <ClientSideEvents Validation="CheckValie"></ClientSideEvents>
                    </dxe:ASPxTextBox>
                </td>
                <td>
                    <dxe:ASPxLabel ID="ASPxLabel4" runat="server" Font-Italic="True" Font-Size="X-Small"
                        Text="(Bạn không được để trống)">
                    </dxe:ASPxLabel>
                </td>
            </tr>
    </table>
    <div style="width: 1024px; margin-top: 20px; margin-bottom: 10px; height: 49px;" 
        align="right">
        <span style="float: right; padding-right: 20px">
            <dxe:ASPxButton ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"
                Width="100px">
            </dxe:ASPxButton>
        </span>
    </div>
</asp:Content>
<%--<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .style3
        {
            width: 199px;
            height: 44px;
        }
        .style4
        {
            width: 77px;
            height: 44px;
        }
        .style5
        {
            height: 44px;
        }
    </style>
</asp:Content>--%>
