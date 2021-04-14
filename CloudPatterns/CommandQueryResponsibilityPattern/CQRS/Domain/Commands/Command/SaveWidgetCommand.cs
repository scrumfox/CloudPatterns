using CQRS.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Commands.Command
{
    public class SaveWidgetCommand : ICommand<CommandResponse>
    {
        public Widget Widget { get; private set; }
        public SaveWidgetCommand(Widget item)
        {
            Widget = item;
        }
    }
}
