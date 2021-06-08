using NTierProject.DATAACCESS.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class OrderRepository : Repository<Order>
    {
        private readonly ProjectContext _context;
        public OrderRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
