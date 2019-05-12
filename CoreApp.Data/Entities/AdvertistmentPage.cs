using CoreWebApp.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : DomainEnity<string>
    {
        public AdvertistmentPage() { }

        public AdvertistmentPage(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}