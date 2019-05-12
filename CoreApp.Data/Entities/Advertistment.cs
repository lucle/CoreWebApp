using CoreWebApp.Data.Enums;
using CoreWebApp.Data.Interfaces;
using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Advertistments")]
    public class Advertistment : DomainEnity<int>, ISwitchable, ISortable
    {
        public Advertistment() { }
        public Advertistment(string name, string description, string url, string positionId)
        {
            this.Name = name;
            this.Description = description;
            this.URL = url;
            this.PositionId = positionId;
        }
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        [StringLength(250)]
        public string PositionId { get; set; }

        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}