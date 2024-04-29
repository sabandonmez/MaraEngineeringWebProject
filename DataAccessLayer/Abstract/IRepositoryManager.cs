using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryManager
    {
        ICompanyRepository CompanyRepository { get; }
        IContactRepository ContactRepository { get; }
        IInstitutionalRepository InstitutionalRepository { get; }
        IReferenceRepository ReferenceRepository { get; }
        IServiceAreaRepository ServiceAreaRepository { get; }
        ITeamRepository TeamRepository { get; }
        IUserRepository UserRepository { get; }
        void Save();

    }
}
