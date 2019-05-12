using CoreWebApp.Data.Enums;
using CoreWebApp.Data.Interfaces;
using CoreWebApp.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEnity<int>, ISwitchable, IDateTracking
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Message { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}