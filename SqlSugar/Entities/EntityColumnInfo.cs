﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class EntityColumnInfo
    {
        public PropertyInfo PropertyInfo { get; set; }
        public string EntityName { get; set; }
        public string ColumnName { get; set; }
        public int Length { get; set; }
        public string ColumnDescription { get; set; }
        public string DefaultValue { get; set; }
        public bool IsNullable { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsPrimarykey { get; set; }
    }
}