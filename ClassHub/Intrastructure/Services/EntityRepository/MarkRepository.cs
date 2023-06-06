using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Marks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class MarkRepository : Repository<Mark>,IMarkRepository
    {
        public MarkRepository(IApplicationDbContext dbContext) : base(dbContext)
        { }
    }
}
