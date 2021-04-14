﻿namespace CQRS.Domain.Queries
{
    public interface ICommandHandler<in TCommand, out TResult> where TCommand : ICommand<TResult>
    {
        TResult Execute();
    }
}
