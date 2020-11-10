﻿<%@ Page Title="Cấu Hình Tổn Thất" Language="C#" MasterPageFile="~/MasterPage/MasterPageMTCSYT.Master" AutoEventWireup="true"
    CodeBehind="DM_TTKinhDoanh_TRAM.aspx.cs" Inherits="CBDN.TonThatKyThuat.DM_TTKinhDoanh_TRAM"
    Culture="auto" UICulture="auto" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function CheckValie(s, e) {
            if (e.value == null)
                return;
        }
    </script>
    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
        <h4 class="page-title">Cấu Hình Tổn Thất</h4>
    </div>
    <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
        <ol class="breadcrumb">
            <li><a href="../Default.aspx">Trang chủ</a></li>
            <li><a href="bc_GiaoNhan2Chieu.aspx">Tổn thất online </a></li>
            <li><a href="DM_TTKinhDoanh.aspx">Danh Mục Cảnh Báo</a></li>
        </ol>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Category" runat="server">
    <div class="col-md-12">
        <div class="white-box">
            <h1 class="m-b-0 box-title">Cấu Hình Cảnh Báo Sản Lượng</h1>
            <div class="col-lg-12 m-t-30">
                <hr />
            </div>


            <table width="100%">

                <td>
                    <dx:ASPxRoundPanel ID="ASPxRoundPanel3" runat="server" HeaderText="THÔNG SỐ CẤU HÌNH" Theme="Aqua">
                        <PanelCollection>
                            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                                <table class="tbl_Write">
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Tỷ lệ tổn thất Trạm tăng giảm bắt thường vượt quá hoặc bằng ngưỡng" Width="200px">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td colspan="3">

                                            <dx:ASPxTextBox ID="txtTyLeBTram" runat="server" Width="170px" OnTextChanged="TextboxB_TextChanged" AutoPostBack="True">
                                            </dx:ASPxTextBox>

                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Tổn thất trạm vượt so mới mức" Width="200px">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td colspan="3">
                                            <dx:ASPxTextBox ID="txtTyLeTT" runat="server" Width="170px" OnTextChanged="TextboxC_TextChanged" AutoPostBack="True">
                                            </dx:ASPxTextBox>

                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Sản lượng trung bình tăng giảm bất thường" Width="200px">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td colspan="3">


                                            <dx:ASPxTextBox ID="txtTyLeBT" runat="server" Width="170px" OnTextChanged="TextboxA_TextChanged" AutoPostBack="True">
                                            </dx:ASPxTextBox>

                                        </td>

                                    </tr>

                                </table>
                            </dx:PanelContent>
                        </PanelCollection>
                    </dx:ASPxRoundPanel>
                </td>

            </table>

        </div>
    </div>
    <hr />
</asp:Content>
