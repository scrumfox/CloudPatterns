using CQRS.Domain.Queries.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Queries.Handler
{
    public class AllWidgetsQueryHandler : IQueryHandler<AllWidgetsQuery, IEnumerable<Widget>>
    {
        public IEnumerable<Widget> Get()
        {
            return MockWidgetDatabase.Widgets.OrderBy(w => w.Name);
        }
    }
}
