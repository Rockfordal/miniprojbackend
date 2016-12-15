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
            c.Sentencetests.AddOrUpdate(
                new SentenceTest { Text = "Thank you for the mess." },
                new SentenceTest { Text = "Så ljuvt det är att göra ingenting, och sedan vila efteråt." },
                new SentenceTest { Text = "Arbete är en aktivitet som är till för tråkmånsar." },
                new SentenceTest { Text = "Det är bättre att vara omsorgsfullt overksam än att arbeta slarvigt." },
                new SentenceTest { Text = "Jag äger tio par gymnastikskor, ett par för varje veckodag." },
                new SentenceTest { Text = "gymnastikskor, ett par för varje veckodag." }
            );

            c.Separatortests.AddOrUpdate(
                new SeparatorTest { Text = "Ni kommer aldrig att lyckas - fyrmanna-band är ute. Åk hem till Liverpool..." },
                new SeparatorTest { Text = "Kom alltid ihåg att du är helt unik. Precis som alla andra." },
                new SeparatorTest { Text = "På hösten flyger fåglarna till månen där de sover vintersömn, tills de återvänder till jorden på våren." },
                new SeparatorTest { Text = "Huvudvärk beror på inflammation i huvudet, och den kureras bäst med varma omslag, gärna bestående av elefantexkrementer." },
                new SeparatorTest { Text = "Jag är inte vegetarian för att jag älskar djur. Jag är vegetarian för att jag hatar växter." },
                new SeparatorTest { Text = "Den bästa hämnden när någon stjäl din fru? Att låta honom behålla henne." }
            );

            c.Sentencetests.AddOrUpdate(
                new SentenceTest { Text = "Detta är bara ett exempel" },
                new SentenceTest { Text = "Fem ord säger så lite" },
                new SentenceTest { Text = "Meningar inleds med stor bokstav" },
                new SentenceTest { Text = "Det står stilla just nu" }
            );

            c.WordImagetests.AddOrUpdate(
                new WordImageTest { Image = "/content/images/bird.png", Word = "Fågel" },
                new WordImageTest { Image = "/content/images/car.png", Word = "Bil" },
                new WordImageTest { Image = "/content/images/cat.png", Word = "Katt" },
                new WordImageTest { Image = "/content/images/dog.jpg", Word = "Hund" },
                new WordImageTest { Image = "/content/images/house.png", Word = "Hus" }
            );

            c.Colortests.AddOrUpdate(
                new ColorTest { Name = "Vit", RGB = "#FFFFFF" },
                new ColorTest { Name = "Svart", RGB = "#000000" },
                new ColorTest { Name = "Blå", RGB = "#0000FF" },
                new ColorTest { Name = "Grå", RGB = "#808080" },
                new ColorTest { Name = "Silver", RGB = "#C0C0C0" },
                new ColorTest { Name = "Lavendel", RGB = "E6E6FA" },
                new ColorTest { Name = "Ultramarin", RGB = "#120A8F" },
                new ColorTest { Name = "Indigo", RGB = "#4B0082" },
                new ColorTest { Name = "Cyan", RGB = "#00FFFF" },
                new ColorTest { Name = "Turkos", RGB = "#40E0D0" },
                new ColorTest { Name = "Akvamarin", RGB = "#7FFFD4" },
                new ColorTest { Name = "Smaragdgrön", RGB = "#50C878" },
                new ColorTest { Name = "Grön", RGB = "#008000" },
                new ColorTest { Name = "Lime", RGB = "#BFFF00" },
                new ColorTest { Name = "Beige", RGB = "#F5F5DC" },
                new ColorTest { Name = "Gul", RGB = "#FFFF00" },
                new ColorTest { Name = "Olivgrön", RGB = "#808000" },
                new ColorTest { Name = "Guld", RGB = "#FFD700" },
                new ColorTest { Name = "Orange", RGB = "#FFA500" },
                new ColorTest { Name = "Brun", RGB = "#964B00" },
                new ColorTest { Name = "Rost", RGB = "#B7410E" },
                new ColorTest { Name = "Rosa", RGB = "#FFC0CB" },
                new ColorTest { Name = "Korall", RGB = "#F88379" },
                new ColorTest { Name = "Scharlakansröd ", RGB = "#FF2400" },
                new ColorTest { Name = "Röd", RGB = "#FF0000" },
                new ColorTest { Name = "Kastanj", RGB = "#CD5C5C" },
                new ColorTest { Name = "Vinröd", RGB = "#800000" },
                new ColorTest { Name = "Cerise", RGB = "#DE3163" },
                new ColorTest { Name = "Lila", RGB = "#C8A2C8" },
                new ColorTest { Name = "Violett", RGB = "#EE82EE" },
                new ColorTest { Name = "Purpur", RGB = "#800080" }
                );
        }
    }
}
