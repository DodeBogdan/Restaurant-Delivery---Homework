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
    
    public partial class Order_Menu
    {
        public int FKOderID { get; set; }
        public int FKMenuID { get; set; }
        public int Order_MenuID { get; set; }
    
        public virtual Menu_Product Menu_Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
