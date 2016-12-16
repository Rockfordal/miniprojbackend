using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class WordImageTest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Word { get; set; }

        [Required]
        public string Image { get; set; }
    }

    public class WordImageQuestion
    {
        public int Id { get; set; }
        public string Image { get; set; }
    }

    public class WordImageAnswer
    {
        public int Id { get; set; }
        public string Word { get; set; }
    }

    public class WordImageResponse
    {
        //public int Id { get; set; }
        public string Result { get; set; }
    }

}