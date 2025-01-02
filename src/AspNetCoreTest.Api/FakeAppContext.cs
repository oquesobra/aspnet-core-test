using AspNetCoreTest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.Api;

public class FakeAppContext : DbContext
{
    public DbSet<User> Users { get; set; }
}