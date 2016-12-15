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
                new SentenceTest { Text = "S� ljuvt det �r att g�ra ingenting, och sedan vila efter�t." },
                new SentenceTest { Text = "Arbete �r en aktivitet som �r till f�r tr�km�nsar." },
                new SentenceTest { Text = "Det �r b�ttre att vara omsorgsfullt overksam �n att arbeta slarvigt." },
                new SentenceTest { Text = "Jag �ger tio par gymnastikskor, ett par f�r varje veckodag." },
                new SentenceTest { Text = "gymnastikskor, ett par f�r varje veckodag." }
            );

            c.Separatortests.AddOrUpdate(
                new SeparatorTest { Text = "Ni kommer aldrig att lyckas - fyrmanna-band �r ute. �k hem till Liverpool..." },
                new SeparatorTest { Text = "Kom alltid ih�g att du �r helt unik. Precis som alla andra." },
                new SeparatorTest { Text = "P� h�sten flyger f�glarna till m�nen d�r de sover vinters�mn, tills de �terv�nder till jorden p� v�ren." },
                new SeparatorTest { Text = "Huvudv�rk beror p� inflammation i huvudet, och den kureras b�st med varma omslag, g�rna best�ende av elefantexkrementer." },
                new SeparatorTest { Text = "Jag �r inte vegetarian f�r att jag �lskar djur. Jag �r vegetarian f�r att jag hatar v�xter." },
                new SeparatorTest { Text = "Den b�sta h�mnden n�r n�gon stj�l din fru? Att l�ta honom beh�lla henne." }
            );

            c.Sentencetests.AddOrUpdate(
                new SentenceTest { Text = "Detta �r bara ett exempel" },
                new SentenceTest { Text = "Fem ord s�ger s� lite" },
                new SentenceTest { Text = "Meningar inleds med stor bokstav" },
                new SentenceTest { Text = "Det st�r stilla just nu" }
            );

            c.WordImagetests.AddOrUpdate(
                new WordImageTest { Image = "/content/images/bird.png", Word = "F�gel" },
                new WordImageTest { Image = "/content/images/car.png", Word = "Bil" },
                new WordImageTest { Image = "/content/images/cat.png", Word = "Katt" },
                new WordImageTest { Image = "/content/images/dog.jpg", Word = "Hund" },
                new WordImageTest { Image = "/content/images/house.png", Word = "Hus" }
            );

            c.Colortests.AddOrUpdate(
                new ColorTest { Name = "Vit", RGB = "#FFFFFF" },
                new ColorTest { Name = "Svart", RGB = "#000000" },
                new ColorTest { Name = "Bl�", RGB = "#0000FF" },
                new ColorTest { Name = "Gr�", RGB = "#808080" },
                new ColorTest { Name = "Silver", RGB = "#C0C0C0" },
                new ColorTest { Name = "Lavendel", RGB = "E6E6FA" },
                new ColorTest { Name = "Ultramarin", RGB = "#120A8F" },
                new ColorTest { Name = "Indigo", RGB = "#4B0082" },
                new ColorTest { Name = "Cyan", RGB = "#00FFFF" },
                new ColorTest { Name = "Turkos", RGB = "#40E0D0" },
                new ColorTest { Name = "Akvamarin", RGB = "#7FFFD4" },
                new ColorTest { Name = "Smaragdgr�n", RGB = "#50C878" },
                new ColorTest { Name = "Gr�n", RGB = "#008000" },
                new ColorTest { Name = "Lime", RGB = "#BFFF00" },
                new ColorTest { Name = "Beige", RGB = "#F5F5DC" },
                new ColorTest { Name = "Gul", RGB = "#FFFF00" },
                new ColorTest { Name = "Olivgr�n", RGB = "#808000" },
                new ColorTest { Name = "Guld", RGB = "#FFD700" },
                new ColorTest { Name = "Orange", RGB = "#FFA500" },
                new ColorTest { Name = "Brun", RGB = "#964B00" },
                new ColorTest { Name = "Rost", RGB = "#B7410E" },
                new ColorTest { Name = "Rosa", RGB = "#FFC0CB" },
                new ColorTest { Name = "Korall", RGB = "#F88379" },
                new ColorTest { Name = "Scharlakansr�d ", RGB = "#FF2400" },
                new ColorTest { Name = "R�d", RGB = "#FF0000" },
                new ColorTest { Name = "Kastanj", RGB = "#CD5C5C" },
                new ColorTest { Name = "Vinr�d", RGB = "#800000" },
                new ColorTest { Name = "Cerise", RGB = "#DE3163" },
                new ColorTest { Name = "Lila", RGB = "#C8A2C8" },
                new ColorTest { Name = "Violett", RGB = "#EE82EE" },
                new ColorTest { Name = "Purpur", RGB = "#800080" }
                );
        }
    }
}
