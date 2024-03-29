//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       Entity_Gen.cst
//-- Date Generated: Monday, July 12, 2010
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public partial class SYS_Organization
    {
		private int _ID;
		private string _Name;
		private int _ParentId;
        private string _Code;
        private string _Address;
        private string _Phone;
        private string _Fax;
        private string _Website;
        private int _Type;
        private int _IDProvince;

		public int ID { get{ return _ID; } set { _ID= value; } }
		public string Name { get{ return _Name; } set { _Name= value; } }
		public int ParentId { get{ return _ParentId; } set { _ParentId= value; } }
        public string Code { get { return _Code; } set { _Code = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string Fax { get { return _Fax; } set { _Fax = value; } }
        public string Website { get { return _Website; } set { _Website = value; } }
        public int Type { get { return _Type; } set { _Type = value; } }
        public int IDProvince { get { return _IDProvince; } set { _IDProvince = value; } }


		public SYS_Organization(int ID, string Name, int ParentId,string code)
		{
			_ID = ID;
			_Name = Name;
			_ParentId = ParentId;
		    _Code = code;
		}
		public SYS_Organization()
		{
			_ID =  0;
			_Name =  String.Empty;
			_ParentId =  0;
		    _Code = string.Empty;
		    _Address = string.Empty;
		    _Phone = string.Empty;
		    _Website = string.Empty;
		    _Type = 0;
		    _Fax = string.Empty;
		    _Email = string.Empty;
		    _IDProvince = 0;
		}
           
    }
}

