//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodNewsProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodNew
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public System.DateTime NewsDate { get; set; }
        public int JournalistId { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string NewsType { get; set; }
    
        public virtual Journalist Journalist { get; set; }
    }
}