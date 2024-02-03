using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class LoaderCoins
    {

        internal static ValueCoin[] LoadValueCoins(string filepath)
        {

            {
                return File.ReadAllLines(filepath)
                           .Skip(1)
                           .Select(l => l.Split(';'))
                           .Select(d =>
                           {
                               return new ValueCoin()
                               { //Name;SubName;Material;Value;SubValue;Diameter;Thickness;Weight;Color
                                   Currency_Name = d[0],
                                   SubCurrencyName = d[1],
                                   SubCurrencyMaterial = d[2],
                                   CoinValue = Convert.ToInt32(d[3]),
                                   SubValue = Convert.ToInt32(d[4]),
                                   Diameter = Convert.ToDouble(d[5]),
                                   Thickness = Convert.ToDouble(d[6]),
                                   Weight = Convert.ToDouble(d[7]),
                                   Color = d[8]


                               };
                           }).ToArray();
            }




        }
    }
}
