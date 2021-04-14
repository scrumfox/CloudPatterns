using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Queries.Query
{
    public class OneWidgetQuery : IQuery<Widget>
    {
        public int ID { get; private set; }
        public OneWidgetQuery(int id)
        {
            ID = id;
        }
    }
}
