//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int STid { get; set; }
        public string STname { get; set; }
        public int CourseCid { get; set; }
        public int SchoolSCid { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual School School { get; set; }
    }
}
