using CustomerApp.Data;
using CustomerApp.Domain;

namespace Repositories
{
    public class CustomerRepo
    {
        private readonly CustomerContext _context = new CustomerContext();

        public void AddCustomer()
        {
            Console.WriteLine("ADD A CUSTOMER TO THE DATABASE");
            Console.WriteLine("FIRST NAME: ");
            var fName = Console.ReadLine();
            Console.WriteLine("LAST NAME: ");
            var lName = Console.ReadLine();
            Console.WriteLine("PHONE NUMBER");
            var pNumber = Console.ReadLine();

            var customer = new Customer { FirstName = fName, LastName = lName, PhoneNumber = pNumber };

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void AddCustomers(int totalCustomers)
        {
            for(int i = 0; i < totalCustomers; i++)
            {
                Console.WriteLine("ADD A CUSTOMER TO THE DATABASE");
                Console.WriteLine("FIRST NAME: ");
                var fName = Console.ReadLine();
                Console.WriteLine("LAST NAME: ");
                var lName = Console.ReadLine();
                Console.WriteLine("PHONE NUMBER");
                var pNumber = Console.ReadLine();

                var customer = new Customer { FirstName = fName, LastName = lName, PhoneNumber = pNumber };

                _context.Customers.Add(customer);
            }
            _context.SaveChanges();
        }


        public void PrintCustomers()
        {
            var allCustomersToList = _context.Customers.ToList();
            foreach(var customer in allCustomersToList)
            {
                Console.WriteLine($"\n{customer.ShowInfo()}");
            }
        }


        public void UpdateCustomer(string? fName)
        {
            var allCustomersInDb = _context.Customers.ToList();
            var customerInList = allCustomersInDb.Where(c => c.FirstName == fName).FirstOrDefault();
            if(customerInList is null)
            {
                Console.WriteLine("CUSTOMER DOSEN'T EXIST");
            } else
            {
                Console.WriteLine("ENTER THE NEW FIRST NAME: ");
                var fNameReplacement = Console.ReadLine();
                customerInList.FirstName = fNameReplacement;
            }
            _context.SaveChanges();
        }


        public void DeleteCustomer(string? fName)
        {
            var allCustomersInDb = _context.Customers.ToList();
            var customerInList = allCustomersInDb.Where(c => c.FirstName == fName).FirstOrDefault();
            if (customerInList is null)
            {
                Console.WriteLine("CUSTOMER DOSEN'T EXIST");
            }
            else
            {
                _context.Customers.Remove(customerInList);
            }
            _context.SaveChanges();
        }
    }
}