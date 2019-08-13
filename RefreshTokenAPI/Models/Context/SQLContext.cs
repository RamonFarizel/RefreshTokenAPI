using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Models.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }

        public SQLContext(DbContextOptions<SQLContext> options) : base(options)
        {

        }
        //Mesmo nome da tabela do banco de DADOS!!!!!
        public DbSet<User> Users { get; set; }
    }
}
