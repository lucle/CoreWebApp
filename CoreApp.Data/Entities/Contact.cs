using CoreWebApp.Data.Enums;
using CoreWebApp.Data.Interfaces;
using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Contacts")]
    public class Contact : DomainEnity<int>, ISwitchable
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Website { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public string Other { get; set; }
        public double? Lat { get; set; }
        public double? lng { get; set; }
        public Status Status { set; get; }
    }
}