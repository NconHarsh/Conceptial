//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tank_Sounding_Table
    {
        public long Tank_Sounding_Id { get; set; }
        public long Tank_Id { get; set; }
        public Nullable<decimal> Sounding_mm { get; set; }
        public Nullable<decimal> Volume_Precentage { get; set; }
        public Nullable<decimal> Volume_of_fluid_m { get; set; }
        public Nullable<decimal> Weight_of_fluid_te { get; set; }
        public Nullable<decimal> LCG_of_fluid_mm { get; set; }
        public Nullable<decimal> TCG_of_fluid_mm { get; set; }
        public Nullable<decimal> VCG_of_fluid_mm { get; set; }
        public Nullable<decimal> Virtual_VCGt_mm { get; set; }
        public Nullable<decimal> Transverse_FSM_te_m { get; set; }
        public Nullable<decimal> Longitudinal_FSM_te_m { get; set; }
    
        public virtual Tank_Status Tank_Status { get; set; }
    }
}
