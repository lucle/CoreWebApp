using CoreWebApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreWebApp.Data.Entities
{
    [Table("BlogTags")]
    public class BlogTag :DomainEnity<int>
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
