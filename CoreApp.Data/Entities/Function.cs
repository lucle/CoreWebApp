using CoreWebApp.Data.Enums;
using CoreWebApp.Data.Interfaces;
using CoreWebApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp.Data.Entities
{
    [Table("Function")]
    public class Function : DomainEnity<string>, ISwitchable, ISortable
    {
        public Function()
        {
        }

        public Function(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            this.Name = name;
            this.URL = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SortOrder = sortOrder;
            this.Status = Status.Active;
        }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string URL { get; set; }

        [StringLength(128)]
        public string ParentId { get; set; }

        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}