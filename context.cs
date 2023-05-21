using Microsoft.EntityFrameworkCore;
using SuperHeroes.models;

namespace SuperHeroes
    public class context:DbContext
    {
        public DbSet<superhero> superhero {get;set;}

        public context(DbContextOptions<context> options) : base(options){}
    }
}