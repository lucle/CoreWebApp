using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("WholePrices")]
    public class WholePrice : DomainEnity<int>
    {
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}