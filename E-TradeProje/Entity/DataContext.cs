using System.Data.Entity;
    namespace E_TradeProje.Entity
{
    public class DataContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
