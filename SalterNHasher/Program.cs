using System;
using SalterNHasher.Services;

namespace SalterNHasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IHasherNSalterServices hasherNSalterServices = new HasherNSalterServices();
            Console.WriteLine(hasherNSalterServices.GenerateRandomPassword(124));
        }
    }
}