//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinephile.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public string UserId { get; set; }
        public System.Guid MovieId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public System.DateTime DatePosted { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Movie Movy { get; set; }
    }
}