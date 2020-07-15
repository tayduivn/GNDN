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
	public partial class SYS_RightService
    {
		private SYS_RightDataAccess _sys_rightDataAccess = new SYS_RightDataAccess();
		
		public int InsertSYS_Right(SYS_Right sys_right)
        {
            return _sys_rightDataAccess.InsertSYS_Right(sys_right);
        }

        public int UpdateSYS_Right(List<SYS_Right> sys_rights)
        {
            return _sys_rightDataAccess.UpdateSYS_Right(sys_rights);
        }

        public void UpdateSYS_Right(SYS_Right sys_right)
        {
            _sys_rightDataAccess.UpdateSYS_Right(sys_right);
        }

        public void DeleteSYS_Right(List<SYS_Right> sys_rights)
        {
            _sys_rightDataAccess.DeleteSYS_Right(sys_rights);
        }

        public void DeleteSYS_Right(SYS_Right sys_rights)
        {
            _sys_rightDataAccess.DeleteSYS_Right(sys_rights);
        }

        public SYS_Right SelectSYS_Right(int sys_rightId)
        {
            return _sys_rightDataAccess.SelectSYS_Right(sys_rightId);
        }

        public List<SYS_Right> SelectAllSYS_Right()
        {
            return _sys_rightDataAccess.SelectAllSYS_Right();
        }
	 	
	}
}



