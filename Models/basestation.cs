//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFPgsqlMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class basestation
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createusername { get; set; }
        public Nullable<int> createuserid { get; set; }
        public Nullable<System.DateTime> updatetime { get; set; }
        public Nullable<int> updateuserid { get; set; }
        public string updateusername { get; set; }
        public string authorizeusers { get; set; }
        public string remark { get; set; }
        public string mobilemode { get; set; }
        public string tableid { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> stationtype { get; set; }
        public string alias { get; set; }
        public string excelfilepath { get; set; }
    }
}
