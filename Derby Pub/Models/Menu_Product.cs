//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Derby_Pub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu_Product
    {
        public int Menu_ProductID { get; set; }
        public int MenuID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Product Product { get; set; }
    }
}