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
    public partial class SYS_Exception
    {
		private int _ID;
		private DateTime _Time;
		private string _ExceptionTrace;
	
		public int ID { get{ return _ID; } set { _ID= value; } }
		public DateTime Time { get{ return _Time; } set { _Time= value; } }
		public string ExceptionTrace { get{ return _ExceptionTrace; } set { _ExceptionTrace= value; } }
	
		public SYS_Exception(int ID, DateTime Time, string ExceptionTrace)
		{
			_ID = ID;
			_Time = Time;
			_ExceptionTrace = ExceptionTrace;
		}
		public SYS_Exception()
		{
			_ID =  0;
			_Time =  DateTime.Now;
			_ExceptionTrace =  String.Empty;
		}
           
    }
}
