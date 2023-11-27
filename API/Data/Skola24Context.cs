using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Skola24Context : DbContext
    {
        public Skola24Context(DbContextOptions<Skola24Context> options) : base(options) { }
    }
}
