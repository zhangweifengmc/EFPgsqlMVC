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
    
    public partial class taskreport
    {
        public int id { get; set; }
        public string name { get; set; }
        public int state { get; set; }
        public int type { get; set; }
        public int templateid { get; set; }
        public int rateprogress { get; set; }
        public int downloadcount { get; set; }
        public string downloadurl { get; set; }
        public System.DateTime createtime { get; set; }
        public string remarks { get; set; }
        public int serverid { get; set; }
        public int taskid { get; set; }
        public string parameter { get; set; }
        public string consignee { get; set; }
        public int issendappendix { get; set; }
        public int createuserid { get; set; }
        public string createusername { get; set; }
        public string errormessage { get; set; }
        public string guid { get; set; }
        public string outmessage { get; set; }
        public Nullable<System.DateTimeOffset> updatetime { get; set; }
    }
}
