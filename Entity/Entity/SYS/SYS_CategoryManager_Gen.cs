﻿//------------------------------------------------------------------------------------------------------------------------
//-- Generated By:   TrungVK using CodeSmith 5.0.0.0
//-- Template:       Entity_Gen.cst
//-- Date Generated: Monday, October 17, 2011
//------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public partial class SYS_CategoryManager
    {
        private int _ID;
        private String _TableName;
        private String _DisplayName;
        private String _Link;

        public int ID { get { return _ID; } set { _ID = value; } }
        public String TableName { get { return _TableName; } set { _TableName = value; } }
        public String DisplayName { get { return _DisplayName; } set { _DisplayName = value; } }
        public String Link { get { return _Link; } set { _Link = value; } }
        public string GroupName { set; get; }

        public SYS_CategoryManager(int ID, String TableName, String DisplayName, String Link)
        {
            _ID = ID;
            _TableName = TableName;
            _DisplayName = DisplayName;
            _Link = Link;
        }
        public SYS_CategoryManager()
        {
            _ID = 0;
            _TableName = String.Empty;
            _DisplayName = String.Empty;
            _Link = String.Empty;
        }

    }
}

