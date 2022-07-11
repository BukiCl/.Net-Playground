using Workers;
    
namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;
            var customerWorker = new CustomerWorker();
            do
            {
                Console.WriteLine("\nWELCOME TO THE GRAND CUSTOMER APP\n");
                Console.WriteLine("1.ADD CUSTOMER\n2.ADD N CUSTOMERS\n3.PRINT CUSTOMERS\n" +
                    "4.RENAME A CUSTOMER");

                var choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("ADD A CUSTOMER");
                        customerWorker.AddCustomer();
                        break;
                    case 2:
                        Console.WriteLine("ADD N CUSTOMERS");
                        Console.WriteLine("n=");
                        var totalC = int.Parse(Console.ReadLine());
                        customerWorker.AddCustomers(totalC);
                        break;
                    case 3:
                        Console.WriteLine("PRINT CUSTOMERS");
                        customerWorker.Write2Console();
                        break;
                    case 4:
                        Console.WriteLine("RENAME A CUSTOMER");
                        Console.WriteLine("ENTER THE CUSTOMER YOU WANT TO RENAME: ");
                        var rCustomer = Console.ReadLine();
                        customerWorker.RenameCustomer(rCustomer);
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