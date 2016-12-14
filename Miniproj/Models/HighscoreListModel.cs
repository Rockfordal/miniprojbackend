using Miniproj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniproj.Models
{
    public class HighscoreListModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Category { get; set; }

        [Required]
        public HighscoreList Highscores { get; set; }
    }
}