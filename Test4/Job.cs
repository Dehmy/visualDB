//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int id { get; set; }
        public Nullable<int> projectId { get; set; }
        public string jobType { get; set; }
        public string agreedPrice { get; set; }
        public string payments { get; set; }
        public string notes { get; set; }
        public string isPayed { get; set; }
    
        public virtual Project Project { get; set; }
    }
}
