using Microsoft.EntityFrameworkCore;
using PaymentApp;
using System.Collections.Generic;

namespace PaymentWebApi;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<User> Users { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<VirtualCard> VirtualCards { get; set; }
    public DbSet<Payment> Payments { get; set; }
}
