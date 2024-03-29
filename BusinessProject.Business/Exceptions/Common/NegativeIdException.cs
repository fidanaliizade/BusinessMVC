﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.Exceptions.Common
{
    public class NegativeIdException : Exception
    {
        public NegativeIdException() : base("Id can't be negative or zero.")
        {
            
        }
        public NegativeIdException(string? message) : base(message)
        {
        }
    }
}
