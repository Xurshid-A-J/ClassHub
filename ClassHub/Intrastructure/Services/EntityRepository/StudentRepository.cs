using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Intrastructure.Services.EntityRepository
{
    public class StudentRepository : Repository<Student>,IStudentRepository
    {
        public StudentRepository(IApplicationDbContext dbContext) : base(dbContext)
        { }
    }
}
