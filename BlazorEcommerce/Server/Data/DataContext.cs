

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
         
                    new Product
                    {
                        Id=1,
                        Title= "The Hitchhiker's Guide to the Galaxy",
                        Description="The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        Price=5.99m
                    },
                    new Product
                    {
                        Id=2,
                        Title= "Dune",
                        Description="Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg",
                        Price=6.99m
                    },
                    new Product
                    {
                        Id=3,
                        Title= "The Lord of the Rings",
                        Description="The Lord of the Rings is an epic high-fantasy novel by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.[2]",
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
                        Price=9.99m
                    }

                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
