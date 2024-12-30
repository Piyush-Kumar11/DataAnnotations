using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Id: ");
            int id  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Phone: ");
            string phone = Console.ReadLine();

            User user = new User()
            {
                Id = id,
                Name = name,
                Email = email,
                Phone = phone
            };

            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (isValid)
            {
                Console.WriteLine("User data validated successfully");
            }
            else
            {
                Console.WriteLine("Data not valid");
                //It will print the error messages for each validation stored in a list of Validation Results
                foreach (var i in results)
                {
                    Console.WriteLine(i.ErrorMessage);
                }
            }
        }
    }
}
