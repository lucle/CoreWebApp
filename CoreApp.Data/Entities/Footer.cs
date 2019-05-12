using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Footers")]
    public class Footer : DomainEnity<string>
    {
        [Required]
        public string Content { get; set; }
    }
}