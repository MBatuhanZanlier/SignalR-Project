using Microsoft.EntityFrameworkCore;
using SignalR.API.DAL.Entities;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.DataAccessLayer.Concrete
{
    public class SignalRContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J7PG414\\SQLEXPRESS; initial Catalog=SignalRDb; integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        } 
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Booking> Bookings { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Discount> Discounts { get; set; } 
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<SocialMedia> SocialMedias { get; set; } 
        public DbSet<Testimonial> Testimonials { get; set; } 
    }
}
