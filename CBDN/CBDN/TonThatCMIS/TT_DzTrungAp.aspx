﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage/MasterPageMTCSYT.Master"
    CodeBehind="TT_DzTrungAp.aspx.cs" Inherits="MTCSYT.TT_DzTrungAp" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>





<%--<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxp" %>--%>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
        <h4 class="page-title">Biểu số lượng đường dây trung áp</h4>
    </div>
    <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
        <ol class="breadcrumb">
            <li><a href="../Default.aspx">Trang chủ</a></li>
            <li><a href="TT_TBA.aspx">Tổn thất điện năng CMIS</a></li>
            <li><a href="TT_TBA.aspx">Biểu số lượng đường dây trung áp </a></li>
        </ol>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Category" runat="server">
    <div class="col-md-12">

        <div class="white-box">

            <h1 class="m-b-0 box-title">BIỂU SỐ LƯỢNG ĐƯỜNG DÂY TRUNG ÁP</h1>
            <div class="col-lg-12 m-t-30">
                <hr />
            </div>
            <table>
                <tr>
                    <td>
                        <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Lọc dữ liệu" Theme="Aqua">
                            <PanelCollection>
                                <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                                    <table>
                                        <tr>
                                            <td align="right">
                                                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Chọn lần báo cáo" Width="100px">
                                                </dx:ASPxLabel>
                                            </td>
                                            <td>
                                                <dx:ASPxComboBox ID="cmbLanBC" runat="server" Width="120px" SelectedIndex="0">
                                                    <Items>
                                                        <dx:ListEditItem Text="Phân tích" Value="PT" Selected="True" />
                                                        <dx:ListEditItem Text="Ngày mồng 1" Value="N1" />
                                                    </Items>
                                                </dx:ASPxComboBox>
                                            </td>
                                            <td>

                                                <asp:CheckBox ID="ckLuyKe" Text="Lựa chọn lũy kế" runat="server" />

                                            </td>
                                            <td align="right">
                                                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Tháng" Width="100px">
                                                </dx:ASPxLabel>
                                            </td>
                                            <td>
                                                <dx:ASPxComboBox ID="cmbThang" runat="server" Width="80px">
                                                    <Items>
                                                        <dx:ListEditItem Text="1" Value="1" />
                                                        <dx:ListEditItem Text="2" Value="2" />
                                                        <dx:ListEditItem Text="3" Value="3" />
                                                        <dx:ListEditItem Text="4" Value="4" />
                                                        <dx:ListEditItem Text="5" Value="5" />
                                                        <dx:ListEditItem Text="6" Value="6" />
                                                        <dx:ListEditItem Text="7" Value="7" />
                                                        <dx:ListEditItem Text="8" Value="8" />
                                                        <dx:ListEditItem Text="9" Value="9" />
                                                        <dx:ListEditItem Text="10" Value="10" />
                                                        <dx:ListEditItem Text="11" Value="11" />
                                                        <dx:ListEditItem Text="12" Value="12" />
                                                    </Items>
                                                </dx:ASPxComboBox>
                                            </td>

                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Năm" Width="100px">
                                                </dx:ASPxLabel>
                                            </td>
                                            <td>
                                                <dx:ASPxComboBox ID="cmbNam" runat="server" Width="80px">
                                                    <Items>
                                                        <dx:ListEditItem Text="2016" Value="2016" />
                                                        <dx:ListEditItem Text="2017" Value="2017" />
                                                        <dx:ListEditItem Text="2018" Value="2018" />
                                                        <dx:ListEditItem Text="2019" Value="2019" />
                                                        <dx:ListEditItem Text="2020" Value="2020" />
                                                        <dx:ListEditItem Text="2021" Value="2021" />
                                                        <dx:ListEditItem Text="2022" Value="2022" />
                                                        <dx:ListEditItem Text="2023" Value="2023" />
                                                        <dx:ListEditItem Text="2024" Value="2024" />
                                                        <dx:ListEditItem Text="2025" Value="2025" />
                                                    </Items>
                                                </dx:ASPxComboBox>

                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnXuat" runat="server" Text="In báo cáo" Width="120px" Theme="Aqua" OnClick="btnXuat_Click">
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnLoc" runat="server" Text="Lọc" Width="120px" Theme="Aqua" OnClick="btnLoc_Click">
                                                </dx:ASPxButton>
                                            </td>
                                        </tr>
                                    </table>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxRoundPanel>
                    </td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td width="100%" valign="Top">
                        <dx:ASPxGridView runat="server" AutoGenerateColumns="False" ID="grdDVT"
                            KeyFieldName="MA_DVIQLY" OnHtmlCommandCellPrepared="grdDVT_HtmlCommandCellPrepared" Caption="Biểu số lượng đường dây trung áp có tỷ lệ TTĐN theo mức (%)"
                            OnCellEditorInitialize="grdDVT_CellEditorInitialize1" OnCustomColumnDisplayText="grdDVT_CustomColumnDisplayText" ClientIDMode="AutoID" Theme="Aqua" Width="100%">
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="TEN_DVIQLY" Caption="Đơn vị" Width="220px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewBandColumn Caption="Tỷ lệ TTĐN các đường dây trung áp (số đường dây)">
                                    <Columns>
                                        <dx:GridViewDataTextColumn FieldName="SO_LDD_LESS2" Caption="&lt;2%" VisibleIndex="0" />
                                        <dx:GridViewDataTextColumn Caption="2%-3%" FieldName="SO_LDD_LESS3" VisibleIndex="1">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="3%-4%" VisibleIndex="2" FieldName="SO_LDD_LESS4">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="4%-5%" VisibleIndex="3" FieldName="SO_LDD_LESS5">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="5%-6%" VisibleIndex="4" FieldName="SO_LDD_LESS6">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="&gt;=6%" VisibleIndex="5" FieldName="SO_LDD_MORE6">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Tổng số đường dây" VisibleIndex="6">
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <HeaderStyle Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                                </dx:GridViewBandColumn>
                            </Columns>
                            <SettingsPager PageSize="20">
                                <Summary Text="Trang {0} của {1} ({2} bản ghi)" />
                            </SettingsPager>
                            <TotalSummary>              
                                  <dx:ASPxSummaryItem FieldName="TEN_DVIQLY" SummaryType="Sum" DisplayFormat="Tổng" />                  
                                    <dx:ASPxSummaryItem FieldName="SO_LDD_LESS2" SummaryType="Sum" DisplayFormat=" {0}" />
                                    <dx:ASPxSummaryItem FieldName="SO_LDD_LESS3" SummaryType="Sum" DisplayFormat=" {0}" />
                                    <dx:ASPxSummaryItem FieldName="SO_LDD_LESS4" SummaryType="Sum" DisplayFormat=" {0}" />
                                 <dx:ASPxSummaryItem FieldName="SO_LDD_LESS5" SummaryType="Sum" DisplayFormat=" {0}" />
                                 <dx:ASPxSummaryItem FieldName="SO_LDD_LESS6" SummaryType="Sum" DisplayFormat=" {0}" />
                                 <dx:ASPxSummaryItem FieldName="SO_LDD_MORE6" SummaryType="Sum" DisplayFormat=" {0}" />
                            </TotalSummary>
                            <Settings ShowFooter="True" ShowFilterRow="True" ShowFilterRowMenu="True" />
                            <SettingsBehavior AllowFocusedRow="True" />
                            <Settings GridLines="None" />
                            <TotalSummary>
                                <dx:ASPxSummaryItem FieldName="IDCanBo" SummaryType="Count" />
                            </TotalSummary>
                            <SettingsText CommandCancel="Thoát" CommandDelete="Xóa" CommandEdit="Sửa" CommandNew="Thêm"
                                CommandUpdate="Cập Nhật" ConfirmDelete="Bạn Muốn Xóa Chứ ?" />
                        </dx:ASPxGridView>
                    </td>

                </tr>
            </table>

        </div>
    </div>
</asp:Content>
