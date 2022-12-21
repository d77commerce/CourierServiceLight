using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Common.Administration
{
    public class AdministrationRepository : Repository,IAdministrationRepository
    {
        public AdministrationRepository(ApplicationDbContext context) 
        {
            Context = context;
        }
    }
}
