using Repositories;

namespace CustomerAppWithDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;
            var cRepo = new CustomerRepo();
            do
            {
                Console.WriteLine("\nWELCOME TO THE GRAND CUSTOMER APP\n");
                Console.WriteLine("1.ADD CUSTOMER\n2.ADD N CUSTOMERS\n3.PRINT CUSTOMERS\n" +
                    "4.RENAME A CUSTOMER\n5.DELETE A CUSTOMER");

                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ADD A CUSTOMER");
                        cRepo.AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("ADD N CUSTOMERS");
                        Console.WriteLine("n=");
                        var totalC = int.Parse(Console.ReadLine());
                        cRepo.AddCustomers(totalC);
                        break;
                    case 3:
                        Console.WriteLine("PRINT CUSTOMERS");
                        cRepo.PrintCustomers();
                        break;
                    case 4:
                        Console.WriteLine("RENAME A CUSTOMER");
                        Console.WriteLine("ENTER THE CUSTOMER YOU WANT TO RENAME: ");
                        var rCustomer = Console.ReadLine();
                        cRepo.UpdateCustomer(rCustomer);
                        break;
                    case 5:
                        Console.WriteLine("DELETE A CUSTOMER");
                        Console.WriteLine("ENTER THE NAME OF THE CUSTOMER YOU WANT TO DELETE: ");
                        var customerToDelete = Console.ReadLine();
                        cRepo.DeleteCustomer(customerToDelete);
                        break;
                    default:
                        Console.WriteLine("INVALID NUMBER");
                        isRunning = false;
                        break;
                }
            } while (isRunning);
        }
    }
}