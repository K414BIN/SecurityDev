using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStorageService.Data
{
    public class CardStorageServiceDbContext : DbContext
    {
        public CardStorageServiceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
