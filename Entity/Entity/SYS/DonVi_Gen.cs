//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 6.0.0.0
//-- Template:       Entity_Gen.cst
//-- Date Generated: Thursday, December 13, 2012
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public partial class DonVi
    {
        private int _ID;
        private string _TenDV;
        private string _DiaChi;
        private string _Email;
        private int _ParentID;
        private int _PhanLoai;
        private int _Tinh;
        private int _Huyen;
        private int _Xa;

        public int ID { get { return _ID; } set { _ID = value; } }
        public string TenDV { get { return _TenDV; } set { _TenDV = value; } }
        public string DiaChi { get { return _DiaChi; } set { _DiaChi = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public int ParentID { get { return _ParentID; } set { _ParentID = value; } }
        public int PhanLoai { get { return _PhanLoai; } set { _PhanLoai = value; } }
        public int Tinh { get { return _Tinh; } set { _Tinh = value; } }
        public int Huyen { get { return _Huyen; } set { _Huyen = value; } }
        public int Xa { get { return _Xa; } set { _Xa = value; } }

        public DonVi(int ID, string TenDV, string DiaChi, string Email, int ParentID, int PhanLoai, int Tinh, int Huyen, int Xa)
        {
            _ID = ID;
            _TenDV = TenDV;
            _DiaChi = DiaChi;
            _Email = Email;
            _ParentID = ParentID;
            _PhanLoai = PhanLoai;
            _Tinh = Tinh;
            _Huyen = Huyen;
            _Xa = Xa;
        }
        public DonVi()
        {
            _ID = 0;
            _TenDV = String.Empty;
            _DiaChi = String.Empty;
            _Email = String.Empty;
            _ParentID = 0;
            _PhanLoai = 0;
            _Tinh = 0;
            _Huyen = 0;
            _Xa = 0;
        }

    }
}
