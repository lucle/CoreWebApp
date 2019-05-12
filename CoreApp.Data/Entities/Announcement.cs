using CoreWebApp.Data.Enums;
using CoreWebApp.Data.Interfaces;
using CoreWebApp.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Announcements")]
    public class Announcement : DomainEnity<string>, ISwitchable, IDateTracking
    {
        public Announcement()
        { }

        public Announcement(string title, string content, Guid userId, Status status)
        {
            Title = title;
            Content = content;
            UserId = userId;
            Status = status;
        }


        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Content { get; set; }
        public Guid UserId { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}