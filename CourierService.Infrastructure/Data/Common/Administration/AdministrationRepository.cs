using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Common.Administration
{
    public class AdministrationRepository : Repository,IAdministrationRepository
    {
        public AdministrationRepository(AdministrationDbContext context)
        {
            this.Context = context;
        }
    }
}
