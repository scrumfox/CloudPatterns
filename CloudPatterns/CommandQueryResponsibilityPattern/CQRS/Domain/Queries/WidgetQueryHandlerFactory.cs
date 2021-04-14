using CQRS.Domain.Queries.Handler;
using CQRS.Domain.Queries.Query;
using System.Collections.Generic;

namespace CQRS.Domain.Queries
{
    public static class WidgetQueryHandlerFactory
    {
        public static IQueryHandler<AllWidgetsQuery, IEnumerable<Widget>> Build(AllWidgetsQuery query)
        {
            return new AllWidgetsQueryHandler();
        }

        public static IQueryHandler<OneWidgetQuery, Widget> Build(OneWidgetQuery query)
        {
            return new OneWidgetQueryHandler(query);
        }
    }
}
