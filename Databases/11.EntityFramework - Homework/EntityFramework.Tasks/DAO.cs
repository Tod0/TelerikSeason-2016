using System;
using System.Collections.Generic;
using System.Linq;

using EntityFramework.Data;

namespace EntityFramework.Tasks
{
    public class DAO
    {
        public static NorthwindEntities GetContext()
        {
            var dbContext = new NorthwindEntities();
            return dbContext;
        }

        /// <summary>
        /// Seccond change is saved.
        /// </summary>
        public static void ConcurrentChanges()
        {
            var contextA = DAO.GetContext();
            var contextB = DAO.GetContext();

            var customerA = contextA.Customers.FirstOrDefault();
            var customerB = contextB.Customers.FirstOrDefault();

            customerA.ContactName = "customer A";
            customerB.ContactName = "customer B";

            contextA.SaveChanges();
            contextB.SaveChanges();
        }

        public static Customer GetById(string id)
        {
            var context = DAO.GetContext();
            var customer = context.Customers.FirstOrDefault(c => c.CustomerID == id);
            return customer;
        }

        public static void InsertCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var context = DAO.GetContext();
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public static void ModifyCustomer(Customer modifiedCustomer)
        {
            if (modifiedCustomer == null)
            {
                throw new ArgumentNullException(nameof(modifiedCustomer));
            }

            var context = DAO.GetContext();
            var customerWithId = context.Customers
                .FirstOrDefault(customer => customer.CustomerID == modifiedCustomer.CustomerID);

            if (customerWithId == null)
            {
                throw new ArgumentException("Customer does not exist.");
            }

            var values = context.Entry(customerWithId).CurrentValues;
            values.SetValues(modifiedCustomer);
            context.SaveChanges();
        }

        public static void RemoveCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var context = DAO.GetContext();
            var matchingCustomer = context.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            context.Customers.Remove(matchingCustomer);
            context.SaveChanges();
        }

        public static IEnumerable<Customer> GetCustomersWithOrderYearAndCountry(int year, string country)
        {
            var context = DAO.GetContext();
            var customers = context.Orders
                .Where(o => o.OrderDate != null)
                .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country)
                .Select(o => o.Customer)
                .Distinct()
                .ToList();

            return customers;
        }

        public static IEnumerable<Order> FindsAllSalesByRegionAndPeriod(string shipReagion, DateTime start, DateTime end)
        {
            var context = DAO.GetContext();
            var orders = context.Orders
                .Where(o => o.OrderDate.HasValue && start <= o.OrderDate && o.OrderDate <= end)
                .Where(o => o.ShipRegion != null)
                .Where(o => o.ShipRegion == shipReagion)
                .ToList();

            return orders;
        }
    }
}

