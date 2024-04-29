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
        private readonly CompanyRepository _companyRepository;
        private readonly ContactRepository _contactRepository;
        private readonly InstitutionalRepository _institutionalRepository;
        private readonly ReferenceRepository _referenceRepository;
        private readonly ServiceAreaRepository _serviceAreaRepository;
        private readonly TeamRepository _teamRepository;
        private readonly UserRepository _userRepository;

        public RepositoryManager(MaraContext context, CompanyRepository companyRepository, ContactRepository contactRepository, InstitutionalRepository institutionalRepository, ReferenceRepository referenceRepository, ServiceAreaRepository serviceAreaRepository, TeamRepository teamRepository, UserRepository userRepository)
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
