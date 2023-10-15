

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );


            modelBuilder.Entity<Product>().HasData(
         
                    new Product
                    {
                        Id=1,
                        Title= "The Hitchhiker's Guide to the Galaxy",
                        Description="The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        Price=5.99m,
                        CategoryId= 1
                    },
                    new Product
                    {
                        Id=2,
                        Title= "Dune",
                        Description="Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg",
                        Price=6.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id=3,
                        Title= "The Lord of the Rings",
                        Description="The Lord of the Rings is an epic high-fantasy novel by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.[2]",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
                        Price=9.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "The Creator",
                        Description = "The Creator is a 2023 American science fiction film produced and directed by Gareth Edwards, who co-wrote the screenplay with Chris Weitz. The film stars John David Washington, Gemma Chan, Ken Watanabe, Sturgill Simpson, Allison Janney, and Madeleine Yuna Voyles (in her film debut). Set in 2055 after a nuclear detonation in Los Angeles and a war against artificial intelligence, an ex-special forces agent is recruited to hunt down and kill the \"Creator\", who has developed a mysterious weapon with the power to end the war.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/94/The_Creator_2023_poster.jpg",
                        Price = 12.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Napoleon",
                        Description = "Napoleon is an upcoming epic historical drama film directed and produced by Ridley Scott and written by David Scarpa. Based on the true story of Napoleon Bonaparte, primarily depicting the French leader's rise to power as well as his relationship with Empress Joséphine, the film stars Joaquin Phoenix (who is also a producer) as Napoleon, and features Vanessa Kirby alongside Tahar Rahim in supporting roles.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Napoleon_Film_poster.jpg",
                        Price = 12.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "The Witcher 3: Wild Hunt",
                        Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third game in The Witcher video game series, played in an open world with a third-person perspective. The games follow the Witcher series of fantasy novels written by Andrzej Sapkowski.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                        Price = 59.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Assassin's Creed Mirage",
                        Description = "Assassin's Creed Mirage is an action-adventure game developed by Ubisoft Bordeaux and published by Ubisoft. The game is the thirteenth major installment in the Assassin's Creed series and the successor to 2020's Assassin's Creed Valhalla. While its historical timeframe precedes that of Valhalla, its modern-day framing story succeeds Valhalla's own. Set in 9th-century Baghdad during the Islamic Golden Age—in particular during the Anarchy at Samarra—the story follows Basim Ibn Ishaq (a character first introduced in Valhalla), a street thief who joins the Hidden Ones to fight for peace and liberty, against the Order of the Ancients,[b] who desire peace through control. The main narrative focuses on Basim's internal struggle between his duties as a Hidden One and his desire to uncover his mysterious past.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/23/Assassin%27s_Creed_Mirage_cover.jpeg",
                        Price = 59.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "God of War",
                        Description = "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment. It was released for the PlayStation 4 in April 2018, with a Windows port in January 2022. The game is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/God_of_War_4_cover.jpg",
                        Price = 59.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Star Wars Jedi: Fallen Order",
                        Description = "Star Wars Jedi: Fallen Order is a 2019 action-adventure game developed by Respawn Entertainment and published by Electronic Arts. The story is set in the Star Wars universe, five years after Star Wars: Episode III – Revenge of the Sith. It follows Jedi Padawan Cal Kestis, who becomes a target of the Galactic Empire and is hunted throughout the galaxy by the Imperial Inquisitors while attempting to complete his training, reconcile with his troubled past, and rebuild the fallen Jedi Order. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Cover_art_of_Star_Wars_Jedi_Fallen_Order.jpg",
                        Price = 59.99m,
                        CategoryId = 3
                    }

                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
