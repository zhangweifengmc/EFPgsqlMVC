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
    
    public partial class testdevicelocationinfo
    {
        public string id { get; set; }
        public int projectid { get; set; }
        public string deviceid { get; set; }
        public int gridx { get; set; }
        public int gridy { get; set; }
        public long apptimestamp { get; set; }
        public System.DateTimeOffset datatimestamptz { get; set; }
        public System.DateTimeOffset statisticstimestamptz { get; set; }
        public int imsitaskid { get; set; }
        public int taskid { get; set; }
    }
}
