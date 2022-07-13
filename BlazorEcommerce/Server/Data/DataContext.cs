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
                        Id = 1,
                        Title = "Wiedźmin",
                        Description = "RPG",
                        ImageUrl = "https://a.allegroimg.com/original/03ef7f/a2f7f1f44518b44e400e834745c6/THE-WITCHER-3-WILD-HUNT-PL-GOG-KLUCZ-GRATIS",
                        Price = 9.99m
                    },

                    new Product
                    {
                        Id = 2,
                        Title = "Dead Space",
                        Description = "Horror",
                        ImageUrl = "https://assets.reedpopcdn.com/dead_space_remake_felieton.jpg/BROK/thumbnail/1200x1200/quality/100/dead_space_remake_felieton.jpg",
                        Price = 7.99m
                    },

                    new Product
                    {
                        Id = 3,
                        Title = "Factorio",
                        Description = "Logic",
                        ImageUrl = "https://a.allegroimg.com/original/11e87f/f56f2f0d47a48ede1ff0300d4549/Factorio-STEAM",
                        Price = 19.99m
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
