//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NurseryAssigner.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssignmentCount
    {
        public long ID { get; set; }
        public string AMPM { get; set; }
        public long AgeGroupID { get; set; }
        public long Amount { get; set; }
    
        public virtual AgeGroup AgeGroup { get; set; }
    }
}
