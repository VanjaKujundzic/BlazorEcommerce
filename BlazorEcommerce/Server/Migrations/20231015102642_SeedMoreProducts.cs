using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "The Creator is a 2023 American science fiction film produced and directed by Gareth Edwards, who co-wrote the screenplay with Chris Weitz. The film stars John David Washington, Gemma Chan, Ken Watanabe, Sturgill Simpson, Allison Janney, and Madeleine Yuna Voyles (in her film debut). Set in 2055 after a nuclear detonation in Los Angeles and a war against artificial intelligence, an ex-special forces agent is recruited to hunt down and kill the \"Creator\", who has developed a mysterious weapon with the power to end the war.", "https://upload.wikimedia.org/wikipedia/en/9/94/The_Creator_2023_poster.jpg", 12.99m, "The Creator" },
                    { 5, 2, "Napoleon is an upcoming epic historical drama film directed and produced by Ridley Scott and written by David Scarpa. Based on the true story of Napoleon Bonaparte, primarily depicting the French leader's rise to power as well as his relationship with Empress Joséphine, the film stars Joaquin Phoenix (who is also a producer) as Napoleon, and features Vanessa Kirby alongside Tahar Rahim in supporting roles.", "https://upload.wikimedia.org/wikipedia/en/2/2e/Napoleon_Film_poster.jpg", 12.99m, "Napoleon" },
                    { 6, 3, "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games follow the Witcher series of fantasy novels written by Andrzej Sapkowski.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg", 59.99m, "The Witcher 3: Wild Hunt" },
                    { 7, 3, "Assassin's Creed Mirage is an action-adventure game developed by Ubisoft Bordeaux and published by Ubisoft. The game is the thirteenth major installment in the Assassin's Creed series and the successor to 2020's Assassin's Creed Valhalla. While its historical timeframe precedes that of Valhalla, its modern-day framing story succeeds Valhalla's own. Set in 9th-century Baghdad during the Islamic Golden Age—in particular during the Anarchy at Samarra—the story follows Basim Ibn Ishaq (a character first introduced in Valhalla), a street thief who joins the Hidden Ones to fight for peace and liberty, against the Order of the Ancients,[b] who desire peace through control. The main narrative focuses on Basim's internal struggle between his duties as a Hidden One and his desire to uncover his mysterious past.", "https://upload.wikimedia.org/wikipedia/en/2/23/Assassin%27s_Creed_Mirage_cover.jpeg", 59.99m, "Assassin's Creed Mirage" },
                    { 8, 3, "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment. It was released for the PlayStation 4 in April 2018, with a Windows port in January 2022. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III.", "https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg", 59.99m, "God of War" },
                    { 9, 3, "Star Wars Jedi: Fallen Order is a 2019 action-adventure game developed by Respawn Entertainment and published by Electronic Arts. The story is set in the Star Wars universe, five years after Star Wars: Episode III – Revenge of the Sith. It follows Jedi Padawan Cal Kestis, who becomes a target of the Galactic Empire and is hunted throughout the galaxy by the Imperial Inquisitors while attempting to complete his training, reconcile with his troubled past, and rebuild the fallen Jedi Order. ", "https://upload.wikimedia.org/wikipedia/en/1/13/Cover_art_of_Star_Wars_Jedi_Fallen_Order.jpg", 59.99m, "Star Wars Jedi: Fallen Order" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
