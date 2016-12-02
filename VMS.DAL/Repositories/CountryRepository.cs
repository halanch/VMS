using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.DAL.DataContext;
using VMS.Model;

namespace VMS.DAL.Repositories
{
   public class CountryRepository : RepositoryBase<Country>
    {
        public CountryRepository(VMSDataContext context):base(context)
        {
            if (context == null)
            {
                throw new Exception("No context information was sent.");
            }
        }
    }
}
