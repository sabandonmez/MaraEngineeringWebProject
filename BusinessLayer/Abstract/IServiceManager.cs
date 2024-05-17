using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        IContactService ContactService { get; }
        IInstitutionalService InstitutionalService { get; }
        IReferenceService ReferenceService { get; }
        IServiceAreaService ServiceAreaService { get; }
        ITeamService TeamService { get; }
        IUserService UserService { get; }


    }
}
