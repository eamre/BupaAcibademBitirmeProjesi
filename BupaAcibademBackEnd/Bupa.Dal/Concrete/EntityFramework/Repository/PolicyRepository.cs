using Bupa.Dal.Abstract;
using Bupa.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Dal.Concrete.EntityFramework.Repository
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        public PolicyRepository(DbContext context) : base(context)
        {

        }

    }
}
