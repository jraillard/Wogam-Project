//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EchoMe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int PresentationId { get; set; }
        public int UsesrId { get; set; }
        public string UserName { get; set; }
        public string Time { get; set; }
        public string Content { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsAnonymous { get; set; }
    }
}