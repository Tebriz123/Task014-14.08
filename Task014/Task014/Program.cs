


using System;
using System.Security.Cryptography;
using Task014.Models;

namespace Task014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 51;
            int b = 52;
            string password = "abbbbbb1";
            string password2 = "abbbbbb";
            string password3 = "Ali122343";
            string password4 = "123alTAar";
            Console.WriteLine(a.IsOdd());
            Console.WriteLine(b.IsOdd());
            Console.WriteLine("-----------------------");
            Console.WriteLine(a.IsEven());
            Console.WriteLine(b.IsEven());
            Console.WriteLine("-------------------------");
            Console.WriteLine(password.HasDigit());
            Console.WriteLine(password2.HasDigit());
            Console.WriteLine("------------------------");
            Console.WriteLine(password3.CheckPassword());
            Console.WriteLine(password.CheckPassword());
            Console.WriteLine(password4.CheckPassword());
        }
    }
}
