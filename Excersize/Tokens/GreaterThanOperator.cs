﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Excersize.Tokens
{
    public class GreaterThanOperator : ComparerToken
    {
        public GreaterThanOperator(string lexeme) 
            : base(lexeme)
        {
        }
    }
}
