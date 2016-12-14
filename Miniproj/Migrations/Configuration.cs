using Miniproj.Models;

namespace Miniproj.Migrations
{
    using Miniproj.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniproj.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Miniproj.Models.ApplicationDbContext c)
        {
            c.Colortests.AddOrUpdate(
                //new ColorTestModel { RGB = "", Name = "" },
                //new ColorTestModel { RGB = "", Name = "" },
                new ColorTestModel { Name = "Vit", RGB = "#FFFFFF" },
                new ColorTestModel { Name = "Svart", RGB = "#000000" },
                new ColorTestModel { Name = "Blå", RGB = "#0000FF"},
                new ColorTestModel { Name = "Grå", RGB = "#808080" },
                new ColorTestModel { Name = "Silver", RGB = "#C0C0C0" },
                new ColorTestModel { Name = "Lavendel", RGB = "E6E6FA" },
                new ColorTestModel { Name = "Ultramarin", RGB = "#120A8F" },
                new ColorTestModel { Name = "Indigo", RGB = "#4B0082" },
                new ColorTestModel { Name = "Cyan", RGB = "#00FFFF" },
                new ColorTestModel { Name = "Turkos", RGB = "#40E0D0" },
                new ColorTestModel { Name = "Akvamarin", RGB = "#7FFFD4" },
                new ColorTestModel { Name = "Smaragdgrön", RGB = "#50C878" },
                new ColorTestModel { Name = "Grön", RGB = "#008000" },
                new ColorTestModel { Name = "Lime", RGB = "#BFFF00" },
                new ColorTestModel { Name = "Beige", RGB = "#F5F5DC" },
                new ColorTestModel { Name = "Gul", RGB = "#FFFF00" },
                new ColorTestModel { Name = "Olivgrön", RGB = "#808000" },
                new ColorTestModel { Name = "Guld", RGB = "#FFD700" },
                new ColorTestModel { Name = "Orange", RGB = "#FFA500" },
                new ColorTestModel { Name = "Brun", RGB = "#964B00" },
                new ColorTestModel { Name = "Rost", RGB = "#B7410E" },
                new ColorTestModel { Name = "Rosa", RGB = "#FFC0CB" },
                new ColorTestModel { Name = "Korall", RGB = "#F88379" },
                new ColorTestModel { Name = "Scharlakansröd ", RGB = "#FF2400" },
                new ColorTestModel { Name = "Röd", RGB = "#FF0000" },
                new ColorTestModel { Name = "Kastanj", RGB = "#CD5C5C" },
                new ColorTestModel { Name = "Vinröd", RGB = "#800000" },
                new ColorTestModel { Name = "Cerise", RGB = "#DE3163" },
                new ColorTestModel { Name = "Lila", RGB = "#C8A2C8" },
                new ColorTestModel { Name = "Violett", RGB = "#EE82EE" },
                new ColorTestModel { Name = "Purpur", RGB = "#800080" }
                );
        }
    }
}
