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
    
    public partial class Additional_Weight_Table
    {
        public long Additional_Weight_ID { get; set; }
        public Nullable<long> Ship_ID { get; set; }
        public string Weight_Description { get; set; }
        public Nullable<int> No_of_Crew { get; set; }
        public Nullable<decimal> Total_Weight { get; set; }
        public Nullable<decimal> Centroid_X { get; set; }
        public Nullable<decimal> Centroid_Y { get; set; }
        public Nullable<decimal> Centroid_Z { get; set; }
        public Nullable<decimal> Moment_Weight_X { get; set; }
        public Nullable<decimal> Moment_Weight_Y { get; set; }
        public Nullable<decimal> Moment_Weight_Z { get; set; }
    
        public virtual Ship_Table Ship_Table { get; set; }
    }
}
