//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService3
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRONUS_Sverige_AB_Employee_Absence
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Employee_No_ { get; set; }
        public System.DateTime From_Date { get; set; }
        public System.DateTime To_Date { get; set; }
        public string Cause_of_Absence_Code { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
    }
}
