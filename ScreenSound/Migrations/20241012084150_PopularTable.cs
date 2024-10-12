using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artist", new string[] { "Name", "Bio", "ProfilePhoto" }, new object[] { "Justin Bieber",
                "Justin Drew Bieber (/ˈbiːbər/ BEE-bər; born March 1, 1994)[2][3] is a Canadian singer. Regarded as a pop icon, " +
                "he is recognized for his multi-genre musical performances.[4][5][6] He was discovered by American record executive " +
                "Scooter Braun in 2008 and subsequently brought to American singer Usher, both of whom formed the record label " +
                "RBMG Records to sign Bieber in October of that year.",
                "https://lodz.wyborcza.pl/lodz/51,35136,13330073.html#S.galeria-K.C-B.1-L.1.duzy"});

            migrationBuilder.InsertData("Artist", new string[] { "Name", "Bio", "ProfilePhoto" }, new object[] { "Selena Gomes",
                "Selena Marie Gomez (/səˈliːnə ˈɡoʊmɛz/ sə-LEE-nə GOH-mez; born July 22, 1992) is an American singer, actress, producer, " +
                "and businesswoman. She began her career as a child actress, starring on the children's television series Barney & Friends " +
                "(2002–2004), and rose to prominence as a teen idol, leading as Alex Russo on the Disney Channel sitcom Wizards of Waverly " +
                "Place (2007–2012).",
                "https://avatarfiles.alphacoders.com/219/219380.jpg" });

            migrationBuilder.InsertData("Artist", new string[] { "Name", "Bio", "ProfilePhoto" }, new object[] { "Shakira",
                "Shakira Isabel Mebarak Ripoll (Barranquilla, 2 de fevereiro de 1977) é uma cantora, compositora, dançarina e " +
                "multi-instrumentista colombiana, além de atuar regularmente como produtora musical, empresária, filantropa, atriz e " +
                "modelo.[6][7] Nascida e criada em Barranquilla, ela começou a se apresentar na escola, demonstrando influências de música " +
                "latina, árabe e rock and roll e habilidades em dança do ventre.",
                "https://avatarfiles.alphacoders.com/229/229606.jpg"
            });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artist");
        }
    }
}
