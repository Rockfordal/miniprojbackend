using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class ColorTest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RGB { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class ColorTestQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ColorTestAnswer> Colors { get; set; }
    }

    public class ColorTestAnswer
    {
        public int Id { get; set; }
        public string Hex { get; set; }
    }

    public class ColorTestResponse
    {
        public string Result { get; set; }
    }
}