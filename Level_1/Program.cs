using FluentValidation;
using Level_1.Entities;
using Level_1.ValidationRules;
using System;

namespace Level_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IValidator<Customer> validator = new CustomerValidator();
            Customer customer = new Customer();

            Console.Write("İsminizi giriniz : ");
            customer.Name = Console.ReadLine();

            Console.Write("Soyisminizi giriniz : ");
            customer.Surname = Console.ReadLine();

            Console.Write("Kimlik numaranızı giriniz : ");
            customer.NationalityId = Console.ReadLine();

            Console.Write("Yaşadığınız şehiri giriniz : ");
            customer.City = Console.ReadLine();

            var validationResult=validator.Validate(customer);
            if (!validationResult.IsValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------------Hata----------------------");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            Console.Read();
            
        }
    }
}
