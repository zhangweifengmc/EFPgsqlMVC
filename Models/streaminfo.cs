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
    
    public partial class streaminfo
    {
        public int id { get; set; }
        public string parametertemplate { get; set; }
        public string streamdirectory { get; set; }
        public int parentid { get; set; }
        public int reportitemid { get; set; }
        public int type { get; set; }
        public string path { get; set; }
    }
}
