using System.Runtime.CompilerServices;

namespace Money
{
    internal class Program
    {
        private static readonly string FilepathBankNotes = @"Data\Banknotes.csv";
        private static readonly string FilepathCoins = @"Data\Coins.csv";


        static void Main(string[] args)
        {


            var banknotes = LoaderBanknotes.LoadBankNotes(FilepathBankNotes);

            foreach (var banknote in banknotes)
            {
                Console.WriteLine(banknote);
            }

            var valuecoins = LoaderCoins.LoadValueCoins(FilepathCoins);


            foreach (var valuecoin in valuecoins)
            {
                Console.WriteLine(valuecoin.printOutCoin()); 
            }


        }
    }
}