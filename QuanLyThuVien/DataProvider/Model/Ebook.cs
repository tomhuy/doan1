//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ebook
    {
        public int BookID { get; set; }
        public int TypeEbook { get; set; }
        public string Link { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual TypeEbook TypeEbook1 { get; set; }
    }
}