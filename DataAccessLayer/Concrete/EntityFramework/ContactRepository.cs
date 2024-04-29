using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class ContactRepository:EfEntityRepositoryBase<Contact,MaraContext>,IContactRepository
    {
        private readonly MaraContext _context;
        public ContactRepository(MaraContext context)
        {

            _context = context;

        }
    }
}
