﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto175.Entities.Exceptions
{
    internal class WithdrawException : ApplicationException
    {
        public WithdrawException(string message)
            : base(message) { }
        
    }
}
