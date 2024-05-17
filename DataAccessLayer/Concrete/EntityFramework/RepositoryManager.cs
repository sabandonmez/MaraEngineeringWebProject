using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly MaraContext _context;
        private readonly ICompanyRepository _companyRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IInstitutionalRepository _institutionalRepository;
        private readonly IReferenceRepository _referenceRepository;
        private readonly IServiceAreaRepository _serviceAreaRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly IUserRepository _userRepository;

        public RepositoryManager(MaraContext context, ICompanyRepository companyRepository, IContactRepository contactRepository, IInstitutionalRepository institutionalRepository, IReferenceRepository referenceRepository, IServiceAreaRepository serviceAreaRepository, ITeamRepository teamRepository, IUserRepository userRepository)
        {
            _context = context;
            _companyRepository = companyRepository;
            _contactRepository = contactRepository;
            _institutionalRepository = institutionalRepository;
            _referenceRepository = referenceRepository;
            _serviceAreaRepository = serviceAreaRepository;
            _teamRepository = teamRepository;
            _userRepository = userRepository;
        }


        public ICompanyRepository CompanyRepository => _companyRepository;

        public IContactRepository ContactRepository => _contactRepository;

        public IInstitutionalRepository InstitutionalRepository => _institutionalRepository;

        public IReferenceRepository ReferenceRepository => _referenceRepository;

        public IServiceAreaRepository ServiceAreaRepository => _serviceAreaRepository;

        public ITeamRepository TeamRepository => _teamRepository;

        public IUserRepository UserRepository => _userRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
