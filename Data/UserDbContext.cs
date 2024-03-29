using MRV_resturant.Models;
using Microsoft.EntityFrameworkCore;

namespace MRV_resturant.Data
{
    public class UserDbContext : DbContext    
    {
        public UserDbContext(DbContextOptions<UserDbContext> s) : base(s){}

        public DbSet<RegistrestionModel> DB01T01 { get; set; }
        public DbSet<ReservationModel> DB01T02 { get; set; }
        public DbSet<FeedbackModel> DB01T03 { get; set; }
        public DbSet<MenuItemModel> DB01T04 { get; set;}
        public DbSet<ContectModel> DB01T05 { get; set; }
        public DbSet<SubscribeModel> DB01T06 { get; set; }


    }
}