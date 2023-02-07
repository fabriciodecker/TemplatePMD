using System.Collections.Generic;
using System.Linq;
using Template.Domain.Entities;

namespace Template.Domain.Interfaces
{
    public interface IPidLineRepository : IRepository<PidLine>
	{
		IQueryable<PidLine> GetPidLineById(int id);
	}
}
