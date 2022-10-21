using System;

namespace Spg.RockThatShop.Domain.Model
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string hello = "Hello World";
            //Console.WriteLine(hello[..^2]);


            //----------------------Test Abbreviation Property of Class Brand-----------------------------------
            Brand brand1 = new Brand() { Id = 1, Name = "Duesenberg" };
            //Brand brand1 = new Brand() { Id = 1};
            //brand1.Name = "Duesenberg";
            Console.WriteLine("Brand1: -------------------------------------");
            Console.WriteLine($"Brand-ID: {brand1.Id}\n Brand-Name: {brand1.Name}\n Brand-Abbreviation: {brand1.Abbreviation}");

            Brand brand2 = new Brand();
            brand2.Id = 2;
            brand2.Name = "Li";
            Console.WriteLine("Brand2: -------------------------------------");
            Console.WriteLine($"Brand-ID: {brand2.Id}\n Brand-Name: {brand2.Name}\n Brand-Abbreviation: {brand2.Abbreviation}");


        }
        //Console.WriteLine("Hello World");
    }
}