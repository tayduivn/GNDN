﻿using System;
using System.Collections.Generic;
using DevExpress.Web;
using Entity;
using SystemManageService;
using System.Web.UI;
using System.Linq;
using System.Data;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web;
namespace MTCSYT
{
    public partial class dm_DiemDo_Cto : BasePage
    {
        CBDN.DB_CBDNDataContext db = new CBDN.DB_CBDNDataContext(new CBDN.ADOController().strcn());
        private SYS_Right rightOfUser = null;
        private const string funcid = "57";
        protected void Page_Load(object sender, EventArgs e)
        {
            #region PhanQuyen
            MTCSYT.SYS_Session session = (MTCSYT.SYS_Session)Session["SYS_Session"];
            if (session == null || session.User.USERNAME == "Guest")
            {
                Response.Redirect("~\\Login.aspx");
            }
            else
            {
                //if (Request.Cookies["IDUSER"].Value != "1")
                //{
                //    List<SYS_Right> right = session.User.Rights;
                //    foreach (SYS_Right sysRight in right)
                //    {
                //        if (sysRight.FuncId == funcid)
                //        {
                //            rightOfUser = sysRight;
                //            Session["Right"] = sysRight;
                //            Session["UserId"] = session.User.IDUSER;
                //            Session["FunctionId"] = sysRight.FuncId;
                //            break;
                //        }
                //    }

                //    if (rightOfUser == null)
                //    {
                //        Session["Status"] = "0";
                //        Response.Redirect("~\\HeThong\\Default.aspx");

                //    }
                //}
            }
            Session["SYS_Session"] = session;
            #endregion

            loadTram();

            _DataBind();
            _DataBidCongTo();

        }
        private void loadTram()
        {
            MTCSYT.SYS_Session session = (MTCSYT.SYS_Session)Session["SYS_Session"];
            var lstDD = db.DM_Trams.Where(x => x.IDMaDviQly.Contains(session.User.ma_dviqly + ""));
            tlDonVi.DataSource = lstDD;
            tlDonVi.DataBind();

            tlDonVi.ExpandAll();
        }

