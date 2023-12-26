using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameStore.Models;

namespace GameStore.Data
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext (DbContextOptions<GameStoreContext> options)
            : base(options)
        {
        }

        public DbSet<GameStore.Models.Games> Games { get; set; } = default!;
    }
}
