using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Coin :Money
    {
        public string SubCurrencyName { get; set; } = string.Empty;
        public string SubCurrencyMaterial { get; set;} = string.Empty;
        




    }
}
