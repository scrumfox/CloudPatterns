﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain.Queries
{
    public interface ICommand<out TResult> { }
}
