using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Money
{
    internal class LoaderBanknotes
    {

        internal static BankNote[] LoadBankNotes(string filepath)
        {
            //Name; Material; Value; Lenght; Width; Color

            {
                return File.ReadAllLines(filepath)
                           .Skip(1)
                           .Select(l => l.Split(';'))
                           .Select(d =>
                           {
                               return new BankNote(Convert.ToInt32(d[2]))
                               {
                                   Currency_Name = d[0],
                                   Bill_Material = d[1],
                                   Length = Convert.ToInt32(d[3]),
                                   Width = Convert.ToInt32(d[4]),
                                   Color = d[5]

                               };
                           }).ToArray();
            }




        }
    }
}
