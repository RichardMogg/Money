using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Bills : Money
    {
        public string Bill_Material {  get; set; }=string.Empty;
    }
}
