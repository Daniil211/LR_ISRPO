using CRUDWithWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithWebAPI.DAL
{
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class MyAppDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyAppDbContext"/> class.
        /// </summary>
        /// <param name="opOptions">The op options.</param>
        public MyAppDbContext(DbContextOptions opOptions) : base(opOptions) { }
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public DbSet<Product> Products { get; set; }
    }
}
