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
    
    public partial class taskannex
    {
        public int id { get; set; }
        public Nullable<int> taskid { get; set; }
        public Nullable<int> imsitaskid { get; set; }
        public Nullable<int> type { get; set; }
        public string filename { get; set; }
        public string jsonfilepath { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    }
}
