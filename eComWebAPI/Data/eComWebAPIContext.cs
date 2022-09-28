using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eComWebAPI.ViewModels.User;

namespace eComWebAPI.Data
{
    public class eComWebAPIContext : DbContext
    {
        public eComWebAPIContext (DbContextOptions<eComWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<eComWebAPI.ViewModels.User.UserModel> UserModel { get; set; }
    }
}
