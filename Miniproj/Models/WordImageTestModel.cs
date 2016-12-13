using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class WordImageTestModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Word { get; set; }
        [Required]
        public string Image { get; set; }
    }
}