using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NoWayOut.Data.Entity;

namespace NoWayOut.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NoWayOut.Models.ViewModels.Rooms.RoomViewModel> RoomViewModel { get; set; }
        public DbSet<NoWayOut.Models.ViewModels.Rooms.CreateRoomViewModel> CreateRoomViewModel { get; set; }

    }

}