        private void _DataBind()
        {
            MTCSYT.SYS_Session session = (MTCSYT.SYS_Session)Session["SYS_Session"];
            if (tlDonVi.FocusedNode == null) return;
            var ddo = db.DM_DiemDoSelectByIDDVi(session.User.ma_dviqly + "").ToList().Where(x => x.IDTram == tlDonVi.FocusedNode.Key + "").ToList();
            if (ddo.Count > 0)
            {
                grdDiemDo.DataSource = ddo;
                grdDiemDo.DataBind();
                //  grdDiemDo.FocusedRowIndex = 0;
            }
            else
            {
                grdDiemDo.DataSource = null;
                grdDiemDo.DataBind();
            }

        }
        private void _DataBidCongTo()
        {
            if (grdDiemDo.FocusedRowIndex < 0)
                return;
            int index = grdDiemDo.FocusedRowIndex;
            CBDN.DM_DiemDoSelectByIDDViResult diemdo = (CBDN.DM_DiemDoSelectByIDDViResult)grdDiemDo.GetRow(grdDiemDo.FocusedRowIndex);
            MTCSYT.SYS_Session session = (MTCSYT.SYS_Session)Session["SYS_Session"];
            int ma_dviqly = int.Parse(session.User.ma_dviqly + "");
            if (int.Parse(tlDonVi.FocusedNode.Key) > 0)
            {
                var dmCongTo = db.DM_CongToSelectByIDDVi(session.User.ma_dviqly + "", diemdo.IDDiemDo + "").ToList();
                if (dmCongTo.Count > 0)
                {
                    grdDVT.DataSource = dmCongTo;
                    grdDVT.DataBind();
                }
                else
                {
                    grdDVT.DataSource = null;
                    grdDVT.DataBind();
                }

            }
        }
        protected void grdDVT_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "STT")
            {
                e.DisplayText = (e.VisibleRowIndex + 1).ToString();
            }
        }

        protected void grdDVT_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {

        }


        private bool CheckName(string Name, string id)
        {
            SYS_Session session = (SYS_Session)Session["SYS_Session"];

            var dt = db.DM_DiemDos.SingleOrDefault(x => x.MaDiemDo == Name && x.IDMaDViQly.Contains(session.User.ma_dviqly) && x.IDTram != id);
            if (dt != null)
                return false;
            return true;
        }

        protected void grdDVT_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            e.Column.ToString();
            if (e.Column.FieldName == "IDDiemDo")
                e.Editor.Focus();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            pcAddRoles.ShowOnPageLoad = true;
            Session["Add"] = 1;
        }

        protected void grdDVT_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            (sender as ASPxGridView).GetRowValuesByKeyValue(e.EditingKeyValue);

        }

        protected void grdDVT_CellEditorInitialize1(object sender, ASPxGridViewEditorEventArgs e)
        {

        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            pcAddRoles.ShowOnPageLoad = true;
            Session["Add"] = 0;
            SYS_Session session = (SYS_Session)Session["SYS_Session"];
            CBDN.DM_DiemDoSelectByIDDViResult cv = (CBDN.DM_DiemDoSelectByIDDViResult)grdDVT.GetRow(grdDVT.FocusedRowIndex);
            txtMaDuongDat.Text = cv.MaDiemDo;
            txtTenDuongDay.Text = cv.TenDiemDo;
            cmbLoaiDD.Value = cv.ISLoaiDD;
            cmbTinhChat.Value = cv.TinhChatDD;
            cmbTinhChat.Text = cv.strTinhChat;
            if (cv.HoatDong == 1)
                CkHoatDong.Checked = true;
            else
                CkHoatDong.Checked = false;
            txtmoTa.Text = cv.MoTa;
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            SYS_Session session = (SYS_Session)Session["SYS_Session"];

            if (txtMaDuongDat.Text + "" == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Mã Điểm đo không được để trống');", true);
                txtMaDuongDat.Focus(); return;
            }
            if (txtTenDuongDay.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Tên Điểm đo không được để trống');", true);
                txtTenDuongDay.Focus(); return;
            }


            if (Session["Add"] + "" == "0")
            {
                CBDN.DM_DiemDoSelectByIDDViResult cv = (CBDN.DM_DiemDoSelectByIDDViResult)grdDVT.GetRow(grdDVT.FocusedRowIndex);
                //var lst = db.DM_DiemDos.Where(x => x.MaDiemDo == cv.MaDiemDo && x.MaDviNhap == int.Parse(session.User.ma_dviqly) && x.IDTram == cv.IDTram && x.IDChiNhanh == cv.IDChiNhanh).ToList();
                CBDN.DM_DiemDo qtCT = db.DM_DiemDos.SingleOrDefault(x => x.IDDiemDo == cv.IDDiemDo);
                //foreach (var qtCT in lst)
                //{
                if (!CheckName(txtMaDuongDat.Text, cv.MaDiemDo))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Mã Điểm đo không được trùng');", true); return;
                }


                //CBDN.DM_DiemDo qtCT = new CBDN.DM_DiemDo();
                qtCT.MaDiemDo = txtMaDuongDat.Text;
                qtCT.TinhChatDD = int.Parse(cmbTinhChat.Value + "");
                qtCT.ISLoaiDD = int.Parse(cmbLoaiDD.Value + "");
                qtCT.TenDiemDo = txtTenDuongDay.Text;
                qtCT.MoTa = txtmoTa.Text;
                if (CkHoatDong.Checked)
                    qtCT.HoatDong = 1;
                else
                    qtCT.HoatDong = 0;
                db.SubmitChanges();
                //}


            }
            else
            {
                if (!CheckName(txtMaDuongDat.Text, ""))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Mã Điểm đo không được trùng');", true); return;
                }
                var tr = db.DM_Trams.SingleOrDefault(x => x.IDTram == int.Parse(tlDonVi.FocusedNode.Key + "") && x.IDMaDviQly.Contains("," + session.User.ma_dviqly + ","));
                //var lst = db.DM_Trams.Where(x => x.MaTram == cmbTram.Value + "" && x.MaDVNhap == int.Parse(session.User.ma_dviqly)).ToList();
                //foreach (var tr in lst)
                //{
                CBDN.DM_DiemDo cv = new CBDN.DM_DiemDo();
                cv.MaDiemDo = txtMaDuongDat.Text;
                cv.IDMaDViQly = tr.IDMaDviQly;
                cv.TenDiemDo = txtTenDuongDay.Text;
                cv.MoTa = txtmoTa.Text;
                cv.IDChiNhanh = tr.IDChiNhanh;
                cv.IDTram = tr.IDTram + "";
                cv.TinhChatDD = int.Parse(cmbTinhChat.Value + "");
                cv.ISLoaiDD = int.Parse(cmbLoaiDD.Value + "");
                if (CkHoatDong.Checked)
                    cv.HoatDong = 1;
                else
                    cv.HoatDong = 0;
                cv.MaDviNhap = int.Parse(session.User.ma_dviqly);
                db.DM_DiemDos.InsertOnSubmit(cv);
                db.SubmitChanges();
                //}


            }
            _DataBind();
            pcAddRoles.ShowOnPageLoad = false;
        }

        protected void btnDong_Click(object sender, EventArgs e)
        {
            pcAddRoles.ShowOnPageLoad = false;
        }

        protected void cmbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DataBind();
        }

        protected void grdDVT_HtmlCommandCellPrepared(object sender, ASPxGridViewTableCommandCellEventArgs e)
        {

        }

        protected void btnThemCongTo_Click(object sender, EventArgs e)
        {

        }

        protected void tlDonVi_CustomCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs e)
        {

        }

        protected void TreeListOrganization_CustomDataCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomDataCallbackEventArgs e)
        {

        }

        protected void TreeListOrganization_HtmlCommandCellPrepared(object sender, DevExpress.Web.ASPxTreeList.TreeListHtmlCommandCellEventArgs e)
        {

        }

        protected void tlDonVi_NodeDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                SYS_Session session = (SYS_Session)Session["SYS_Session"];
                //CBDN.DM_DiemDoSelectByIDDViResult HoatDong = (CBDN.DM_DiemDoSelectByIDDViResult)grdDVT.GetRow(grdDVT.FocusedRowIndex);

                CBDN.DM_DiemDo cv = new CBDN.DM_DiemDo();
                cv = db.DM_DiemDos.SingleOrDefault(x => x.IDDiemDo == int.Parse(tlDonVi.FocusedNode.Key));
                if (cv.MaDviNhap != int.Parse(session.User.ma_dviqly))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Không thể xóa giao nhận này vì không phải đơn vị bạn tạo ra');", true);
                    return;
                }
                db.DM_DiemDos.DeleteOnSubmit(cv);
                db.SubmitChanges();
                _DataBind();
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Xoá người phụ trách thành công');", true);
            }
            catch (Exception ex)
            { }
            finally
            {
                e.Cancel = true;
            }
        }

        protected void grdDVT_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void grdDVT_CustomDataCallback(object sender, ASPxGridViewCustomDataCallbackEventArgs e)
        {

        }

        protected void grdDVT_FocusedRowChanged(object sender, EventArgs e)
        {

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {

        }

        protected void tlDonVi_FocusedNodeChanged(object sender, EventArgs e)
        {
            // _DataBind();
        }

        protected void grdDiemDo_FocusedRowChanged(object sender, EventArgs e)
        {
            // _DataBidCongTo();
        }

    }
}