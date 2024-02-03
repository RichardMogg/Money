using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal sealed class BankNote : Bills
    {

        private int value =0; 
        
        //public int Value { get; set; } = 0;
        public double Length { get; set; } = 0;
        public double Width { get; set; } = 0;
        public string Color { get; set; } = string.Empty;

        public override int Value => value;

        public override string ToString()
        {
           return $"{base.Currency_Name} {base.Bill_Material} {Value} {Color}";
        }

        public BankNote(int value)
        {
            this.value = value;
        }
    }
}
