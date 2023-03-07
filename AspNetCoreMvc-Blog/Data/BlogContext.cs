using AspNetCoreMvc_Blog.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace AspNetCoreMvc_Blog.Data
{
    public class BlogContext : System.Data.Entity.DbContext
    {
        public BlogContext()
            : base("MsSqlServer")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
