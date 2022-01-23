﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Contract
{
    public interface IUnitOfWork
    {
        IEmployee Employee { get; }
        
    }
}
