using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Miniproj.Models
{
    public class SeparatorTestModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Text { get; set; }
    }
}