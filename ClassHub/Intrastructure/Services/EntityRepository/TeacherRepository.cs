using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Teachers;
using Intrastructure.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    internal class TeacherRepository : Repository<Teacher>,ITeacherRepository
    {
        private readonly IApplicationDbContext dbContext;

        public TeacherRepository(IApplicationDbContext dbContext):base(dbContext)
            => this.dbContext = dbContext;

    }
}
