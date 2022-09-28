using eComWebAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eComWebAPI.ViewModels
{
    public class eComInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<eComContext>
    {
        protected override void Seed(eComContext context)
        {
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
