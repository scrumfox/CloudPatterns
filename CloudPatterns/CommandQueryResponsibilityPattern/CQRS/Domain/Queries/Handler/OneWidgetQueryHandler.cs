using CQRS.Domain.Queries.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Queries.Handler
{
    public class OneWidgetQueryHandler : IQueryHandler<OneWidgetQuery, Widget>
    {
        private readonly OneWidgetQuery _query;
        public OneWidgetQueryHandler(OneWidgetQuery query)
        {
            _query = query;
        }
        public Widget Get()
        {
            return MockWidgetDatabase.Widgets.FirstOrDefault(w => w.ID == _query.ID);
        }
    }
}
