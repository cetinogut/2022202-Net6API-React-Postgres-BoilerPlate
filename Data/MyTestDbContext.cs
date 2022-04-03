using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using reactnet.Models;

namespace reactnet.Data;

public class MyTestDbContext : DbContext
{
    public MyTestDbContext(DbContextOptions<MyTestDbContext> options): base(options)
    {

    }
    public DbSet<Note> Notes { get; set; }
}
