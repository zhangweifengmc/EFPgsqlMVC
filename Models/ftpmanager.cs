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
    
    public partial class ftpmanager
    {
        public int id { get; set; }
        public Nullable<int> type { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> createuserid { get; set; }
        public string createusername { get; set; }
        public Nullable<int> lastupdateuserid { get; set; }
        public string lastupdateusername { get; set; }
        public string ftpusername { get; set; }
        public string ftppassword { get; set; }
        public string remotepath { get; set; }
        public Nullable<int> port { get; set; }
        public Nullable<System.DateTime> lastupdatetime { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string companyname { get; set; }
        public Nullable<int> companyid { get; set; }
        public Nullable<int> servertype { get; set; }
    }
}
