//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _31_task
{
    using System;
    using System.Collections.Generic;
    
    public partial class theatre
    {
        public int Th_Id { get; set; }
        public string Th_name { get; set; }
        public string Th_loc { get; set; }
        public string dist { get; set; }
        public int movieMv_Id { get; set; }
    
        public virtual movie movie { get; set; }
    }
}
