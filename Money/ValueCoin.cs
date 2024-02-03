using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal sealed class ValueCoin : Coin
    {
        //value
        //Durchmesser
        //Dicke
        //gewicht
        //Farbe

        public int CoinValue { get; set; } = 0;
        public int SubValue { get; set; } = 0;
        public double Thickness { get; set; } = 0;
        public double Weight { get; set; } = 0;
        public string Color { get; set; } = string.Empty;
        public double Diameter { get; set; } = 0;

        public string printOutCoin()
        {
            if (CoinValue > 0)
            {
                var tempValue = CoinValue;
                return $"{base.Currency_Name} {tempValue} {Diameter} {Color}";
            }
            if (SubValue > 0) 
            { 
                var tempValue = SubValue;
                return $"{base.SubCurrencyName} {tempValue} {Diameter} {Color}";

            }
            return string.Empty;
        }

    }
}
