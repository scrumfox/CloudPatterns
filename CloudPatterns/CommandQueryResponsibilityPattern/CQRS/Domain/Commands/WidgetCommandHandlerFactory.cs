using CQRS.Domain.Commands.Command;
using CQRS.Domain.Commands.Handler;
using CQRS.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Commands
{
    public static class WidgetCommandHandlerFactory
    {
        public static ICommandHandler<SaveWidgetCommand, CommandResponse> Build(SaveWidgetCommand command)
        {
            return new SaveWidgetCommandHandler(command);
        }
    }
}
