﻿using System;
using System.Collections.Generic;
using DevExpress.Web;
using Entity;
using SystemManageService;
using System.Web.UI;
using System.Linq;
using System.Data;
namespace MTCSYT
{
    public partial class dmLoaiDuongDay : BasePage
    {
        DataAccess.clTTTT db = new DataAccess.clTTTT();
       // CBDN.DB_CBDNDataContext db = new CBDN.DB_CBDNDataContext(new CBDN.ADOController().strcn());
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
            _DataBind();
        
        }
      
        private void _DataBind()
        {
            MTCSYT.SYS_Session session = (MTCSYT.SYS_Session)Session["SYS_Session"];
            grdDVT.DataSource = db.SELECT_ALLDUONGDAY(session.User.ma_dviqlyDN);
            grdDVT.DataBind();
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
            try
            {
                SYS_Session session = (SYS_Session)Session["SYS_Session"];
                var HoatDong = (DataRowView)grdDVT.GetRow(grdDVT.FocusedRowIndex);


                 db.DELETE_TTTT_DM_LOAIDUONGDAY(int.Parse(HoatDong["ID"]+""),session.User.ma_dviqlyDN);
               
                _DataBind();
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Xoá loại dây thành công');", true);
            }
            catch (Exception ex)
            { }
            finally
            {
                e.Cancel = true;
            }
        }


        private bool CheckName(string Name, int id)
        {
            SYS_Session session = (SYS_Session)Session["SYS_Session"];

            var dt = db.TTTT_DM_LOAIDUONGDAY_CHECKNAME(id,session.User.ma_dviqlyDN, Name);
            if (dt.Rows.Count>0)
                return false;
            return true;
        }

        protected void grdDVT_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            e.Column.ToString();
            if (e.Column.FieldName == "MaChiNhanh")
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
            var cv = (DataRowView)grdDVT.GetRow(grdDVT.FocusedRowIndex);
            txtDienTro.Text = cv["DienTroSuat"] + "";
            txtMaLoaiDay.Text =  cv["MaLoaiDay"]+ "";
            txtTenLoaiDay.Text =  cv["TenLoaiDay"]+ "";
            cmbLoaiDay.Value = cv["LoaiDay"] + "";
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            DM_DVQLYService dm_dviSer = new DM_DVQLYService();
            SYS_Session session = (SYS_Session)Session["SYS_Session"];
            decimal testSo = 0;
            if (Session["Add"] + "" == "0")
            {
                var qtCT = (DataRowView)grdDVT.GetRow(grdDVT.FocusedRowIndex);
               
                //CBDN.DM_LoaiDay cn = db.DM_LoaiDays.SingleOrDefault(x => x.ID == qtCT.ID);
                if (!CheckName(txtMaLoaiDay.Text,int.Parse(""+ qtCT["ID"])))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Mã loại dây được trùng');", true); return;
                }
                if (!decimal.TryParse(txtDienTro.Text,out testSo))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Điện trở phải là kiểu số');", true); return;
                }
                db.Update_TTTT_DM_LOAIDUONGDAY(int.Parse("" + qtCT["ID"]), session.User.ma_dviqlyDN, txtMaLoaiDay.Text, txtTenLoaiDay.Text, int.Parse(cmbLoaiDay.Value + ""), decimal.Parse(txtDienTro.Value + ""), DateTime.Now, session.User.IDUSER);
                
            }
            else
            {
                if (!CheckName(txtMaLoaiDay.Text, 0))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Mã loại dây được trùng');", true); return;
                }
                if (!decimal.TryParse(txtDienTro.Text, out testSo))
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "alert('Điện trở phải là kiểu số');", true); return;
                }

                db.Insert_TTTT_DM_LOAIDUONGDAY(0, session.User.ma_dviqlyDN, txtMaLoaiDay.Text, txtTenLoaiDay.Text, int.Parse(cmbLoaiDay.Value + ""), decimal.Parse(txtDienTro.Value + ""), DateTime.Now, session.User.IDUSER);
         
            }
            pcAddRoles.ShowOnPageLoad = false;
            _DataBind();
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


    }
}