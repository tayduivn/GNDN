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
    public partial class SYS_Config
    {
		private int _ID;
		private string _Name;
		private string _Value;
	
		public int ID { get{ return _ID; } set { _ID= value; } }
		public string Name { get{ return _Name; } set { _Name= value; } }
		public string Value { get{ return _Value; } set { _Value= value; } }
	
		public SYS_Config(int ID, string Name, string Value)
		{
			_ID = ID;
			_Name = Name;
			_Value = Value;
		}
		public SYS_Config()
		{
			_ID =  0;
			_Name =  String.Empty;
			_Value =  String.Empty;
		}
           
    }
}

