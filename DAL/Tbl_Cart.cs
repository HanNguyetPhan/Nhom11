//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineToyStore.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Cart
    {
        public int CartId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public Nullable<int> CartStatusId { get; set; }
    
        public virtual Tbl_Product Tbl_Product { get; set; }
    }
}
