using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Sizes")]
    public class Size : DomainEnity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
    }
}