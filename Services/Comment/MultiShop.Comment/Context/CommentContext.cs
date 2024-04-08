using Microsoft.EntityFrameworkCore;
using MultiShop.Comment.Entities;

namespace MultiShop.Comment.Context
{
    public class CommentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1445;initial Catalog=MultiShopCommentDb;User=sa;Password=2676500Haki*");
        }
        public DbSet<UserComment> UserComments { get; set; }
    }
}
