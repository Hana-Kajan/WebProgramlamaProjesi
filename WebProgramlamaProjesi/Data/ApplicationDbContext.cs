using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProgramlamaProjesi.Models;

namespace WebProgramlamaProjesi.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<AnaSayfa> AnaSayfa { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
