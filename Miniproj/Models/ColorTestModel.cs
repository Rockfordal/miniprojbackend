using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class ColorTestModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RGB { get; set; }

        [Required]
        public string Name { get; set; }
    }
}