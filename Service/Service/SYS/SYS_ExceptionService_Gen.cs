//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       ServiceGen.cst
//-- Date Generated: Monday, July 12, 2010
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entity;
namespace SystemManageService
{
	public partial class SYS_ExceptionService
    {
		private SYS_ExceptionDataAccess _sys_exceptionDataAccess = new SYS_ExceptionDataAccess();
		
		public int InsertSYS_Exception(SYS_Exception sys_exception)
        {
            return _sys_exceptionDataAccess.InsertSYS_Exception(sys_exception);
        }

        public int UpdateSYS_Exception(List<SYS_Exception> sys_exceptions)
        {
            return _sys_exceptionDataAccess.UpdateSYS_Exception(sys_exceptions);
        }

        public void UpdateSYS_Exception(SYS_Exception sys_exception)
        {
            _sys_exceptionDataAccess.UpdateSYS_Exception(sys_exception);
        }

        public void DeleteSYS_Exception(List<SYS_Exception> sys_exceptions)
        {
            _sys_exceptionDataAccess.DeleteSYS_Exception(sys_exceptions);
        }

        public void DeleteSYS_Exception(SYS_Exception sys_exceptions)
        {
            _sys_exceptionDataAccess.DeleteSYS_Exception(sys_exceptions);
        }

        public SYS_Exception SelectSYS_Exception(int sys_exceptionId)
        {
            return _sys_exceptionDataAccess.SelectSYS_Exception(sys_exceptionId);
        }

        public List<SYS_Exception> SelectAllSYS_Exception()
        {
            return _sys_exceptionDataAccess.SelectAllSYS_Exception();
        }
	 	
	}
}



