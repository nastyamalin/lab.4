﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._1_
{
    class Hour
    {
        public int Value { get; }

        public Hour(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} год";
        }
    }
}
