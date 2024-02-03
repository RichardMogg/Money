using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Money
    {
        public string Currency_Name { get; set; } = string.Empty;
        public abstract int Value { get; }
    }
}
