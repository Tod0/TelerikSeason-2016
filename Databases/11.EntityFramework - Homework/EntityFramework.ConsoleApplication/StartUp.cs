using System;
using System.Data.SqlClient;
using System.Linq;

using EntityFramework.Data;
using EntityFramework.Tasks;

namespace EntityFramework.ConsoleApplication
{
    public class StartUp
    {
        private const string CustomerId = "ASDFG";

        public static void Main()
        {
            StartUp.InsertCustomer(StartUp.CustomerId, "Company");
            StartUp.ModifyCustomer(StartUp.CustomerId);
            StartUp.RemoveCustomer(StartUp.CustomerId);

            StartUp.InsertCustomerWithSql(StartUp.CustomerId, "Company");
            StartUp.ModifyCustomerWithSql(StartUp.CustomerId);
            StartUp.RemoveCustomerWithSql(StartUp.CustomerId);

            StartUp.CustomersWithOrdersFromYearToCountry(1997, "Canada");
            StartUp.CustomersWithOrdersFromYearToCountryWithSQL(1997, "Canada");

            var end = new DateTime(2000, 6, 1);
            var start = new DateTime(1996, 6, 1);
            StartUp.FindsAllSalesByRegionAndPeriod("Essex", start, end);

            DAO.ConcurrentChanges();
        }

        private static void InsertCustomerWithSql(string id, string companyName)
        {
            var query =
                @"INSERT INTO Customers (CustomerID, CompanyName)
                        VALUES(@id, @company)";

            var context = DAO.GetContext();
            context.Database.ExecuteSqlCommand(
                query,
                new SqlParameter("@id", id),
                new SqlParameter("@company", companyName));
        }

        private static void ModifyCustomerWithSql(string id)
        {
            var query =
                @"UPDATE Customers
                    SET CompanyName = @company
                    WHERE CustomerID = @id";

            var context = DAO.GetContext();
            context.Database.ExecuteSqlCommand(
                query,
                new SqlParameter("@id", id),
                new SqlParameter("@company", "changed"));
        }

        private static void RemoveCustomerWithSql(string id)
        {
            var query =
                @"DELETE FROM Customers
                    WHERE CustomerID = @id";

            var context = DAO.GetContext();
            context.Database.ExecuteSqlCommand(query, new SqlParameter("@id", id));
        }

        private static void InsertCustomer(string id, string companyName)
        {
            var customer = new Customer()
            {
                CustomerID = id,
                CompanyName = companyName
            };

            DAO.InsertCustomer(customer);
        }

        private static void ModifyCustomer(string id)
        {
            var customer = DAO.GetById(id);
            customer.ContactName = "contact name";
            DAO.ModifyCustomer(customer);
        }

        private static void RemoveCustomer(string id)
        {
            var customer = DAO.GetById(id);
            DAO.RemoveCustomer(customer);
        }

        private static void CustomersWithOrdersFromYearToCountry(int year, string country)
        {
            var customers = DAO.GetCustomersWithOrderYearAndCountry(year, country);

            Console.WriteLine($"Customers with NativeSQL, OrderYear: {year}, Country: {country}");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.ContactName}, Country: {customer.Country}");
            }

            Console.WriteLine();
        }

        private static void CustomersWithOrdersFromYearToCountryWithSQL(int year, string country)
        {
            var queryTemplate = @"SELECT *
                    FROM Customers c
                    JOIN Orders o
                        ON o.CustomerID = c.CustomerID
                    WHERE o.ShipCountry = '{1}' AND YEAR(o.OrderDate) = {0}";
            var query = string.Format(queryTemplate, year, country);

            var context = new NorthwindEntities();
            var customers = context.Customers.SqlQuery(query).Distinct().ToList();

            Console.WriteLine($"Customers with NativeSQL, OrderYear: {year}, Country: {country}");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.ContactName}, Country: {customer.Country}");
            }

            Console.WriteLine();
        }

        private static void FindsAllSalesByRegionAndPeriod(string shipReagion, DateTime start, DateTime end)
        {
            var orders = DAO.FindsAllSalesByRegionAndPeriod(shipReagion, start, end);

            Console.WriteLine($"Orders between, Start: {start.ToShortDateString()}, End: {end.ToShortDateString()}, Region: {shipReagion}");
            foreach (var order in orders)
            {
                Console.WriteLine($"Name: {order.OrderDate}, Country: {order.ShipRegion}");
            }

            Console.WriteLine();
        }
    }
}
