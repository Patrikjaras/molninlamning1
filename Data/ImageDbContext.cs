using Microsoft.EntityFrameworkCore;
using Molninlamning1.Models;

namespace Molninlamning1.Data
{
    public class ImageDbContext : DbContext
    {
        public DbSet<Mymemories> _images { get; set; }

        public ImageDbContext(DbContextOptions options) : base(options)
        {

        }
        
    }
  
}



