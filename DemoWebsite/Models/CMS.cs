using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebsite.Models
{
    public class CMS
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Title")]
        [Required(ErrorMessage = "This field is required.")]
        public string Title { get; set; }

        [DisplayName("Content")]
        public string Content { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Slug")]
        [Required(ErrorMessage = "This field is required.")]
        public string Slug { get; set; }
    }
}
