using CQRS.Domain.Commands.Command;
using CQRS.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Commands.Handler
{
    public class SaveWidgetCommandHandler : ICommandHandler<SaveWidgetCommand, CommandResponse>
    {
        private readonly SaveWidgetCommand _command;
        public SaveWidgetCommandHandler(SaveWidgetCommand command)
        {
            _command = command;
        }
        public CommandResponse Execute()
        {
            var response = new CommandResponse()
            {
                Success = false
            };
            try
            {
                var item = MockWidgetDatabase
                    .Widgets
                    .FirstOrDefault(w => w.ID == _command.Widget.ID);
                if (item == null)
                {
                    item = new Widget
                    {
                        ID = MockWidgetDatabase.UniqueWidgetId
                    };
                    MockWidgetDatabase.UniqueWidgetId++;
                    MockWidgetDatabase.Widgets.Add(item);
                }
                else
                {
                    item.Name = item.Name;
                    item.Shape = item.Shape;
                }
                response.ID = item.ID;
                response.Success = true;
                response.Message = "Saved widget.";
            }
            catch
            {
                // log error
            }
            return response;
        }
    }
}
