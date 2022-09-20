using Microsoft.EntityFrameworkCore;


namespace CardStorageService.Data
{
    public class CardStorageServiceDbContext : DbContext
    {

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
     
        public CardStorageServiceDbContext(DbContextOptions options) : base(options) 
        {
           
        }
      
       
    }
}


