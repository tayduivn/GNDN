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
    public partial class SYS_Right
    {
		private int _ID;
        private string _FuncName;
        private string _Tag;
        private int _ModuleID;
        private string _FuncID;
	
		public int ID { get{ return _ID; } set { _ID= value; } }
        public string FuncName { get { return _FuncName; } set { _FuncName = value; } }
        public string Tag { get { return _Tag; } set { _Tag = value; } }
        public int ModuleID { get { return _ModuleID; } set { _ModuleID = value; } }
        public string FuncId { get { return _FuncID; } set { _FuncID = value; } }

        public SYS_Right(int ID, string FuncName, string Tag, int moduleID)
		{
			_ID = ID;
            _FuncName = FuncName;
            _Tag = Tag;
            _ModuleID = moduleID;
		}
		public SYS_Right()
		{
			_ID =  0;
            _FuncName = "";
            _Tag = "";
            _ModuleID = 0;
		}
           
    }
}

