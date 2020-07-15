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
	public partial class SYS_OrganizationService
    {
		private SYS_OrganizationDataAccess _sys_organizationDataAccess = new SYS_OrganizationDataAccess();
		
		public int InsertSYS_Organization(SYS_Organization sys_organization)
        {
            return _sys_organizationDataAccess.InsertSYS_Organization(sys_organization);
        }

        public int UpdateSYS_Organization(List<SYS_Organization> sys_organizations)
        {
            return _sys_organizationDataAccess.UpdateSYS_Organization(sys_organizations);
        }

        public void UpdateSYS_Organization(SYS_Organization sys_organization)
        {
            _sys_organizationDataAccess.UpdateSYS_Organization(sys_organization);
        }

        public void DeleteSYS_Organization(List<SYS_Organization> sys_organizations)
        {
            _sys_organizationDataAccess.DeleteSYS_Organization(sys_organizations);
        }

        public void DeleteSYS_Organization(SYS_Organization sys_organizations)
        {
            _sys_organizationDataAccess.DeleteSYS_Organization(sys_organizations);
        }

        public SYS_Organization SelectSYS_Organization(int sys_organizationId)
        {
            return _sys_organizationDataAccess.SelectSYS_Organization(sys_organizationId);
        }

        public List<SYS_Organization> SelectAllSYS_Organization()
        {
            return _sys_organizationDataAccess.SelectAllSYS_Organization();
        }
	 	
	}
}



