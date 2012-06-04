using System.Data.Entity;
using HarborFirstDeux.Models;

namespace HarborFirstDeux.Persistence
{
    public class HfdContext : DbContext
    {
        public HfdContext() : base("HfdContext_" + MvcApplication.Environment) { }

        public DbSet<User> Users { get; set; }
    }
}