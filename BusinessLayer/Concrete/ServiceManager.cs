using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICompanyService _companyService;
        private readonly IContactService _contactService;
        private readonly IInstitutionalService _institutionalService;
        private readonly IReferenceService _referenceService;
        private readonly IServiceAreaService _serviceAreaService;
        private readonly ITeamService _teamService;
        private readonly IUserService _userService;


        public ServiceManager(ICompanyService companyService, IContactService contactService, IInstitutionalService institutionalService, IReferenceService referenceService, IServiceAreaService serviceAreaService, ITeamService teamService, IUserService userService)
        {
            _companyService = companyService;
            _contactService = contactService;
            _institutionalService = institutionalService;
            _referenceService = referenceService;
            _serviceAreaService = serviceAreaService;
            _teamService = teamService;
            _userService = userService;
        }


        public ICompanyService CompanyService => _companyService;

        public IContactService ContactService => _contactService ;

        public IInstitutionalService InstitutionalService => _institutionalService;

        public IReferenceService ReferenceService => _referenceService;

        public IServiceAreaService ServiceAreaService => _serviceAreaService;

        public ITeamService TeamService => _teamService;

        public IUserService UserService => _userService;
    }
}
