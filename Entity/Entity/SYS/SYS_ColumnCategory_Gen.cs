//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       Entity_Gen.cst
//-- Date Generated: Friday, October 28, 2011
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public partial class SYS_ColumnCategory
    {
        private int _ID;
        private string _ColumnName;
        private string _DisplayName;
        private int _IDCategoryManager;
        private Boolean _AllowNull;
        private string _DataType;

        public int ID { get { return _ID; } set { _ID = value; } }
        public string ColumnName { get { return _ColumnName; } set { _ColumnName = value; } }
        public string DisplayName { get { return _DisplayName; } set { _DisplayName = value; } }
        public int IDCategoryManager { get { return _IDCategoryManager; } set { _IDCategoryManager = value; } }
        public Boolean AllowNull { get { return _AllowNull; } set { _AllowNull = value; } }
        public string DataType { get { return _DataType; } set { _DataType = value; } }

        public SYS_ColumnCategory(int ID, string ColumnName, string DisplayName, int IDCategoryManager, Boolean AllowNull, string DataType)
        {
            _ID = ID;
            _ColumnName = ColumnName;
            _DisplayName = DisplayName;
            _IDCategoryManager = IDCategoryManager;
            _AllowNull = AllowNull;
            _DataType = DataType;
        }
        public SYS_ColumnCategory()
        {
            _ID = 0;
            _ColumnName = String.Empty;
            _DisplayName = String.Empty;
            _IDCategoryManager = 0;
            _AllowNull = false;
            _DataType = String.Empty;
        }

    }
}


