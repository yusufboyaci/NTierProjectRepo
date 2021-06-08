using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class UserRepository : Repository<User>
    {
        private readonly ProjectContext _context;
        public UserRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
        public User FindByUserName()
        {

        }
        public bool CheckCredential()
        {

        }
    }
}
