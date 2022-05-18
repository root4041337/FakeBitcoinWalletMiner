using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeBitcoinWalletMiner.A
{
    public class Miner
    {

        public static void _Miner()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 99999; i++)
            {
                Console.WriteLine("[-] " + RandomString(64) + "-> 0.0000 BTC");
            }

            Thread.Sleep(12);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("[+] " + RandomString(64) + "-> 4.1556 BTC");
            Console.ReadKey();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
