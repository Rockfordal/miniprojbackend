using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class SentenceTest
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Text { get; set; }
    }
}