﻿using System.Data;

namespace SQLSERVERLOG
{
    //自定义的column结构
    public class Datacolumn
    {
        public string Name;
        public System.Data.SqlDbType DataType;
        public short Length = -1;
        public object Value = null;
        public Datacolumn(string name, SqlDbType type)
        {
            Name = name;
            DataType = type;
        }
        public Datacolumn(string name, SqlDbType type, short length)
        {
            Name = name;
            DataType = type;
            Length = length;
        }
    }


    public class DBLog
    {
        public string AllocUnitName { get; set; }
        public string Operation { get; set; }
        public byte[] R0 { get; set; }
        public byte[] R1 { get; set; }
        public byte[] R2 { get; set; }
        public byte[] R3 { get; set; }
        public byte[] R4 { get; set; }
        public int Offset { get; set; }
        public int ModifySize { get; set; }
        public int SlotId { get; set; }
        public string PageId { get; set; }
    }

    public class TableDefine
    {
        public string TableName { get; set; }
        public string ColName { get; set; }
        public int SortOrder { get; set; }
        public short MaxLength { get; set; }
        public string TypeName { get; set; }
    }

    public class PageInfo
    {
        public string ParentObject { get; set; }
        public string Object { get; set; }
        public string Field { get; set;}
        public string Value { get; set; }
    }
}
