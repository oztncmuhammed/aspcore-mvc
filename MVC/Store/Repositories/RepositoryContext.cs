using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories
{

     public class RepositoryContext :DbContext  //veri tabanı için kullanılacak kod bloğu //DBCONTEXTEN miras almak
    {
        public DbSet<Product> Products {get; set;}

        public RepositoryContext(DbContextOptions<RepositoryContext>options) :base(options) //DbContextile her iletişime geçtiğimizde  oluşacak olan bağlanti dizesi app setting üzerinden alınıyor olacak
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() {ProductId=1, ProductName="Computer",Price=17_000},
                new Product() {ProductId=2, ProductName="Keyboard",Price=1_000},
                new Product() {ProductId=3, ProductName="Mouse",Price=500},
                new Product() {ProductId=4, ProductName="Monitor",Price=7_000},
                new Product() {ProductId=5, ProductName="Deck",Price=1_000}
            );
        }
    }
}

