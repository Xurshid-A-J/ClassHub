using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(IApplicationDbContext dbContext) : base(dbContext)
        { }
    }
}
