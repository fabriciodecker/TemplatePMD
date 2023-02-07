using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Template.Data.Context;
using Template.Domain.Entities;
using Template.Domain.Interfaces;


namespace Template.Data.Repositories
{
    public class PidLineRepository : Repository<PidLine>, IPidLineRepository
    {
        public PidLineRepository(SQLServerContext context)
            : base(context) { }

        public IQueryable<PidLine> GetPidLineById(int id)
        {
            return Query(x => x.Id == id && x.IsActive);
        }
    }
}
