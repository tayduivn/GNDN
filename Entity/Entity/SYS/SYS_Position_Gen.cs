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
    public partial class SYS_Position
    {
		private int _ID;
		private string _Name;
	
		public int ID { get{ return _ID; } set { _ID= value; } }
		public string Name { get{ return _Name; } set { _Name= value; } }
	
		public SYS_Position(int ID, string Name)
		{
			_ID = ID;
			_Name = Name;
		}
		public SYS_Position()
		{
			_ID =  0;
			_Name =  String.Empty;
		}
           
    }
}
