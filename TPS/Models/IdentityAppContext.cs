using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASPNET_Core_3.Models
{
    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {

        }
    }
}
