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
    
    public partial class ChapterDetail
    {
        public int IDBook { get; set; }
        public int ChapterID { get; set; }
        public string Alias { get; set; }
        public string NameChapter { get; set; }
        public string Content { get; set; }
    
        public virtual Book Book { get; set; }
    }
}
