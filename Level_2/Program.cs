using FluentValidation;
using Level_2.Entities;
using Level_2.ValidationRules;
using System;

namespace Level_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Komplex tiplerde doğrulama ve placeholders işlemleri
            IValidator<Customer> validator = new CustomerValidator();
            Customer customer = new Customer();
            customer.Address=new Address();

            InputValue(customer);

            var validationResult = validator.Validate(customer);

            if (!validationResult.IsValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------------Hata----------------------");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Doğrulama başarılı");
            }
            Console.Read();
        }

        static void InputValue(Customer customer)
        {
            Console.Write("İsminizi giriniz : ");
            customer.Name = Console.ReadLine();

            Console.Write("Soyisminizi giriniz : ");
            customer.Surname = Console.ReadLine();

            Console.Write("Kimlik numaranızı giriniz : ");
            customer.NationalityId = Console.ReadLine();

            Console.Write("Yaşadığınız şehiri giriniz : ");
            customer.Address.City = Console.ReadLine();

            Console.Write("Yaşadığınız sokağı giriniz : ");
            customer.Address.Street = Console.ReadLine();
        }
    }
}
