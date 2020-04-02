using System;
using System.Collections.Generic;
using System.Text;
using DemoWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoWebsite.Data
{
    public class CMSDbContext : IdentityDbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<CMS> CMSs { get; set; }
    }
}
