using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Database
{
    internal class ScreenSoundContext : DbContext

    {
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Music> Music { get; set; }

        private string connectionDB = "Data Source=JONATHANFEITOR\\MSSQLSERVER_2019;Initial Catalog=ScreenSoundV2;Integrated Security=True;" +
            "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionDB)
                .UseLazyLoadingProxies();
        }

    }
}
