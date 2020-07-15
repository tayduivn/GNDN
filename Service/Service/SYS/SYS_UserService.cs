//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       Service.cst
//-- Date Generated: Monday, July 12, 2010
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Entity;

namespace SystemManageService
{
    public partial class SYS_UserService
    {
        public List<SYS_User> SelectAllSYS_User_NotofRoles(int ID)
        {
            return _sys_userDataAccess.SelectAllSYS_User_NotofRoles(ID);
        }
        public List<SYS_User> SelectAllSYS_User_IsActive()
        {
            return _sys_userDataAccess.SelectAllSYS_User_IsActive();
        }
        public List<SYS_User> SelectAllSYS_User_ofRoles(int ID)
        {
            return _sys_userDataAccess.SelectAllSYS_User_ofRoles(ID);
        }
        public List<SYS_User> SYS_User_GetByOrganization(int ID)
        {
            return _sys_userDataAccess.SYS_User_GetByOrganization(ID);
        }

        public SYS_User CheckLogIn(string userName, string passWord)
        {
            SYS_User result = _sys_userDataAccess.SelectUserByUserName(userName);
            if (result.Password == SYS_User.Encrypt(passWord))
            
            {
                return result;
            }
            return null;
        }

        public SYS_User CheckLogIn(string userName, string passWord,int IDOrganization)
        {
            SYS_User result = _sys_userDataAccess.SelectUserByUserNameAndIDOrganization(userName,IDOrganization);
            if (result.Password == SYS_User.Encrypt(passWord))
            {
                return result;
            }
            return null;
        }

        public SYS_User CheckLogIn(string userName, string passWord, int Type, int IDDonVi)
        {
            SYS_User result = _sys_userDataAccess.SelectUserByUserNameAndType(userName, Type, IDDonVi);
            if (result.Password == SYS_User.Encrypt(passWord))
            {
                return result;
            }
            return null;
        }

        public SYS_User CheckLogIn(string userName, string passWord,string connect)
        {
            //ISYS_ConfigConnectionServer configConnectionServer = Provider.Resolve<ISYS_ConfigConnectionServer>();
            //int moduleID = int.Parse(ConfigurationSettings.AppSettings["DocumentManagement"]);
            //string connect =
            //    configConnectionServer.DecryptSYS_ConfigConnection(Provider.GetConnectStringByModule(moduleID));
            SYS_User result = _sys_userDataAccess.SelectUserByUserName(connect,userName);
            if (result.Password == SYS_User.Encrypt(passWord))
            {
                return result;
            }
            return null;
        }

        public int InsertSYS_UserAll(SYS_User sys_user)
        {
            return _sys_userDataAccess.InsertSYS_UserAll(sys_user);
        }

        public List<SYS_User> SYS_User_GetByIDOrganization(int IDOrganization)
        {
            return _sys_userDataAccess.SYS_User_GetByIDOrganization(IDOrganization);
        }

        public SYS_User SelectUserByUserNameAndIDOrganization(string userName,int IDOrganization)
        {
            return _sys_userDataAccess.SelectUserByUserNameAndIDOrganization(userName,IDOrganization);
        }


        public SYS_User GetByUserName(string userName)
        {
            return _sys_userDataAccess.SelectUserByUserName(userName);
        }
        public void UpdateSYS_UserAll(SYS_User sys_user)
        {
            _sys_userDataAccess.UpdateSYS_UserAll(sys_user);
        }
    }
}


