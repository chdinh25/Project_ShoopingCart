//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCartV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ProductTab { get; set; }
        public string ProductName { get; set; }
        public string ImageFile { get; set; }
        public decimal UnitPrice { get; set; }
        public int MaxAmount { get; set; }
        public int DefaultAmount { get; set; }
    }
}
