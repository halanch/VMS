using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Model;
using VMS.DAL.DataContext;
namespace VMS.DAL.Repositories
{
  public  class VolunteerRepository:RepositoryBase<Volunteer>
    {

        public VolunteerRepository(VMSDataContext context):base(context)
        {
            if (context==null)
            {
                throw new Exception("No context information was sent.");
            }
        }

        //public List<Volunteer> SearchByName(string Name)
        //{

        //}
        //public List<Volunteer> SearchByID(long ID)
        //{

        //}
    }
}
