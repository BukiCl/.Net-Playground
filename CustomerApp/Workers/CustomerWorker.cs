using Models;
using Helpers;

namespace Workers
{
    public class CustomerWorker
    {
        public List<Customer> Customers { get; set; }
        public int TotalCustomers { get; set; }

        public CustomerWorker()
        {
            Customers = new List<Customer>();
            TotalCustomers = 0;
        }


        public void AddCustomer()
        {
            Console.WriteLine("First Name: ");
            var fName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            var lName = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            var pNumber = Console.ReadLine();
            var customer = new Customer(fName, lName, "", "", "", "", 0, pNumber);
            Customers.Add(customer);
        }

        public void AddCustomers(int totalCustomers)
        {
            for(int i = 0; i < totalCustomers; i++)
            {
                Console.WriteLine("First Name: ");
                var fName = Console.ReadLine();
                Console.WriteLine("Last Name: ");
                var lName = Console.ReadLine();
                Console.WriteLine("Phone Number: ");
                var pNumber = Console.ReadLine();
                var customer = new Customer(fName, lName, "", "", "", "", 0, pNumber);
                Customers.Add(customer);
            }
        }

        public void RenameCustomer(string? fName)
        {
            //without linq
            //foreach(var customer in Customers) {
            //    if(customer.FindCustomer(fName))
            //    {
            //        Console.WriteLine("ENTER THE NEW FIRSTNAME: ");
            //        var nFName = Console.ReadLine();
            //        customer.FirstName = nFName;
            //    }
            //} 

            var customerInList = Customers.Where(e => e.FirstName == fName).FirstOrDefault();
            if(customerInList is not null)
            {
                Console.WriteLine("ENTER THE NEW FIRSTNAME: ");
                var nFName = Console.ReadLine();
                customerInList.FirstName = nFName;
            } else
            {
                Console.WriteLine("Customer dosen't exist!");
            }
        }

        public void DeleteCustomer(string? customerToDelete)
        {
            var customerInList = Customers.Where(e => e.FirstName == customerToDelete).FirstOrDefault();
            if(customerInList is not null)
            {
                Customers.Remove(customerInList);
                Console.WriteLine("DELETE WAS SUCCESFULL");
            } else
            {
                Console.WriteLine("CUSTOMER DOSEN'T EXIST!");
            }
        }

        public void Write2Console()
        {
            foreach(var customer in Customers)
            {
                Console.WriteLine(customer.ShowInfo());
            }
        }
    }
}