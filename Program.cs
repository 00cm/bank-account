using BankAccountSim.Accounts;
using System.Text;

namespace BankAccountSim
{
    internal class Program
    {
        public static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Weclome to the Banking App!");
            bool flag = true;

            while (flag)
            {
                DisplayMainMenu();
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ViewCustomers();
                        break;
                    case 3:
                        ViewAccount();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("We didn't understand that, please try again.");
                        break;
                }
            }
        }

        public static void DisplayMainMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Please choose from the options below:");
            sb.AppendLine("1. Add Customer");
            sb.AppendLine("2. View Customers");
            sb.AppendLine("3. View Customer Accounts");
            sb.AppendLine("0. Exit");

            Console.WriteLine(sb.ToString());
        }

        public static void AddCustomer()
        {
            Random rand = new Random();
            int customerID = rand.Next();

            Console.WriteLine("Please enter customer's first name: ");
            string name = Console.ReadLine();

            Customer customer = new Customer(name, customerID);

            Console.WriteLine("Please enter your initial deposit: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Press 1 to add a savings account. Press 2 to add a checking account.");
            int input = int.Parse(Console.ReadLine());

            Account account;

            if (input == 1) 
            {
                account = new SavingsAccount(0.02m, name, balance);
            }
            else if (input == 2) 
            {
                account = new CheckingAccount(name, balance, 30.00m);
            }
            else
            {
                account = new Account(name, 0.0m);
            }

            customer.AddAccount(account);

            customers.Add(customer);
        }

        public static void ViewCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Name} - {customer.CustomerID}");
            }
        }

        public static void ViewAccount()
        {
            Console.WriteLine("Please enter your customerID: ");
            int input = int.Parse(Console.ReadLine());

            Customer customer = customers.Find(cust => cust.CustomerID == input);

            foreach (Account account in customer.Accounts)
            {
                Console.WriteLine($"{customer.Name}, your account {account.AccountNumber} has ${account.Balance}");
            }

        }
    }
}
