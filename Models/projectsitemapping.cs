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
    
    public partial class projectsitemapping
    {
        public int id { get; set; }
        public Nullable<int> projectid { get; set; }
        public Nullable<int> basestationid { get; set; }
        public Nullable<int> basestationdetailid { get; set; }
        public Nullable<int> subtaskid { get; set; }
        public Nullable<int> taskid { get; set; }
        public Nullable<int> imsitaskid { get; set; }
        public Nullable<int> basestationidforbuildtask { get; set; }
        public Nullable<bool> byfrequency { get; set; }
    }
}