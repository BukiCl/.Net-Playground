using Models;

namespace Helpers
{
    public static class CustomerHelper
    {
        public static bool FindCustomer(this Customer customer, string fName)
        {
            if (customer.FirstName == fName)
                return true;
            return false;
        }
    }
}